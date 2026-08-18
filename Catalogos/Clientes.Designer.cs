namespace InisioSesion_Asado.FROMS
{
    partial class Clientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.txtBuscarClientes = new System.Windows.Forms.TextBox();
            this.lblBuscarFacturasEmitidas = new System.Windows.Forms.Label();
            this.datagrewClientes = new System.Windows.Forms.DataGridView();
            this.CODIGOClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBREClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONOClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCIONClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTASClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditarClientes = new System.Windows.Forms.Button();
            this.btnEliminarClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clientes";
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnNuevoCliente.Location = new System.Drawing.Point(35, 484);
            this.btnNuevoCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(151, 50);
            this.btnNuevoCliente.TabIndex = 14;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            // 
            // txtBuscarClientes
            // 
            this.txtBuscarClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBuscarClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarClientes.Location = new System.Drawing.Point(834, 25);
            this.txtBuscarClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscarClientes.Name = "txtBuscarClientes";
            this.txtBuscarClientes.Size = new System.Drawing.Size(210, 34);
            this.txtBuscarClientes.TabIndex = 13;
            // 
            // lblBuscarFacturasEmitidas
            // 
            this.lblBuscarFacturasEmitidas.AutoSize = true;
            this.lblBuscarFacturasEmitidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBuscarFacturasEmitidas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarFacturasEmitidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblBuscarFacturasEmitidas.Location = new System.Drawing.Point(735, 27);
            this.lblBuscarFacturasEmitidas.Name = "lblBuscarFacturasEmitidas";
            this.lblBuscarFacturasEmitidas.Size = new System.Drawing.Size(81, 28);
            this.lblBuscarFacturasEmitidas.TabIndex = 12;
            this.lblBuscarFacturasEmitidas.Text = "Buscar:";
            this.lblBuscarFacturasEmitidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datagrewClientes
            // 
            this.datagrewClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrewClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.datagrewClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrewClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datagrewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGOClient,
            this.NOMBREClient,
            this.TELEFONOClient,
            this.DIRECCIONClient,
            this.NOTASClient});
            this.datagrewClientes.Location = new System.Drawing.Point(35, 79);
            this.datagrewClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datagrewClientes.Name = "datagrewClientes";
            this.datagrewClientes.RowHeadersWidth = 62;
            this.datagrewClientes.RowTemplate.Height = 28;
            this.datagrewClientes.Size = new System.Drawing.Size(1009, 380);
            this.datagrewClientes.TabIndex = 15;
            // 
            // CODIGOClient
            // 
            this.CODIGOClient.HeaderText = "Codigo";
            this.CODIGOClient.MinimumWidth = 8;
            this.CODIGOClient.Name = "CODIGOClient";
            // 
            // NOMBREClient
            // 
            this.NOMBREClient.HeaderText = "Nombre";
            this.NOMBREClient.MinimumWidth = 8;
            this.NOMBREClient.Name = "NOMBREClient";
            // 
            // TELEFONOClient
            // 
            this.TELEFONOClient.HeaderText = "Telefono";
            this.TELEFONOClient.MinimumWidth = 8;
            this.TELEFONOClient.Name = "TELEFONOClient";
            // 
            // DIRECCIONClient
            // 
            this.DIRECCIONClient.HeaderText = "Direccion";
            this.DIRECCIONClient.MinimumWidth = 8;
            this.DIRECCIONClient.Name = "DIRECCIONClient";
            // 
            // NOTASClient
            // 
            this.NOTASClient.HeaderText = "Notas";
            this.NOTASClient.MinimumWidth = 8;
            this.NOTASClient.Name = "NOTASClient";
            // 
            // btnEditarClientes
            // 
            this.btnEditarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnEditarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnEditarClientes.Location = new System.Drawing.Point(223, 484);
            this.btnEditarClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditarClientes.Name = "btnEditarClientes";
            this.btnEditarClientes.Size = new System.Drawing.Size(151, 50);
            this.btnEditarClientes.TabIndex = 16;
            this.btnEditarClientes.Text = "Editar";
            this.btnEditarClientes.UseVisualStyleBackColor = false;
            // 
            // btnEliminarClientes
            // 
            this.btnEliminarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnEliminarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnEliminarClientes.Location = new System.Drawing.Point(399, 484);
            this.btnEliminarClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarClientes.Name = "btnEliminarClientes";
            this.btnEliminarClientes.Size = new System.Drawing.Size(151, 50);
            this.btnEliminarClientes.TabIndex = 17;
            this.btnEliminarClientes.Text = "Eliminar";
            this.btnEliminarClientes.UseVisualStyleBackColor = false;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1074, 568);
            this.Controls.Add(this.btnEliminarClientes);
            this.Controls.Add(this.btnEditarClientes);
            this.Controls.Add(this.datagrewClientes);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.txtBuscarClientes);
            this.Controls.Add(this.lblBuscarFacturasEmitidas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.datagrewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.TextBox txtBuscarClientes;
        private System.Windows.Forms.Label lblBuscarFacturasEmitidas;
        private System.Windows.Forms.DataGridView datagrewClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONOClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCIONClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTASClient;
        private System.Windows.Forms.Button btnEditarClientes;
        private System.Windows.Forms.Button btnEliminarClientes;
    }
}