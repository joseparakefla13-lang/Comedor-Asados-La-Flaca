namespace InisioSesion_Asado.FROMS
{
    partial class Facturas_Emitidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturas_Emitidas));
            this.lblDesdeFactEmitidas = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.lblHastaFactEmitidas = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscarFacturasEmitidas = new System.Windows.Forms.Label();
            this.btnFiltrarFact = new System.Windows.Forms.Button();
            this.datagrewFacturasEmitidas = new System.Windows.Forms.DataGridView();
            this.NUMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATENDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerComprobante = new System.Windows.Forms.Button();
            this.btnAnularFactura = new System.Windows.Forms.Button();
            this.txtFacturas_totales = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrewFacturasEmitidas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDesdeFactEmitidas
            // 
            this.lblDesdeFactEmitidas.AutoSize = true;
            this.lblDesdeFactEmitidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDesdeFactEmitidas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesdeFactEmitidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblDesdeFactEmitidas.Location = new System.Drawing.Point(43, 40);
            this.lblDesdeFactEmitidas.Name = "lblDesdeFactEmitidas";
            this.lblDesdeFactEmitidas.Size = new System.Drawing.Size(75, 28);
            this.lblDesdeFactEmitidas.TabIndex = 2;
            this.lblDesdeFactEmitidas.Text = "Desde:";
            this.lblDesdeFactEmitidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDesde
            // 
            this.txtDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDesde.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesde.Location = new System.Drawing.Point(142, 38);
            this.txtDesde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(158, 34);
            this.txtDesde.TabIndex = 6;
            // 
            // txtHasta
            // 
            this.txtHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtHasta.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHasta.Location = new System.Drawing.Point(421, 38);
            this.txtHasta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(158, 34);
            this.txtHasta.TabIndex = 8;
            // 
            // lblHastaFactEmitidas
            // 
            this.lblHastaFactEmitidas.AutoSize = true;
            this.lblHastaFactEmitidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHastaFactEmitidas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaFactEmitidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblHastaFactEmitidas.Location = new System.Drawing.Point(322, 40);
            this.lblHastaFactEmitidas.Name = "lblHastaFactEmitidas";
            this.lblHastaFactEmitidas.Size = new System.Drawing.Size(71, 28);
            this.lblHastaFactEmitidas.TabIndex = 7;
            this.lblHastaFactEmitidas.Text = "Hasta:";
            this.lblHastaFactEmitidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHastaFactEmitidas.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(706, 38);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(158, 34);
            this.txtBuscar.TabIndex = 10;
            // 
            // lblBuscarFacturasEmitidas
            // 
            this.lblBuscarFacturasEmitidas.AutoSize = true;
            this.lblBuscarFacturasEmitidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBuscarFacturasEmitidas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarFacturasEmitidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblBuscarFacturasEmitidas.Location = new System.Drawing.Point(607, 40);
            this.lblBuscarFacturasEmitidas.Name = "lblBuscarFacturasEmitidas";
            this.lblBuscarFacturasEmitidas.Size = new System.Drawing.Size(81, 28);
            this.lblBuscarFacturasEmitidas.TabIndex = 9;
            this.lblBuscarFacturasEmitidas.Text = "Buscar:";
            this.lblBuscarFacturasEmitidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFiltrarFact
            // 
            this.btnFiltrarFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnFiltrarFact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrarFact.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarFact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnFiltrarFact.Location = new System.Drawing.Point(886, 35);
            this.btnFiltrarFact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFiltrarFact.Name = "btnFiltrarFact";
            this.btnFiltrarFact.Size = new System.Drawing.Size(151, 50);
            this.btnFiltrarFact.TabIndex = 11;
            this.btnFiltrarFact.Text = "Filtrar";
            this.btnFiltrarFact.UseVisualStyleBackColor = false;
            // 
            // datagrewFacturasEmitidas
            // 
            this.datagrewFacturasEmitidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrewFacturasEmitidas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.datagrewFacturasEmitidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrewFacturasEmitidas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datagrewFacturasEmitidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrewFacturasEmitidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUMERO,
            this.FECHA,
            this.CLIENTE,
            this.ATENDIDO,
            this.PAGO,
            this.TOTAL,
            this.ESTADO});
            this.datagrewFacturasEmitidas.Location = new System.Drawing.Point(31, 119);
            this.datagrewFacturasEmitidas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datagrewFacturasEmitidas.Name = "datagrewFacturasEmitidas";
            this.datagrewFacturasEmitidas.RowHeadersWidth = 62;
            this.datagrewFacturasEmitidas.RowTemplate.Height = 28;
            this.datagrewFacturasEmitidas.Size = new System.Drawing.Size(1113, 420);
            this.datagrewFacturasEmitidas.TabIndex = 12;
            // 
            // NUMERO
            // 
            this.NUMERO.HeaderText = "Numero";
            this.NUMERO.MinimumWidth = 8;
            this.NUMERO.Name = "NUMERO";
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "Fecha";
            this.FECHA.MinimumWidth = 8;
            this.FECHA.Name = "FECHA";
            // 
            // CLIENTE
            // 
            this.CLIENTE.HeaderText = "Cliente";
            this.CLIENTE.MinimumWidth = 8;
            this.CLIENTE.Name = "CLIENTE";
            // 
            // ATENDIDO
            // 
            this.ATENDIDO.HeaderText = "Atendido";
            this.ATENDIDO.MinimumWidth = 8;
            this.ATENDIDO.Name = "ATENDIDO";
            // 
            // PAGO
            // 
            this.PAGO.HeaderText = "Pago";
            this.PAGO.MinimumWidth = 8;
            this.PAGO.Name = "PAGO";
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "Total";
            this.TOTAL.MinimumWidth = 8;
            this.TOTAL.Name = "TOTAL";
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "Estado";
            this.ESTADO.MinimumWidth = 8;
            this.ESTADO.Name = "ESTADO";
            // 
            // btnVerComprobante
            // 
            this.btnVerComprobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnVerComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerComprobante.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerComprobante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnVerComprobante.Location = new System.Drawing.Point(31, 578);
            this.btnVerComprobante.Name = "btnVerComprobante";
            this.btnVerComprobante.Size = new System.Drawing.Size(204, 57);
            this.btnVerComprobante.TabIndex = 13;
            this.btnVerComprobante.Text = "Ver Comprobante";
            this.btnVerComprobante.UseVisualStyleBackColor = false;
            // 
            // btnAnularFactura
            // 
            this.btnAnularFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnAnularFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnularFactura.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnularFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnAnularFactura.Location = new System.Drawing.Point(295, 578);
            this.btnAnularFactura.Name = "btnAnularFactura";
            this.btnAnularFactura.Size = new System.Drawing.Size(204, 57);
            this.btnAnularFactura.TabIndex = 14;
            this.btnAnularFactura.Text = "Anular Factura";
            this.btnAnularFactura.UseVisualStyleBackColor = false;
            // 
            // txtFacturas_totales
            // 
            this.txtFacturas_totales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(206)))));
            this.txtFacturas_totales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFacturas_totales.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacturas_totales.Location = new System.Drawing.Point(836, 578);
            this.txtFacturas_totales.Multiline = true;
            this.txtFacturas_totales.Name = "txtFacturas_totales";
            this.txtFacturas_totales.Size = new System.Drawing.Size(308, 57);
            this.txtFacturas_totales.TabIndex = 15;
            this.txtFacturas_totales.Text = "Facturas/Totales";
            this.txtFacturas_totales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Facturas_Emitidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1178, 668);
            this.Controls.Add(this.txtFacturas_totales);
            this.Controls.Add(this.btnAnularFactura);
            this.Controls.Add(this.btnVerComprobante);
            this.Controls.Add(this.datagrewFacturasEmitidas);
            this.Controls.Add(this.btnFiltrarFact);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscarFacturasEmitidas);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.lblHastaFactEmitidas);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.lblDesdeFactEmitidas);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Facturas_Emitidas";
            this.Text = "Facturas_Emitidas";
            ((System.ComponentModel.ISupportInitialize)(this.datagrewFacturasEmitidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesdeFactEmitidas;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Label lblHastaFactEmitidas;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscarFacturasEmitidas;
        private System.Windows.Forms.Button btnFiltrarFact;
        private System.Windows.Forms.DataGridView datagrewFacturasEmitidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATENDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.Button btnVerComprobante;
        private System.Windows.Forms.Button btnAnularFactura;
        private System.Windows.Forms.TextBox txtFacturas_totales;
    }
}