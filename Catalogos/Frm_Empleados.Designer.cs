namespace Comedor_Asados_La_Flaca.Catalogos
{
    partial class Frm_Empleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEliminarEmpleado = new Button();
            btnEditarEmpleado = new Button();
            datagrewEmpleados = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Salario = new DataGridViewTextBoxColumn();
            FechaIngreso = new DataGridViewTextBoxColumn();
            Activo = new DataGridViewTextBoxColumn();
            btnNuevoEmpleado = new Button();
            txtBuscarEmpleados = new TextBox();
            lblBuscarEmpleados = new Label();
            lblEmpleados = new Label();
            ((System.ComponentModel.ISupportInitialize)datagrewEmpleados).BeginInit();
            SuspendLayout();
            // 
            // btnEliminarEmpleado
            // 
            btnEliminarEmpleado.BackColor = Color.FromArgb(153, 40, 35);
            btnEliminarEmpleado.FlatStyle = FlatStyle.Popup;
            btnEliminarEmpleado.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarEmpleado.ForeColor = Color.FromArgb(250, 247, 241);
            btnEliminarEmpleado.Location = new Point(644, 785);
            btnEliminarEmpleado.Margin = new Padding(4, 6, 4, 6);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(218, 80);
            btnEliminarEmpleado.TabIndex = 31;
            btnEliminarEmpleado.Text = "Eliminar";
            btnEliminarEmpleado.UseVisualStyleBackColor = false;
            // 
            // btnEditarEmpleado
            // 
            btnEditarEmpleado.BackColor = Color.FromArgb(153, 40, 35);
            btnEditarEmpleado.FlatStyle = FlatStyle.Popup;
            btnEditarEmpleado.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarEmpleado.ForeColor = Color.FromArgb(250, 247, 241);
            btnEditarEmpleado.Location = new Point(390, 785);
            btnEditarEmpleado.Margin = new Padding(4, 6, 4, 6);
            btnEditarEmpleado.Name = "btnEditarEmpleado";
            btnEditarEmpleado.Size = new Size(218, 80);
            btnEditarEmpleado.TabIndex = 30;
            btnEditarEmpleado.Text = "Editar";
            btnEditarEmpleado.UseVisualStyleBackColor = false;
            // 
            // datagrewEmpleados
            // 
            datagrewEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrewEmpleados.BackgroundColor = Color.FromArgb(245, 237, 225);
            datagrewEmpleados.BorderStyle = BorderStyle.None;
            datagrewEmpleados.CellBorderStyle = DataGridViewCellBorderStyle.None;
            datagrewEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrewEmpleados.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Telefono, Cargo, Salario, FechaIngreso, Activo });
            datagrewEmpleados.Location = new Point(119, 137);
            datagrewEmpleados.Margin = new Padding(4, 6, 4, 6);
            datagrewEmpleados.Name = "datagrewEmpleados";
            datagrewEmpleados.RowHeadersWidth = 62;
            datagrewEmpleados.RowTemplate.Height = 28;
            datagrewEmpleados.Size = new Size(1457, 608);
            datagrewEmpleados.TabIndex = 29;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 8;
            Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 8;
            Telefono.Name = "Telefono";
            // 
            // Cargo
            // 
            Cargo.HeaderText = "Cargo";
            Cargo.MinimumWidth = 8;
            Cargo.Name = "Cargo";
            // 
            // Salario
            // 
            Salario.HeaderText = "Salario";
            Salario.MinimumWidth = 8;
            Salario.Name = "Salario";
            // 
            // FechaIngreso
            // 
            FechaIngreso.HeaderText = "Ingreso";
            FechaIngreso.MinimumWidth = 8;
            FechaIngreso.Name = "FechaIngreso";
            // 
            // Activo
            // 
            Activo.HeaderText = "Estado";
            Activo.MinimumWidth = 8;
            Activo.Name = "Activo";
            // 
            // btnNuevoEmpleado
            // 
            btnNuevoEmpleado.BackColor = Color.FromArgb(153, 40, 35);
            btnNuevoEmpleado.FlatStyle = FlatStyle.Popup;
            btnNuevoEmpleado.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoEmpleado.ForeColor = Color.FromArgb(250, 247, 241);
            btnNuevoEmpleado.Location = new Point(119, 785);
            btnNuevoEmpleado.Margin = new Padding(4, 6, 4, 6);
            btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            btnNuevoEmpleado.Size = new Size(218, 80);
            btnNuevoEmpleado.TabIndex = 28;
            btnNuevoEmpleado.Text = "Nuevo Empleado";
            btnNuevoEmpleado.UseVisualStyleBackColor = false;
            btnNuevoEmpleado.Click += btnNuevoEmpleado_Click;
            // 
            // txtBuscarEmpleados
            // 
            txtBuscarEmpleados.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarEmpleados.Cursor = Cursors.Hand;
            txtBuscarEmpleados.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscarEmpleados.Location = new Point(1273, 51);
            txtBuscarEmpleados.Margin = new Padding(4, 6, 4, 6);
            txtBuscarEmpleados.Name = "txtBuscarEmpleados";
            txtBuscarEmpleados.Size = new Size(302, 43);
            txtBuscarEmpleados.TabIndex = 27;
            txtBuscarEmpleados.TextChanged += txtBuscarEmpleados_TextChanged;
            // 
            // lblBuscarEmpleados
            // 
            lblBuscarEmpleados.AutoSize = true;
            lblBuscarEmpleados.FlatStyle = FlatStyle.Flat;
            lblBuscarEmpleados.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscarEmpleados.ForeColor = Color.FromArgb(38, 38, 38);
            lblBuscarEmpleados.Location = new Point(1130, 54);
            lblBuscarEmpleados.Margin = new Padding(4, 0, 4, 0);
            lblBuscarEmpleados.Name = "lblBuscarEmpleados";
            lblBuscarEmpleados.Size = new Size(109, 37);
            lblBuscarEmpleados.TabIndex = 26;
            lblBuscarEmpleados.Text = "Buscar:";
            lblBuscarEmpleados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmpleados
            // 
            lblEmpleados.AutoSize = true;
            lblEmpleados.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpleados.ForeColor = Color.FromArgb(153, 40, 35);
            lblEmpleados.Location = new Point(85, 25);
            lblEmpleados.Margin = new Padding(4, 0, 4, 0);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(183, 45);
            lblEmpleados.TabIndex = 25;
            lblEmpleados.Text = "Empleados";
            // 
            // Frm_Empleados
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 221, 206);
            ClientSize = new Size(1660, 891);
            Controls.Add(btnEliminarEmpleado);
            Controls.Add(btnEditarEmpleado);
            Controls.Add(datagrewEmpleados);
            Controls.Add(btnNuevoEmpleado);
            Controls.Add(txtBuscarEmpleados);
            Controls.Add(lblBuscarEmpleados);
            Controls.Add(lblEmpleados);
            Name = "Frm_Empleados";
            Text = "Form1";
            Load += Frm_Empleados_Load;
            ((System.ComponentModel.ISupportInitialize)datagrewEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminarEmpleado;
        private Button btnEditarEmpleado;
        private DataGridView datagrewEmpleados;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Salario;
        private DataGridViewTextBoxColumn FechaIngreso;
        private DataGridViewTextBoxColumn Activo;
        private Button btnNuevoEmpleado;
        private TextBox txtBuscarEmpleados;
        private Label lblBuscarEmpleados;
        private Label lblEmpleados;
    }
}