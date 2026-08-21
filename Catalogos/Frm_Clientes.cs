using Comedor_Asados_La_Flaca.Services;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Comedor_Asados_La_Flaca.Catalogos
{
    public partial class Frm_Clientes : Form
    {
        private readonly SelectQuery selectQuery = new SelectQuery();

        public Frm_Clientes()
        {
            InitializeComponent();
        }
        private void CargarClientes()
        {
            datagrewClientes.AutoGenerateColumns = false;
            datagrewClientes.DataSource = selectQuery.GetClientesActivos();

            datagrewClientes.Columns.Clear();

            datagrewClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Codigo", HeaderText = "Código", DataPropertyName = "Codigo" });
            datagrewClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", HeaderText = "Nombre", DataPropertyName = "Nombre" });
            datagrewClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Telefono", HeaderText = "Teléfono", DataPropertyName = "Telefono" });
            datagrewClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Direccion", HeaderText = "Dirección", DataPropertyName = "Direccion" });
            datagrewClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Notas", HeaderText = "Notas", DataPropertyName = "Notas" });
            datagrewClientes.Columns.Add(new DataGridViewCheckBoxColumn { Name = "Activo", HeaderText = "Activo", DataPropertyName = "Activo", ReadOnly = true });


            datagrewClientes.Columns["Activo"].ReadOnly = true;

            datagrewClientes.ReadOnly = true;
            datagrewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrewClientes.MultiSelect = false;
        }


        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            Frm_Agregar_Cliente frmAgregar = new Frm_Agregar_Cliente();
            frmAgregar.ShowDialog();
            CargarClientes();
        }

        private void btnEditarClientes_Click(object sender, EventArgs e)
        {

            if (!clienteBuscado)
            {
                MessageBox.Show("Debe buscar primero al cliente que desea actualizar.");
                return;
            }

            if (datagrewClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila para editar.");
                return;
            }

            DataGridViewRow row = datagrewClientes.CurrentRow;
            string codigo = row.Cells["Codigo"].Value.ToString();

            // Estado original desde BD
            bool estadoOriginal = selectQuery.GetEstadoCliente(codigo);

            // Si estaba activo, no permitimos que se cambie a inactivo desde Editar
            if (estadoOriginal)
            {
                MessageBox.Show("El estado no se puede cambiar desde Editar, use el botón Eliminar.");
                return;
            }

            // Si estaba inactivo, se reactiva
            string sql = @"UPDATE Clientes
                   SET Nombre = @nombre,
                       Telefono = @telefono,
                       Direccion = @direccion,
                       Notas = @notas,
                       Activo = 1
                   WHERE Codigo = @codigo";

            var parametros = new[]
            {
        new SqlParameter("@nombre", row.Cells["Nombre"].Value.ToString()),
        new SqlParameter("@telefono", row.Cells["Telefono"].Value?.ToString() ?? (object)DBNull.Value),
        new SqlParameter("@direccion", row.Cells["Direccion"].Value?.ToString() ?? (object)DBNull.Value),
        new SqlParameter("@notas", row.Cells["Notas"].Value?.ToString() ?? (object)DBNull.Value),
        new SqlParameter("@codigo", codigo)
    };

            int filas = selectQuery.ExecuteNonQuery(sql, parametros);

            if (filas > 0)
            {
                MessageBox.Show("Cliente reactivado y actualizado correctamente.");
                txtBuscarClientes.Clear();
                CargarClientes();
                clienteBuscado = false;
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el cliente.");
            }
        }

        private void btnEliminarClientes_Click(object sender, EventArgs e)
        {

        }
        private bool clienteBuscado = false;

        private void txtBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            string codigo = txtBuscarClientes.Text.Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                CargarClientes();
                clienteBuscado = false;
                return;
            }

            var resultado = selectQuery.BuscarClientePorCodigo(codigo);

            if (resultado.Rows.Count > 0)
            {
                datagrewClientes.DataSource = resultado;
                clienteBuscado = true;

                datagrewClientes.ReadOnly = false;
                datagrewClientes.Columns["Nombre"].ReadOnly = false;
                datagrewClientes.Columns["Telefono"].ReadOnly = false;
                datagrewClientes.Columns["Direccion"].ReadOnly = false;
                datagrewClientes.Columns["Notas"].ReadOnly = false;

                datagrewClientes.Columns["Codigo"].ReadOnly = true;
                datagrewClientes.Columns["Activo"].ReadOnly = true;
            }
            else
            {
                CargarClientes();
                clienteBuscado = false;
            }
        }


        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
            datagrewClientes.ReadOnly = true;
            datagrewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrewClientes.MultiSelect = false;

            CargarClientes();
        }
    }
}
