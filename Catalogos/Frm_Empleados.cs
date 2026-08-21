using Comedor_Asados_La_Flaca.Services;
using InisioSesion_Asado.FROMS;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comedor_Asados_La_Flaca.Catalogos
{
    public partial class Frm_Empleados : Form
    {
        private readonly SelectQuery selectQuery = new SelectQuery(); 

        public Frm_Empleados()
        {
            InitializeComponent();
        }
        private SqlParameter[] GetEmpleadoParametros(DataGridViewRow row)
        {
            return new[]
            {
        new SqlParameter("@nombre", row.Cells["Nombre"].Value?.ToString() ?? (object)DBNull.Value),
        new SqlParameter("@cedula", row.Cells["Cedula"].Value?.ToString() ?? (object)DBNull.Value),
        new SqlParameter("@telefono", row.Cells["Telefono"].Value?.ToString() ?? (object)DBNull.Value),
        new SqlParameter("@cargo", row.Cells["Cargo"].Value?.ToString() ?? (object)DBNull.Value),
        new SqlParameter("@salario", Convert.ToDecimal(row.Cells["Salario"].Value ?? 0)),
        new SqlParameter("@ingreso", Convert.ToDateTime(row.Cells["FechaIngreso"].Value ?? DateTime.Now)), // 👉 corregido
        new SqlParameter("@codigo", row.Cells["Codigo"].Value?.ToString() ?? (object)DBNull.Value)
    };
        }


        private void CargarEmpleados(string codigo = "")
        {
            DataTable resultado;

            if (string.IsNullOrEmpty(codigo))
            {
                // 👉 Pantalla principal: solo activos
                resultado = selectQuery.GetEmpleadosActivos();
                empleadoBuscado = false;
            }
            else
            {
                // 👉 Búsqueda: activos e inactivos
                resultado = selectQuery.BuscarPorCodigo(codigo);
                empleadoBuscado = resultado.Rows.Count > 0;
            }

            datagrewEmpleados.AutoGenerateColumns = false;
            datagrewEmpleados.DataSource = resultado;

            // Configuración de columnas
            datagrewEmpleados.Columns.Clear();
            datagrewEmpleados.Columns.Add("Codigo", "Código");
            datagrewEmpleados.Columns.Add("Nombre", "Nombre");
            datagrewEmpleados.Columns.Add("Cedula", "Cédula");
            datagrewEmpleados.Columns.Add("Telefono", "Teléfono");
            datagrewEmpleados.Columns.Add("Cargo", "Cargo");
            datagrewEmpleados.Columns.Add("Salario", "Salario");
            datagrewEmpleados.Columns.Add("FechaIngreso", "Ingreso");
            datagrewEmpleados.Columns.Add("Estado", "Estado");

            datagrewEmpleados.Columns["Codigo"].DataPropertyName = "Codigo";
            datagrewEmpleados.Columns["Nombre"].DataPropertyName = "Nombre";
            datagrewEmpleados.Columns["Cedula"].DataPropertyName = "Cedula";
            datagrewEmpleados.Columns["Telefono"].DataPropertyName = "Telefono";
            datagrewEmpleados.Columns["Cargo"].DataPropertyName = "Cargo";
            datagrewEmpleados.Columns["Salario"].DataPropertyName = "Salario";
            datagrewEmpleados.Columns["FechaIngreso"].DataPropertyName = "FechaIngreso";
            datagrewEmpleados.Columns["Estado"].DataPropertyName = "Estado";

            // Permitir edición solo en algunas columnas
            datagrewEmpleados.ReadOnly = false;
            datagrewEmpleados.Columns["Nombre"].ReadOnly = false;
            datagrewEmpleados.Columns["Telefono"].ReadOnly = false;
            datagrewEmpleados.Columns["Cargo"].ReadOnly = false;
            datagrewEmpleados.Columns["Salario"].ReadOnly = false;

            // Bloquear las demás
            datagrewEmpleados.Columns["Codigo"].ReadOnly = true;
            datagrewEmpleados.Columns["Cedula"].ReadOnly = true;
            datagrewEmpleados.Columns["Estado"].ReadOnly = true;
            datagrewEmpleados.Columns["FechaIngreso"].ReadOnly = true;

            datagrewEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrewEmpleados.MultiSelect = false;
        }



        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            Frm_Agregar_Empleado frmAgregar = new Frm_Agregar_Empleado();
            frmAgregar.ShowDialog();
            CargarEmpleados();
        }

        private void Frm_Empleados_Load(object sender, EventArgs e)
        {
            datagrewEmpleados.ReadOnly = true;
            datagrewEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrewEmpleados.MultiSelect = false;

            CargarEmpleados();
        }

        private bool empleadoBuscado = false;

        private void txtBuscarEmpleados_TextChanged(object sender, EventArgs e)
        {
            string codigo = txtBuscarEmpleados.Text.Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                CargarEmpleados();
                empleadoBuscado = false;
                return;
            }

            var resultado = selectQuery.BuscarPorCodigo(codigo);

            if (resultado.Rows.Count > 0)
            {
                datagrewEmpleados.DataSource = resultado;
                empleadoBuscado = true;

                datagrewEmpleados.ReadOnly = false;
                datagrewEmpleados.Columns["Nombre"].ReadOnly = false;
                datagrewEmpleados.Columns["Telefono"].ReadOnly = false;
                datagrewEmpleados.Columns["Cargo"].ReadOnly = false;
                datagrewEmpleados.Columns["Salario"].ReadOnly = false;


                datagrewEmpleados.Columns["Codigo"].ReadOnly = true;
                datagrewEmpleados.Columns["Cedula"].ReadOnly = true;
                datagrewEmpleados.Columns["Estado"].ReadOnly = true;
                datagrewEmpleados.Columns["FechaIngreso"].ReadOnly = true;
            }
            else
            {
                CargarEmpleados();
                empleadoBuscado = false;
            }
        }


        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {

            if (!empleadoBuscado || datagrewEmpleados.CurrentRow == null)
            {
                MessageBox.Show("Debe buscar y seleccionar un empleado primero.");
                return;
            }

            try
            {
                var row = datagrewEmpleados.CurrentRow;
                string estado = row.Cells["Estado"].Value?.ToString();

                var parametros = GetEmpleadoParametros(row);
                UpdateCommand update = new UpdateCommand();
                int filas;

                if (estado == "Trabajando")
                {
                    filas = update.ExecuteUpdateEmpleado(parametros);
                    MessageBox.Show("Empleado actualizado correctamente.");
                }
                else if (estado == "Despedido")
                {
                    filas = update.ExecuteReactivarEmpleado(parametros);
                    MessageBox.Show("Empleado reactivado y actualizado correctamente.");
                }
                else
                {
                    MessageBox.Show("Estado desconocido, no se puede editar.");
                    return;
                }

                txtBuscarEmpleados.Clear();
                CargarEmpleados();
                empleadoBuscado = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (!empleadoBuscado)
            {
                MessageBox.Show("Debe buscar primero al empleado que desea dar de baja.");
                return;
            }

            if (datagrewEmpleados.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un empleado para dar de baja.");
                return;
            }

            DataGridViewRow row = datagrewEmpleados.CurrentRow;
            string codigo = row.Cells["Codigo"].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"¿Seguro que desea dar de baja al empleado {codigo}?",
                "Confirmar baja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DeleteCommand deleteService = new DeleteCommand();

                // baja lógica: Activo = 0
                string sql = "UPDATE Empleados SET Activo = 0 WHERE Codigo = @codigo";
                SqlParameter[] parametros = { new SqlParameter("@codigo", codigo) };

                int filas = deleteService.ExecuteDelete(sql, parametros);

                if (filas > 0)
                {
                    MessageBox.Show("Empleado dado de baja correctamente.");

                    // limpiar búsqueda y refrescar activos
                    txtBuscarEmpleados.Clear();
                    CargarEmpleados();
                    empleadoBuscado = false;
                }
                else
                {
                    MessageBox.Show("No se pudo dar de baja al empleado.");
                }
            }
        }

     

        private void datagrewEmpleados_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void datagrewEmpleados_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
 
            string colName = datagrewEmpleados.Columns[e.ColumnIndex].Name;

            if (colName == "Codigo")
            {
                MessageBox.Show("El código no se puede editar, es generado automáticamente.");
                e.Cancel = true;
            }
            else if (colName == "Estado")
            {
                MessageBox.Show("El estado no se puede editar desde aquí. Use el botón Eliminar para dar de baja o Reactivar para volver a activo.");
                e.Cancel = true; 
            }
        }


    }

}






