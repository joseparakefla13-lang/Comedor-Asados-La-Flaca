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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT u.RolSistema, e.Nombre, e.Cargo
               FROM Usuarios u
               INNER JOIN Empleados e ON u.CodigoEmpleado = e.Codigo
               WHERE u.NombreUsuario = @usuario 
                 AND u.Contraseña = @password 
                 AND u.Activo = 1";

            var parametros = new[]
            {
               new SqlParameter("@usuario", txtusuario.Text.Trim()),
               new SqlParameter("@password", txtcontraseña.Text.Trim())
            };

            SelectQuery selectQuery = new SelectQuery();
            DataTable dt = selectQuery.ExecuteSelect(sql, parametros);

            if (dt.Rows.Count > 0)
            {
                string rolSistema = dt.Rows[0]["RolSistema"].ToString();
                string nombreEmpleado = dt.Rows[0]["Nombre"].ToString();
                string cargoLaboral = dt.Rows[0]["Cargo"].ToString();

                MessageBox.Show($"Bienvenido {rolSistema} {nombreEmpleado} ({cargoLaboral})");

                Frm_Menu frmMenu = new Frm_Menu();
                frmMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }


        }


    }
}

