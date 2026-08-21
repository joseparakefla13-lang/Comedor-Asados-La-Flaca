using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace Comedor_Asados_La_Flaca.Services
{
        /// <summary>
        /// Subclase para ejecutar operaciones UPDATE.
        /// </summary>
        public class UpdateCommand : DataBaseConnection
        {

            public UpdateCommand() : base() { }
            public UpdateCommand(string connectionString) : base(connectionString) { }

        /// <summary>
        /// Ejecuta un UPDATE y devuelve el número de filas afectadas.
        /// </summary>
        /// <param name="query">Sentencia UPDATE parametrizada.</param>
        /// <param name="parameters">Parámetros SQL.</param>
        /// <returns>Número de filas modificadas.</returns>
        public int ExecuteUpdateEmpleado(SqlParameter[] parameters)
        {
            try
            {
                OpenConnection();

                string query = @"
    UPDATE Empleados
    SET Nombre = @nombre,
        Cedula = @cedula,
        Telefono = @telefono,
        Cargo = @cargo,
        Salario = @salario,
        FechaIngreso = @ingreso
    WHERE Codigo = @codigo
      AND Activo = 1";


                _command = new SqlCommand(query, _connection);
                _command.CommandType = CommandType.Text;

                if (parameters is not null)
                    _command.Parameters.AddRange(parameters);

                int rowsAffected = _command.ExecuteNonQuery();

                if (rowsAffected == 0)
                    throw new Exception("El empleado no se pudo actualizar. " +
                                        "Verifica que esté activo o que el código exista.");

                return rowsAffected;
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error SQL al ejecutar UPDATE: {ex.Message}", ex);
            }
            finally
            {
                CloseConnection();
            }
        }

        /// <summary>
        /// Reactiva un empleado inactivo y actualiza sus datos.
        /// </summary>
        public int ExecuteReactivarEmpleado(SqlParameter[] parameters)
        {
            try
            {
                OpenConnection();

                string query = @"
    UPDATE Empleados
    SET Nombre = @nombre,
        Cedula = @cedula,
        Telefono = @telefono,
        Cargo = @cargo,
        Salario = @salario,
        FechaIngreso = @ingreso,  
        Activo = 1
    WHERE Codigo = @codigo";


                _command = new SqlCommand(query, _connection);
                _command.CommandType = CommandType.Text;

                if (parameters is not null)
                    _command.Parameters.AddRange(parameters);

                int rowsAffected = _command.ExecuteNonQuery();

                if (rowsAffected == 0)
                    throw new Exception("El empleado no se pudo actualizar. Verifica el código.");

                return rowsAffected;
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error SQL al ejecutar UPDATE: {ex.Message}", ex);
            }
            finally
            {
                CloseConnection();
            }
        }

    }
}
