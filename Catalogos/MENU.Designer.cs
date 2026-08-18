namespace InisioSesion_Asado.FROMS
{
    partial class MENU
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnlbarraBotones = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grboxVentasHoy = new System.Windows.Forms.GroupBox();
            this.grboxVentasSemanales = new System.Windows.Forms.GroupBox();
            this.grboxFactSemanales = new System.Windows.Forms.GroupBox();
            this.grboxValorInventario = new System.Windows.Forms.GroupBox();
            this.GrboxProductBajos = new System.Windows.Forms.GroupBox();
            this.GboxUltimasFact = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.pnlbarraBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GrboxProductBajos.SuspendLayout();
            this.GboxUltimasFact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.pnlbarraBotones);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 680);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.lblEmpleados);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(226, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1122, 67);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(206)))));
            this.pnlPrincipal.Controls.Add(this.GboxUltimasFact);
            this.pnlPrincipal.Controls.Add(this.GrboxProductBajos);
            this.pnlPrincipal.Controls.Add(this.grboxValorInventario);
            this.pnlPrincipal.Controls.Add(this.grboxFactSemanales);
            this.pnlPrincipal.Controls.Add(this.grboxVentasSemanales);
            this.pnlPrincipal.Controls.Add(this.grboxVentasHoy);
            this.pnlPrincipal.Controls.Add(this.label1);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(226, 67);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1122, 613);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblEmpleados.Location = new System.Drawing.Point(21, 19);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(424, 32);
            this.lblEmpleados.TabIndex = 19;
            this.lblEmpleados.Text = "Sistema De Facturación e Inventario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Resumen del Negocio";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(869, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // pnlbarraBotones
            // 
            this.pnlbarraBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(206)))));
            this.pnlbarraBotones.Controls.Add(this.btnReportes);
            this.pnlbarraBotones.Controls.Add(this.btnInventario);
            this.pnlbarraBotones.Controls.Add(this.btnEmpleados);
            this.pnlbarraBotones.Controls.Add(this.btnClientes);
            this.pnlbarraBotones.Controls.Add(this.btnFacturacion);
            this.pnlbarraBotones.Controls.Add(this.btnInicio);
            this.pnlbarraBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlbarraBotones.Location = new System.Drawing.Point(0, 116);
            this.pnlbarraBotones.Name = "pnlbarraBotones";
            this.pnlbarraBotones.Size = new System.Drawing.Size(226, 371);
            this.pnlbarraBotones.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 618);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(226, 62);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salír";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 310);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(226, 62);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInventario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 248);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(226, 62);
            this.btnInventario.TabIndex = 4;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmpleados.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 186);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(226, 62);
            this.btnEmpleados.TabIndex = 3;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 124);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(226, 62);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnFacturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFacturacion.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnFacturacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.Location = new System.Drawing.Point(0, 62);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(226, 62);
            this.btnFacturacion.TabIndex = 1;
            this.btnFacturacion.Text = "Facturación";
            this.btnFacturacion.UseVisualStyleBackColor = false;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(226, 62);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grboxVentasHoy
            // 
            this.grboxVentasHoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.grboxVentasHoy.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxVentasHoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.grboxVentasHoy.Location = new System.Drawing.Point(27, 73);
            this.grboxVentasHoy.Name = "grboxVentasHoy";
            this.grboxVentasHoy.Size = new System.Drawing.Size(218, 132);
            this.grboxVentasHoy.TabIndex = 20;
            this.grboxVentasHoy.TabStop = false;
            this.grboxVentasHoy.Text = "Ventas de hoy";
            // 
            // grboxVentasSemanales
            // 
            this.grboxVentasSemanales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.grboxVentasSemanales.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxVentasSemanales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.grboxVentasSemanales.Location = new System.Drawing.Point(307, 73);
            this.grboxVentasSemanales.Name = "grboxVentasSemanales";
            this.grboxVentasSemanales.Size = new System.Drawing.Size(218, 132);
            this.grboxVentasSemanales.TabIndex = 21;
            this.grboxVentasSemanales.TabStop = false;
            this.grboxVentasSemanales.Text = "Ventas Semanales";
            // 
            // grboxFactSemanales
            // 
            this.grboxFactSemanales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.grboxFactSemanales.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxFactSemanales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.grboxFactSemanales.Location = new System.Drawing.Point(580, 73);
            this.grboxFactSemanales.Name = "grboxFactSemanales";
            this.grboxFactSemanales.Size = new System.Drawing.Size(218, 132);
            this.grboxFactSemanales.TabIndex = 22;
            this.grboxFactSemanales.TabStop = false;
            this.grboxFactSemanales.Text = "Facturas Semanales";
            // 
            // grboxValorInventario
            // 
            this.grboxValorInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.grboxValorInventario.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxValorInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.grboxValorInventario.Location = new System.Drawing.Point(851, 73);
            this.grboxValorInventario.Name = "grboxValorInventario";
            this.grboxValorInventario.Size = new System.Drawing.Size(218, 132);
            this.grboxValorInventario.TabIndex = 23;
            this.grboxValorInventario.TabStop = false;
            this.grboxValorInventario.Text = "Valor Inventario";
            // 
            // GrboxProductBajos
            // 
            this.GrboxProductBajos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.GrboxProductBajos.Controls.Add(this.dataGridView1);
            this.GrboxProductBajos.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrboxProductBajos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GrboxProductBajos.Location = new System.Drawing.Point(27, 289);
            this.GrboxProductBajos.Name = "GrboxProductBajos";
            this.GrboxProductBajos.Size = new System.Drawing.Size(498, 276);
            this.GrboxProductBajos.TabIndex = 24;
            this.GrboxProductBajos.TabStop = false;
            this.GrboxProductBajos.Text = "Productos Stock Bajos";
            // 
            // GboxUltimasFact
            // 
            this.GboxUltimasFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.GboxUltimasFact.Controls.Add(this.dataGridView2);
            this.GboxUltimasFact.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboxUltimasFact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GboxUltimasFact.Location = new System.Drawing.Point(571, 289);
            this.GboxUltimasFact.Name = "GboxUltimasFact";
            this.GboxUltimasFact.Size = new System.Drawing.Size(498, 276);
            this.GboxUltimasFact.TabIndex = 25;
            this.GboxUltimasFact.TabStop = false;
            this.GboxUltimasFact.Text = "Ultimas Facturas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(486, 239);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 31);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(486, 239);
            this.dataGridView2.TabIndex = 1;
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 680);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MENU";
            this.Text = "MENU";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlbarraBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GrboxProductBajos.ResumeLayout(false);
            this.GboxUltimasFact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel pnlbarraBotones;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.GroupBox grboxValorInventario;
        private System.Windows.Forms.GroupBox grboxFactSemanales;
        private System.Windows.Forms.GroupBox grboxVentasSemanales;
        private System.Windows.Forms.GroupBox grboxVentasHoy;
        private System.Windows.Forms.GroupBox GrboxProductBajos;
        private System.Windows.Forms.GroupBox GboxUltimasFact;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}