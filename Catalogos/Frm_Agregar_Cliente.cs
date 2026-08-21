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

namespace Comedor_Asados_La_Flaca.Catalogos
{
    public partial class Frm_Agregar_Cliente : Form
    {
        private readonly InsertCommand _insertService;
        public Frm_Agregar_Cliente()
        {

            InitializeComponent();
            _insertService = new InsertCommand();

        }

        private void btnguardarClient_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"INSERT INTO Clientes
        (Codigo, Nombre, Telefono, Direccion, Notas, Activo)
        VALUES (@codigo, @nombre, @telefono, @direccion, @notas, @activo)";

                SqlParameter[] parameters = new SqlParameter[]
                {
        new SqlParameter("@codigo", txtCodigoClient.Text),
        new SqlParameter("@nombre", txtNombreClient.Text),
        new SqlParameter("@telefono", string.IsNullOrEmpty(txtTelefonoClient.Text) ? (object)DBNull.Value : txtTelefonoClient.Text),
        new SqlParameter("@direccion", string.IsNullOrEmpty(txtDireccionClient.Text) ? (object)DBNull.Value : txtDireccionClient.Text),
        new SqlParameter("@notas", string.IsNullOrEmpty(txtNotaClient.Text) ? (object)DBNull.Value : txtNotaClient.Text),
        new SqlParameter("@activo", ChActivo.Checked)
                };

                InsertCommand insertService = new InsertCommand();
                int rows = insertService.ExecuteInsert(query, parameters);

                if (rows > 0)
                {
                    MessageBox.Show("Cliente guardado exitosamente.");

                    this.Close();

                   
                }
                else
                {
                    MessageBox.Show("No se insertó ningún registro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar cliente: {ex.Message}");
            }
        }


        private void btnCancelarClient_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Frm_Agregar_Cliente_Load(object sender, EventArgs e)
        {
            SelectQuery selectService = new SelectQuery();
            txtCodigoClient.Text = selectService.GetNextCodigoCliente();

        }

        private void txtNombreClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // evita el sonido de "ding"
                txtTelefonoClient.Focus(); // mueve el foco al siguiente TextBox
            }
        }
    }
}
