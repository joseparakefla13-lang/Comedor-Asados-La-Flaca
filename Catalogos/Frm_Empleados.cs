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
        private readonly SelectQuery selectQuery = new SelectQuery(); // instancia global

        public Frm_Empleados()
        {
            InitializeComponent();
        }
        private void CargarEmpleados()
        {
            datagrewEmpleados.AutoGenerateColumns = false;
            datagrewEmpleados.DataSource = selectQuery.GetEmpleadosActivos();

            datagrewEmpleados.Columns["Codigo"].DataPropertyName = "Codigo";
            datagrewEmpleados.Columns["Nombre"].DataPropertyName = "Nombre";
            datagrewEmpleados.Columns["Cedula"].DataPropertyName = "Cedula";
            datagrewEmpleados.Columns["Telefono"].DataPropertyName = "Telefono";
            datagrewEmpleados.Columns["Cargo"].DataPropertyName = "Cargo";
            datagrewEmpleados.Columns["Salario"].DataPropertyName = "Salario";
            datagrewEmpleados.Columns["FechaIngreso"].DataPropertyName = "FechaIngreso";
            datagrewEmpleados.Columns["Activo"].DataPropertyName = "Activo";

          
            datagrewEmpleados.Columns["Activo"].ReadOnly = true;

            datagrewEmpleados.ReadOnly = true;
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

                // 👉 bloquear las demás
                datagrewEmpleados.Columns["Codigo"].ReadOnly = true;
                datagrewEmpleados.Columns["Cedula"].ReadOnly = true;
                datagrewEmpleados.Columns["Activo"].ReadOnly = true;
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

 
            if (!empleadoBuscado)
            {
                MessageBox.Show("Debe buscar primero al empleado que desea actualizar.");
                return;
            }

            if (datagrewEmpleados.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila para editar.");
                return;
            }

            DataGridViewRow row = datagrewEmpleados.CurrentRow;
            string codigo = row.Cells["Codigo"].Value.ToString();

            // Estado original desde BD
            bool estadoOriginal = selectQuery.GetEstadoEmpleado(codigo);

            // Si estaba activo, no permitimos que se cambie a inactivo desde Editar
            if (estadoOriginal)
            {
                MessageBox.Show("El estado no se puede cambiar desde Editar, use el botón Eliminar.");
                return;
            }

            // Si estaba inactivo, se reactiva
            string sql = @"UPDATE Empleados
                   SET Nombre = @nombre,
                       Telefono = @telefono,
                       Cargo = @cargo,
                       Salario = @salario,
                       FechaIngreso = @fechaIngreso,
                       Activo = 1
                   WHERE Codigo = @codigo";

            var parametros = new[]
            {
        new SqlParameter("@nombre", row.Cells["Nombre"].Value.ToString()),
        new SqlParameter("@telefono", row.Cells["Telefono"].Value.ToString()),
        new SqlParameter("@cargo", row.Cells["Cargo"].Value.ToString()),
        new SqlParameter("@salario", Convert.ToDecimal(row.Cells["Salario"].Value)),
        new SqlParameter("@fechaIngreso", Convert.ToDateTime(row.Cells["Ingreso"].Value)),
        new SqlParameter("@codigo", codigo)
    };

            int filas = selectQuery.ExecuteNonQuery(sql, parametros);

            if (filas > 0)
            {
                MessageBox.Show("Empleado reactivado y actualizado correctamente.");
                txtBuscarEmpleados.Clear();
                CargarEmpleados();
                empleadoBuscado = false;
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el empleado.");
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

        private void datagrewEmpleados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (datagrewEmpleados.Columns[e.ColumnIndex].Name == "Activo" && e.Value != null)
            {
                bool estado = Convert.ToBoolean(e.Value);
                e.Value = estado ? "Trabajando" : "Despedido";
                e.FormattingApplied = true;
            }
        }

        private void datagrewEmpleados_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}




