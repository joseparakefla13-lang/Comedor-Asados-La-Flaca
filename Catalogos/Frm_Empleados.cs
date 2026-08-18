using Comedor_Asados_La_Flaca.Services;
using InisioSesion_Asado.FROMS;
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
        public void CargarEmpleados()
        {
            datagrewEmpleados.AutoGenerateColumns = false;
            datagrewEmpleados.DataSource = selectQuery.GetAllEmpleados();

            datagrewEmpleados.Columns["Codigo"].DataPropertyName = "Codigo";
            datagrewEmpleados.Columns["Nombre"].DataPropertyName = "Nombre";
            datagrewEmpleados.Columns["Telefono"].DataPropertyName = "Telefono";
            datagrewEmpleados.Columns["Cargo"].DataPropertyName = "Cargo";
            datagrewEmpleados.Columns["Salario"].DataPropertyName = "Salario";
            datagrewEmpleados.Columns["FechaIngreso"].DataPropertyName = "FechaIngreso";
            datagrewEmpleados.Columns["Activo"].DataPropertyName = "Activo";
        }


        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            Nuevo_Empleado frmAgregar = new Nuevo_Empleado();
            frmAgregar.ShowDialog();
            CargarEmpleados();
        }

        private void Frm_Empleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void txtBuscarEmpleados_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBuscarEmpleados.Text))
            {
                datagrewEmpleados.DataSource = selectQuery.BuscarPorCodigo(txtBuscarEmpleados.Text.Trim());
            }
        }
    }
}
