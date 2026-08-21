namespace Comedor_Asados_La_Flaca.Catalogos
{
    partial class Frm_Agregar_Empleado
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
            BtnGuardar = new Button();
            DtpFechaIngreso = new DateTimePicker();
            label1 = new Label();
            ChActivo = new CheckBox();
            CbCargo = new ComboBox();
            txtCedulaEmple = new TextBox();
            lblCedulaEmple = new Label();
            btnCancelarEmple = new Button();
            txtSalario = new TextBox();
            txtTelefono = new TextBox();
            txtNombreClient = new TextBox();
            txtCodigoEmple = new TextBox();
            lblSalario = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            lblCodigoEmpleado = new Label();
            lblNombreEmple = new Label();
            SuspendLayout();
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.FromArgb(153, 40, 35);
            BtnGuardar.ForeColor = Color.FromArgb(250, 247, 241);
            BtnGuardar.Location = new Point(246, 787);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(179, 75);
            BtnGuardar.TabIndex = 63;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // DtpFechaIngreso
            // 
            DtpFechaIngreso.Location = new Point(407, 602);
            DtpFechaIngreso.Name = "DtpFechaIngreso";
            DtpFechaIngreso.Size = new Size(400, 39);
            DtpFechaIngreso.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(38, 38, 38);
            label1.Location = new Point(195, 604);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(207, 37);
            label1.TabIndex = 61;
            label1.Text = "Fecha ingreso :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChActivo
            // 
            ChActivo.AutoSize = true;
            ChActivo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChActivo.ForeColor = Color.FromArgb(38, 38, 38);
            ChActivo.Location = new Point(443, 698);
            ChActivo.Margin = new Padding(4, 5, 4, 5);
            ChActivo.Name = "ChActivo";
            ChActivo.Size = new Size(265, 41);
            ChActivo.TabIndex = 60;
            ChActivo.Text = "Empleado Actico";
            ChActivo.UseVisualStyleBackColor = true;
            // 
            // CbCargo
            // 
            CbCargo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            CbCargo.FormattingEnabled = true;
            CbCargo.Location = new Point(407, 433);
            CbCargo.Margin = new Padding(4, 5, 4, 5);
            CbCargo.Name = "CbCargo";
            CbCargo.Size = new Size(400, 45);
            CbCargo.TabIndex = 59;
            // 
            // txtCedulaEmple
            // 
            txtCedulaEmple.BorderStyle = BorderStyle.FixedSingle;
            txtCedulaEmple.Cursor = Cursors.Hand;
            txtCedulaEmple.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCedulaEmple.Location = new Point(407, 258);
            txtCedulaEmple.Margin = new Padding(4, 5, 4, 5);
            txtCedulaEmple.Name = "txtCedulaEmple";
            txtCedulaEmple.Size = new Size(400, 43);
            txtCedulaEmple.TabIndex = 58;
            // 
            // lblCedulaEmple
            // 
            lblCedulaEmple.AutoSize = true;
            lblCedulaEmple.FlatStyle = FlatStyle.Flat;
            lblCedulaEmple.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCedulaEmple.ForeColor = Color.FromArgb(38, 38, 38);
            lblCedulaEmple.Location = new Point(215, 262);
            lblCedulaEmple.Margin = new Padding(4, 0, 4, 0);
            lblCedulaEmple.Name = "lblCedulaEmple";
            lblCedulaEmple.Size = new Size(112, 37);
            lblCedulaEmple.TabIndex = 57;
            lblCedulaEmple.Text = "Cedula:";
            lblCedulaEmple.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancelarEmple
            // 
            btnCancelarEmple.BackColor = Color.FromArgb(153, 40, 35);
            btnCancelarEmple.FlatStyle = FlatStyle.Popup;
            btnCancelarEmple.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarEmple.ForeColor = Color.FromArgb(250, 247, 241);
            btnCancelarEmple.Location = new Point(568, 787);
            btnCancelarEmple.Margin = new Padding(4, 5, 4, 5);
            btnCancelarEmple.Name = "btnCancelarEmple";
            btnCancelarEmple.Size = new Size(183, 75);
            btnCancelarEmple.TabIndex = 56;
            btnCancelarEmple.Text = "Cancelar";
            btnCancelarEmple.UseVisualStyleBackColor = false;
            btnCancelarEmple.Click += btnCancelarEmple_Click;
            // 
            // txtSalario
            // 
            txtSalario.BorderStyle = BorderStyle.FixedSingle;
            txtSalario.Cursor = Cursors.Hand;
            txtSalario.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSalario.Location = new Point(407, 518);
            txtSalario.Margin = new Padding(4, 5, 4, 5);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(400, 43);
            txtSalario.TabIndex = 55;
            txtSalario.Text = "0";
            // 
            // txtTelefono
            // 
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Cursor = Cursors.Hand;
            txtTelefono.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(407, 343);
            txtTelefono.Margin = new Padding(4, 5, 4, 5);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(400, 43);
            txtTelefono.TabIndex = 54;
            // 
            // txtNombreClient
            // 
            txtNombreClient.BorderStyle = BorderStyle.FixedSingle;
            txtNombreClient.Cursor = Cursors.Hand;
            txtNombreClient.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreClient.Location = new Point(407, 177);
            txtNombreClient.Margin = new Padding(4, 5, 4, 5);
            txtNombreClient.Name = "txtNombreClient";
            txtNombreClient.Size = new Size(400, 43);
            txtNombreClient.TabIndex = 53;
            txtNombreClient.KeyPress += txtNombreClient_KeyPress;
            // 
            // txtCodigoEmple
            // 
            txtCodigoEmple.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoEmple.Cursor = Cursors.Hand;
            txtCodigoEmple.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCodigoEmple.Location = new Point(407, 87);
            txtCodigoEmple.Margin = new Padding(4, 5, 4, 5);
            txtCodigoEmple.Name = "txtCodigoEmple";
            txtCodigoEmple.ReadOnly = true;
            txtCodigoEmple.Size = new Size(400, 43);
            txtCodigoEmple.TabIndex = 52;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.FlatStyle = FlatStyle.Flat;
            lblSalario.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalario.ForeColor = Color.FromArgb(38, 38, 38);
            lblSalario.Location = new Point(215, 524);
            lblSalario.Margin = new Padding(4, 0, 4, 0);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(180, 37);
            lblSalario.TabIndex = 51;
            lblSalario.Text = "Salario (C$) :";
            lblSalario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.FlatStyle = FlatStyle.Flat;
            lblDireccion.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireccion.ForeColor = Color.FromArgb(38, 38, 38);
            lblDireccion.Location = new Point(215, 438);
            lblDireccion.Margin = new Padding(4, 0, 4, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(101, 37);
            lblDireccion.TabIndex = 50;
            lblDireccion.Text = "Cargo:";
            lblDireccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.FlatStyle = FlatStyle.Flat;
            lblTelefono.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.ForeColor = Color.FromArgb(38, 38, 38);
            lblTelefono.Location = new Point(215, 346);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(136, 37);
            lblTelefono.TabIndex = 49;
            lblTelefono.Text = "Telefono:";
            lblTelefono.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCodigoEmpleado
            // 
            lblCodigoEmpleado.AutoSize = true;
            lblCodigoEmpleado.FlatStyle = FlatStyle.Flat;
            lblCodigoEmpleado.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigoEmpleado.ForeColor = Color.FromArgb(38, 38, 38);
            lblCodigoEmpleado.Location = new Point(215, 90);
            lblCodigoEmpleado.Margin = new Padding(4, 0, 4, 0);
            lblCodigoEmpleado.Name = "lblCodigoEmpleado";
            lblCodigoEmpleado.Size = new Size(117, 37);
            lblCodigoEmpleado.TabIndex = 48;
            lblCodigoEmpleado.Text = "Codigo:";
            lblCodigoEmpleado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombreEmple
            // 
            lblNombreEmple.AutoSize = true;
            lblNombreEmple.FlatStyle = FlatStyle.Flat;
            lblNombreEmple.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreEmple.ForeColor = Color.FromArgb(38, 38, 38);
            lblNombreEmple.Location = new Point(215, 180);
            lblNombreEmple.Margin = new Padding(4, 0, 4, 0);
            lblNombreEmple.Name = "lblNombreEmple";
            lblNombreEmple.Size = new Size(130, 37);
            lblNombreEmple.TabIndex = 47;
            lblNombreEmple.Text = "Nombre:";
            lblNombreEmple.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Frm_Agregar_Empleado
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 221, 206);
            ClientSize = new Size(980, 952);
            Controls.Add(BtnGuardar);
            Controls.Add(DtpFechaIngreso);
            Controls.Add(label1);
            Controls.Add(ChActivo);
            Controls.Add(CbCargo);
            Controls.Add(txtCedulaEmple);
            Controls.Add(lblCedulaEmple);
            Controls.Add(btnCancelarEmple);
            Controls.Add(txtSalario);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombreClient);
            Controls.Add(txtCodigoEmple);
            Controls.Add(lblSalario);
            Controls.Add(lblDireccion);
            Controls.Add(lblTelefono);
            Controls.Add(lblCodigoEmpleado);
            Controls.Add(lblNombreEmple);
            Name = "Frm_Agregar_Empleado";
            Text = "Frm_Agregar_Empleado";
            Load += Frm_Agregar_Empleado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGuardar;
        private DateTimePicker DtpFechaIngreso;
        private Label label1;
        private CheckBox ChActivo;
        private ComboBox CbCargo;
        private TextBox txtCedulaEmple;
        private Label lblCedulaEmple;
        private Button btnCancelarEmple;
        private TextBox txtSalario;
        private TextBox txtTelefono;
        private TextBox txtNombreClient;
        private TextBox txtCodigoEmple;
        private Label lblSalario;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblCodigoEmpleado;
        private Label lblNombreEmple;
    }
}