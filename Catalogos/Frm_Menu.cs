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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Frm_Empleados frmEmpleados = new Frm_Empleados();
            frmEmpleados.Show();
        }
    }
}
