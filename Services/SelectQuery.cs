using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;


namespace Comedor_Asados_La_Flaca.Services
{
    /// <summary>
    /// Subclase para ejecutar consultas SELECT.
    /// Devuelve datos como DataTable para uso directo en controles Windows Forms
    /// (DataGridView, ComboBox, ListBox, etc.).
    /// </summary>
    public class SelectQuery : DataBaseConnection
    {
        public SelectQuery() : base() { }
        public SelectQuery(string connectionString) : base(connectionString) { }

        public DataTable ExecuteSelect(string query, SqlParameter[] parameters = null)
        {
            DataTable result = new DataTable();

            try
            {
                OpenConnection();

                _command = new SqlCommand(query, _connection);
                _command.CommandType = CommandType.Text;

                if (parameters is not null)
                    _command.Parameters.AddRange(parameters);

                using SqlDataAdapter adapter = new SqlDataAdapter(_command);
                adapter.Fill(result);
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al intentar obtener resultados: {ex.Message}", ex);
            }
            finally
            {
                CloseConnection();
            }

            return result;
        }

        public bool IsDuplicate(string query, SqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();

                _command = new SqlCommand(query, _connection);
                _command.CommandType = CommandType.Text;

                if (parameters is not null)
                    _command.Parameters.AddRange(parameters);

                return Convert.ToBoolean(_command.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al ejecutar consulta escalar: {ex.Message}", ex);
            }
            finally
            {
                CloseConnection();
            }
        }

        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();

                using SqlCommand cmd = new SqlCommand(query, _connection);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al ejecutar consulta escalar: {ex.Message}", ex);
            }
            finally
            {
                CloseConnection();
            }
        }

        public DataTable GetEmpleadosActivos()
        {
            using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
            {
                string sql = @"
            SELECT Codigo, Nombre, Cedula, Telefono, Cargo, Salario, FechaIngreso,
                   'Trabajando' AS Estado
            FROM Empleados
            WHERE Activo = 1";  

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable BuscarPorCodigo(string codigo)
        {
            using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
            {
                string sql = @"
            SELECT Codigo, Nombre, Cedula, Telefono, Cargo, Salario, FechaIngreso,
                   CASE WHEN Activo = 1 THEN 'Trabajando' ELSE 'Despedido' END AS Estado
            FROM Empleados
            WHERE Codigo LIKE @codigo + '%'";   

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@codigo", codigo);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }



        public bool GetEstadoCliente(string codigo)
        {
            string sql = "SELECT Activo FROM Clientes WHERE Codigo = @codigo";
            SqlParameter[] parametros = { new SqlParameter("@codigo", codigo) };

            DataTable dt = ExecuteSelect(sql, parametros);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToBoolean(dt.Rows[0]["Activo"]);
            }

            // Si no encuentra nada, por defecto lo consideramos inactivo
            return false;
        }

        public DataTable BuscarClientePorCodigo(string codigo)
        {
            string sql = @"
        SELECT Codigo,
               Nombre,
               Telefono,
               Direccion,
               Notas,
               CASE WHEN Activo = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado
        FROM Clientes
        WHERE Codigo LIKE @Codigo";

            var parametros = new[]
            {
        new SqlParameter("@Codigo", codigo + "%")
    };

            return ExecuteSelect(sql, parametros);
        }




        public string ValidarLogin(string usuario, string contraseña)
        {
            string query = @"SELECT Cargo 
                     FROM Usuarios 
                     WHERE NombreUsuario = @usuario 
                       AND ContraseñaHash = @password 
                       AND Activo = 1";

            var parametros = new[]
            {
        new SqlParameter("@usuario", usuario),
        new SqlParameter("@password", contraseña)
    };

            object result = ExecuteScalar(query, parametros);

            return result?.ToString(); // Devuelve el cargo si existe, null si no
        }

        public string GetNextCodigoEmpleado()
        {
            string query = @"SELECT TOP 1 Codigo 
                     FROM Empleados 
                     ORDER BY CAST(SUBSTRING(Codigo, 5, LEN(Codigo)) AS INT) DESC";

            SelectQuery selectService = new SelectQuery();
            DataTable dt = selectService.ExecuteSelect(query);

            if (dt.Rows.Count == 0)
            {
                return "EMP-0001"; 
            }

            string ultimoCodigo = dt.Rows[0]["Codigo"].ToString(); 
            int numero = int.Parse(ultimoCodigo.Substring(4));     
            numero++;
            return "EMP-" + numero.ToString("D4");                 
        }
        public string GetNextCodigoCliente()
        {
            string query = @"SELECT TOP 1 Codigo 
                     FROM Clientes 
                     ORDER BY CAST(SUBSTRING(Codigo, 5, LEN(Codigo)) AS INT) DESC";

            SelectQuery selectService = new SelectQuery();
            DataTable dt = selectService.ExecuteSelect(query);

            if (dt.Rows.Count == 0)
            {
                return "CLI-0001";
            }

            string ultimoCodigo = dt.Rows[0]["Codigo"].ToString(); 
            int numero = int.Parse(ultimoCodigo.Substring(4));     
            numero++;
            return "CLI-" + numero.ToString("D4");                 
        }


        public DataTable GetCargos()
        {
            string query = "SELECT DISTINCT Cargo FROM Empleados ORDER BY Cargo";
            return ExecuteSelect(query); // tu método base que devuelve DataTable
        }
        public DataTable GetClientesActivos()
        {
            string sql = @"
        SELECT Codigo,
               Nombre,
               Telefono,
               Direccion,
               Notas,
               'Activo' AS Estado
        FROM Clientes
        WHERE Activo = 1";

            return ExecuteSelect(sql);
        }










    }
}
