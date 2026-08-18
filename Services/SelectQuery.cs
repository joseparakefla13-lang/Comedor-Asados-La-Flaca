using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;


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
        public DataTable GetAllEmpleados()
        {
            string query = "SELECT Codigo, Nombre, Telefono, Cargo, Salario, FechaIngreso, Activo FROM Empleados";
            return ExecuteSelect(query);
        }

        public DataTable BuscarPorCodigo(string codigo)
        {
            string query = @"SELECT Codigo, Nombre, Telefono, Cargo, Salario, FechaIngreso, Activo 
                     FROM Empleados WHERE Codigo LIKE @Codigo";

            var parametros = new[]
            {
        new SqlParameter("@Codigo", codigo + "%")
    };

            return ExecuteSelect(query, parametros);
        }


    }
}
