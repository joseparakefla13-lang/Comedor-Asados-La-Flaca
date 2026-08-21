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
    public partial class Frm_Agregar_Empleado : Form
    {
        private readonly InsertCommand _insertService;

        public Frm_Agregar_Empleado()
        {
            InitializeComponent();
            _insertService = new InsertCommand();
        }

        private void btnCancelarEmple_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
   
            try
            {
                string query = @"INSERT INTO Empleados
            (Codigo, Nombre, Cedula, Telefono, Cargo, Salario, FechaIngreso, Activo)
            VALUES (@codigo, @nombre, @cedula, @telefono, @cargo, @salario, @fechaIngreso, @activo)";

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@codigo", txtCodigoEmple.Text),
            new SqlParameter("@nombre", txtNombreClient.Text),
            new SqlParameter("@cedula", string.IsNullOrEmpty(txtCedulaEmple.Text) ? (object)DBNull.Value : txtCedulaEmple.Text),
            new SqlParameter("@telefono", string.IsNullOrEmpty(txtTelefono.Text) ? (object)DBNull.Value : txtTelefono.Text),
            new SqlParameter("@cargo", string.IsNullOrEmpty(CbCargo.Text) ? (object)DBNull.Value : CbCargo.Text),
            new SqlParameter("@salario", Convert.ToDecimal(txtSalario.Text)),
            new SqlParameter("@fechaIngreso", DtpFechaIngreso.Value.Date),
            new SqlParameter("@activo", ChActivo.Checked)
                };

                InsertCommand insertService = new InsertCommand();
                int rows = insertService.ExecuteInsert(query, parameters);

                if (rows > 0)
                {
                    MessageBox.Show("Empleado guardado exitosamente.");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se insertó ningún registro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar empleado: {ex.Message}");
            }
        }

        private void Frm_Agregar_Empleado_Load(object sender, EventArgs e)
        {
            SelectQuery selectService = new SelectQuery();
            txtCodigoEmple.Text = selectService.GetNextCodigoEmpleado();
            // Llenar el ComboBox
            CargarCargos();
        }

        private void CargarCargos()
        {
            SelectQuery selectService = new SelectQuery();
            DataTable dt = selectService.GetCargos();

            CbCargo.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                CbCargo.Items.Add(row["Cargo"].ToString());
            }

            // Permitir escribir un nuevo cargo
            CbCargo.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void txtNombreClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si la tecla presionada es Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // evita el sonido de "ding"
                txtCedulaEmple.Focus(); // mueve el foco al siguiente TextBox
            }
        }
    }

}
