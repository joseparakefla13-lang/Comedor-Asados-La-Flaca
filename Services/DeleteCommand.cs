using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Comedor_Asados_La_Flaca.Services
{
    /// <summary>
    /// Subclase para ejecutar operaciones DELETE.
    /// </summary>
    public class DeleteCommand : DataBaseConnection
    {
        public DeleteCommand() : base() { }
        public DeleteCommand(string connectionString) : base(connectionString) { }

        /// <summary>
        /// Ejecuta un DELETE y devuelve el número de filas eliminadas.
        /// </summary>
        /// <param name="query">Sentencia DELETE parametrizada.</param>
        /// <param name="parameters">Parámetros SQL.</param>
        /// <returns>Número de filas eliminadas.</returns>
        public int ExecuteDelete(string query, SqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();
                using SqlCommand cmd = new SqlCommand(query, _connection);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al ejecutar Delete: {ex.Message}", ex);
            }
            finally
            {
                CloseConnection();
            }


        }
    }
}
