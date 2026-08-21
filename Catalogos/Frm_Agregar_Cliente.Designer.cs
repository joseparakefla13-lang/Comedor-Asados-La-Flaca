namespace Comedor_Asados_La_Flaca.Catalogos
{
    partial class Frm_Agregar_Cliente
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
            btnCancelarClient = new Button();
            btnguardarClient = new Button();
            txtNotaClient = new TextBox();
            txtDireccionClient = new TextBox();
            txtTelefonoClient = new TextBox();
            txtNombreClient = new TextBox();
            txtCodigoClient = new TextBox();
            lblNota = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            lblCodigo = new Label();
            lblNombreCliente = new Label();
            label1 = new Label();
            ChActivo = new CheckBox();
            SuspendLayout();
            // 
            // btnCancelarClient
            // 
            btnCancelarClient.BackColor = Color.FromArgb(153, 40, 35);
            btnCancelarClient.FlatStyle = FlatStyle.Popup;
            btnCancelarClient.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarClient.ForeColor = Color.FromArgb(250, 247, 241);
            btnCancelarClient.Location = new Point(476, 726);
            btnCancelarClient.Margin = new Padding(4, 5, 4, 5);
            btnCancelarClient.Name = "btnCancelarClient";
            btnCancelarClient.Size = new Size(183, 75);
            btnCancelarClient.TabIndex = 23;
            btnCancelarClient.Text = "Cancelar";
            btnCancelarClient.UseVisualStyleBackColor = false;
            btnCancelarClient.Click += btnCancelarClient_Click;
            // 
            // btnguardarClient
            // 
            btnguardarClient.BackColor = Color.FromArgb(153, 40, 35);
            btnguardarClient.FlatStyle = FlatStyle.Popup;
            btnguardarClient.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnguardarClient.ForeColor = Color.FromArgb(250, 247, 241);
            btnguardarClient.Location = new Point(191, 726);
            btnguardarClient.Margin = new Padding(4, 5, 4, 5);
            btnguardarClient.Name = "btnguardarClient";
            btnguardarClient.Size = new Size(183, 75);
            btnguardarClient.TabIndex = 22;
            btnguardarClient.Text = "Guardar";
            btnguardarClient.UseVisualStyleBackColor = false;
            btnguardarClient.Click += btnguardarClient_Click;
            // 
            // txtNotaClient
            // 
            txtNotaClient.BorderStyle = BorderStyle.FixedSingle;
            txtNotaClient.Cursor = Cursors.Hand;
            txtNotaClient.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNotaClient.Location = new Point(325, 519);
            txtNotaClient.Margin = new Padding(4, 5, 4, 5);
            txtNotaClient.Name = "txtNotaClient";
            txtNotaClient.Size = new Size(354, 43);
            txtNotaClient.TabIndex = 21;
            // 
            // txtDireccionClient
            // 
            txtDireccionClient.BorderStyle = BorderStyle.FixedSingle;
            txtDireccionClient.Cursor = Cursors.Hand;
            txtDireccionClient.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDireccionClient.Location = new Point(325, 431);
            txtDireccionClient.Margin = new Padding(4, 5, 4, 5);
            txtDireccionClient.Name = "txtDireccionClient";
            txtDireccionClient.Size = new Size(354, 43);
            txtDireccionClient.TabIndex = 20;
            // 
            // txtTelefonoClient
            // 
            txtTelefonoClient.BorderStyle = BorderStyle.FixedSingle;
            txtTelefonoClient.Cursor = Cursors.Hand;
            txtTelefonoClient.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefonoClient.Location = new Point(325, 343);
            txtTelefonoClient.Margin = new Padding(4, 5, 4, 5);
            txtTelefonoClient.Name = "txtTelefonoClient";
            txtTelefonoClient.Size = new Size(354, 43);
            txtTelefonoClient.TabIndex = 19;
            // 
            // txtNombreClient
            // 
            txtNombreClient.BorderStyle = BorderStyle.FixedSingle;
            txtNombreClient.Cursor = Cursors.Hand;
            txtNombreClient.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreClient.Location = new Point(325, 247);
            txtNombreClient.Margin = new Padding(4, 5, 4, 5);
            txtNombreClient.Name = "txtNombreClient";
            txtNombreClient.Size = new Size(354, 43);
            txtNombreClient.TabIndex = 18;
            txtNombreClient.KeyPress += txtNombreClient_KeyPress;
            // 
            // txtCodigoClient
            // 
            txtCodigoClient.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoClient.Cursor = Cursors.Hand;
            txtCodigoClient.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCodigoClient.Location = new Point(325, 154);
            txtCodigoClient.Margin = new Padding(4, 5, 4, 5);
            txtCodigoClient.Name = "txtCodigoClient";
            txtCodigoClient.Size = new Size(354, 43);
            txtCodigoClient.TabIndex = 17;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.FlatStyle = FlatStyle.Flat;
            lblNota.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNota.ForeColor = Color.FromArgb(38, 38, 38);
            lblNota.Location = new Point(133, 522);
            lblNota.Margin = new Padding(4, 0, 4, 0);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(88, 37);
            lblNota.TabIndex = 16;
            lblNota.Text = "Nota:";
            lblNota.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.FlatStyle = FlatStyle.Flat;
            lblDireccion.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireccion.ForeColor = Color.FromArgb(38, 38, 38);
            lblDireccion.Location = new Point(133, 437);
            lblDireccion.Margin = new Padding(4, 0, 4, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(145, 37);
            lblDireccion.TabIndex = 15;
            lblDireccion.Text = "Direccion:";
            lblDireccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.FlatStyle = FlatStyle.Flat;
            lblTelefono.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.ForeColor = Color.FromArgb(38, 38, 38);
            lblTelefono.Location = new Point(133, 346);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(136, 37);
            lblTelefono.TabIndex = 14;
            lblTelefono.Text = "Telefono:";
            lblTelefono.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.FlatStyle = FlatStyle.Flat;
            lblCodigo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.ForeColor = Color.FromArgb(38, 38, 38);
            lblCodigo.Location = new Point(133, 157);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(117, 37);
            lblCodigo.TabIndex = 13;
            lblCodigo.Text = "Codigo:";
            lblCodigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.FlatStyle = FlatStyle.Flat;
            lblNombreCliente.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreCliente.ForeColor = Color.FromArgb(38, 38, 38);
            lblNombreCliente.Location = new Point(133, 250);
            lblNombreCliente.Margin = new Padding(4, 0, 4, 0);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(130, 37);
            lblNombreCliente.TabIndex = 12;
            lblNombreCliente.Text = "Nombre:";
            lblNombreCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(38, 38, 38);
            label1.Location = new Point(163, 621);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 37);
            label1.TabIndex = 24;
            label1.Text = "Activo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChActivo
            // 
            ChActivo.AutoSize = true;
            ChActivo.Location = new Point(462, 629);
            ChActivo.Name = "ChActivo";
            ChActivo.Size = new Size(28, 27);
            ChActivo.TabIndex = 25;
            ChActivo.UseVisualStyleBackColor = true;
            // 
            // Frm_Agregar_Cliente
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 221, 206);
            ClientSize = new Size(813, 907);
            Controls.Add(ChActivo);
            Controls.Add(label1);
            Controls.Add(btnCancelarClient);
            Controls.Add(btnguardarClient);
            Controls.Add(txtNotaClient);
            Controls.Add(txtDireccionClient);
            Controls.Add(txtTelefonoClient);
            Controls.Add(txtNombreClient);
            Controls.Add(txtCodigoClient);
            Controls.Add(lblNota);
            Controls.Add(lblDireccion);
            Controls.Add(lblTelefono);
            Controls.Add(lblCodigo);
            Controls.Add(lblNombreCliente);
            Name = "Frm_Agregar_Cliente";
            Text = "Frm_Agregar_Cliente";
            Load += Frm_Agregar_Cliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelarClient;
        private Button btnguardarClient;
        private TextBox txtNotaClient;
        private TextBox txtDireccionClient;
        private TextBox txtTelefonoClient;
        private TextBox txtNombreClient;
        private TextBox txtCodigoClient;
        private Label lblNota;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblCodigo;
        private Label lblNombreCliente;
        private Label label1;
        private CheckBox ChActivo;
    }
}