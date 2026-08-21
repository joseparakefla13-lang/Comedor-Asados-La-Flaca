namespace Comedor_Asados_La_Flaca.Catalogos
{
    partial class Frm_Clientes
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
            btnEliminarClientes = new Button();
            btnEditarClientes = new Button();
            datagrewClientes = new DataGridView();
            btnNuevoCliente = new Button();
            txtBuscarClientes = new TextBox();
            lblBuscarFacturasEmitidas = new Label();
            label1 = new Label();
            CODIGOClient = new DataGridViewTextBoxColumn();
            NOMBREClient = new DataGridViewTextBoxColumn();
            TELEFONOClient = new DataGridViewTextBoxColumn();
            DIRECCIONClient = new DataGridViewTextBoxColumn();
            NOTASClient = new DataGridViewTextBoxColumn();
            Activo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)datagrewClientes).BeginInit();
            SuspendLayout();
            // 
            // btnEliminarClientes
            // 
            btnEliminarClientes.BackColor = Color.FromArgb(153, 40, 35);
            btnEliminarClientes.FlatStyle = FlatStyle.Popup;
            btnEliminarClientes.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarClientes.ForeColor = Color.FromArgb(250, 247, 241);
            btnEliminarClientes.Location = new Point(661, 840);
            btnEliminarClientes.Margin = new Padding(4, 6, 4, 6);
            btnEliminarClientes.Name = "btnEliminarClientes";
            btnEliminarClientes.Size = new Size(218, 80);
            btnEliminarClientes.TabIndex = 24;
            btnEliminarClientes.Text = "Eliminar";
            btnEliminarClientes.UseVisualStyleBackColor = false;
            btnEliminarClientes.Click += btnEliminarClientes_Click;
            // 
            // btnEditarClientes
            // 
            btnEditarClientes.BackColor = Color.FromArgb(153, 40, 35);
            btnEditarClientes.FlatStyle = FlatStyle.Popup;
            btnEditarClientes.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarClientes.ForeColor = Color.FromArgb(250, 247, 241);
            btnEditarClientes.Location = new Point(407, 840);
            btnEditarClientes.Margin = new Padding(4, 6, 4, 6);
            btnEditarClientes.Name = "btnEditarClientes";
            btnEditarClientes.Size = new Size(218, 80);
            btnEditarClientes.TabIndex = 23;
            btnEditarClientes.Text = "Editar";
            btnEditarClientes.UseVisualStyleBackColor = false;
            btnEditarClientes.Click += btnEditarClientes_Click;
            // 
            // datagrewClientes
            // 
            datagrewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrewClientes.BackgroundColor = Color.FromArgb(245, 237, 225);
            datagrewClientes.BorderStyle = BorderStyle.None;
            datagrewClientes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            datagrewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrewClientes.Columns.AddRange(new DataGridViewColumn[] { CODIGOClient, NOMBREClient, TELEFONOClient, DIRECCIONClient, NOTASClient, Activo });
            datagrewClientes.Location = new Point(136, 192);
            datagrewClientes.Margin = new Padding(4, 6, 4, 6);
            datagrewClientes.Name = "datagrewClientes";
            datagrewClientes.RowHeadersWidth = 62;
            datagrewClientes.RowTemplate.Height = 28;
            datagrewClientes.Size = new Size(1457, 608);
            datagrewClientes.TabIndex = 22;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = Color.FromArgb(153, 40, 35);
            btnNuevoCliente.FlatStyle = FlatStyle.Popup;
            btnNuevoCliente.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoCliente.ForeColor = Color.FromArgb(250, 247, 241);
            btnNuevoCliente.Location = new Point(136, 840);
            btnNuevoCliente.Margin = new Padding(4, 6, 4, 6);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(218, 80);
            btnNuevoCliente.TabIndex = 21;
            btnNuevoCliente.Text = "Nuevo Cliente";
            btnNuevoCliente.UseVisualStyleBackColor = false;
            btnNuevoCliente.Click += btnNuevoCliente_Click;
            // 
            // txtBuscarClientes
            // 
            txtBuscarClientes.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarClientes.Cursor = Cursors.Hand;
            txtBuscarClientes.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscarClientes.Location = new Point(1290, 106);
            txtBuscarClientes.Margin = new Padding(4, 6, 4, 6);
            txtBuscarClientes.Name = "txtBuscarClientes";
            txtBuscarClientes.Size = new Size(302, 43);
            txtBuscarClientes.TabIndex = 20;
            txtBuscarClientes.TextChanged += txtBuscarClientes_TextChanged;
            // 
            // lblBuscarFacturasEmitidas
            // 
            lblBuscarFacturasEmitidas.AutoSize = true;
            lblBuscarFacturasEmitidas.FlatStyle = FlatStyle.Flat;
            lblBuscarFacturasEmitidas.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscarFacturasEmitidas.ForeColor = Color.FromArgb(38, 38, 38);
            lblBuscarFacturasEmitidas.Location = new Point(1147, 109);
            lblBuscarFacturasEmitidas.Margin = new Padding(4, 0, 4, 0);
            lblBuscarFacturasEmitidas.Name = "lblBuscarFacturasEmitidas";
            lblBuscarFacturasEmitidas.Size = new Size(109, 37);
            lblBuscarFacturasEmitidas.TabIndex = 19;
            lblBuscarFacturasEmitidas.Text = "Buscar:";
            lblBuscarFacturasEmitidas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(153, 40, 35);
            label1.Location = new Point(102, 80);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 45);
            label1.TabIndex = 18;
            label1.Text = "Clientes";
            // 
            // CODIGOClient
            // 
            CODIGOClient.HeaderText = "Codigo";
            CODIGOClient.MinimumWidth = 8;
            CODIGOClient.Name = "CODIGOClient";
            // 
            // NOMBREClient
            // 
            NOMBREClient.HeaderText = "Nombre";
            NOMBREClient.MinimumWidth = 8;
            NOMBREClient.Name = "NOMBREClient";
            // 
            // TELEFONOClient
            // 
            TELEFONOClient.HeaderText = "Telefono";
            TELEFONOClient.MinimumWidth = 8;
            TELEFONOClient.Name = "TELEFONOClient";
            // 
            // DIRECCIONClient
            // 
            DIRECCIONClient.HeaderText = "Direccion";
            DIRECCIONClient.MinimumWidth = 8;
            DIRECCIONClient.Name = "DIRECCIONClient";
            // 
            // NOTASClient
            // 
            NOTASClient.HeaderText = "Notas";
            NOTASClient.MinimumWidth = 8;
            NOTASClient.Name = "NOTASClient";
            // 
            // Activo
            // 
            Activo.HeaderText = "Activo";
            Activo.MinimumWidth = 10;
            Activo.Name = "Activo";
            // 
            // Frm_Clientes
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 221, 206);
            ClientSize = new Size(1695, 1001);
            Controls.Add(btnEliminarClientes);
            Controls.Add(btnEditarClientes);
            Controls.Add(datagrewClientes);
            Controls.Add(btnNuevoCliente);
            Controls.Add(txtBuscarClientes);
            Controls.Add(lblBuscarFacturasEmitidas);
            Controls.Add(label1);
            Name = "Frm_Clientes";
            Text = "Frm_Clientes";
            Load += Frm_Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)datagrewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminarClientes;
        private Button btnEditarClientes;
        private DataGridView datagrewClientes;
        private Button btnNuevoCliente;
        private TextBox txtBuscarClientes;
        private Label lblBuscarFacturasEmitidas;
        private Label label1;
        private DataGridViewTextBoxColumn CODIGOClient;
        private DataGridViewTextBoxColumn NOMBREClient;
        private DataGridViewTextBoxColumn TELEFONOClient;
        private DataGridViewTextBoxColumn DIRECCIONClient;
        private DataGridViewTextBoxColumn NOTASClient;
        private DataGridViewTextBoxColumn Activo;
    }
}