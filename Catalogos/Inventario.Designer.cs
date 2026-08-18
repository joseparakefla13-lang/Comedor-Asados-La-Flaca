namespace InisioSesion_Asado.FROMS
{
    partial class Inventario
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
            this.datagrewEmpleados = new System.Windows.Forms.DataGridView();
            this.CODIGOEmple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBREmple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONOEmple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CARGOEmple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioEmple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INGRESOEmple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADOEmple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevoProduct = new System.Windows.Forms.Button();
            this.txtBuscarInventario = new System.Windows.Forms.TextBox();
            this.lblBuscarInventario = new System.Windows.Forms.Label();
            this.lblInventario = new System.Windows.Forms.Label();
            this.lblCategoriaInvetar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnEditarProduct = new System.Windows.Forms.Button();
            this.btnEntradaStock = new System.Windows.Forms.Button();
            this.btnSalidaMerma = new System.Windows.Forms.Button();
            this.btnAjustarStock = new System.Windows.Forms.Button();
            this.btnEliminarInventar = new System.Windows.Forms.Button();
            this.btnMovimientosInvent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrewEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrewEmpleados
            // 
            this.datagrewEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrewEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.datagrewEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrewEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datagrewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrewEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGOEmple,
            this.NOMBREmple,
            this.TELEFONOEmple,
            this.CARGOEmple,
            this.SalarioEmple,
            this.INGRESOEmple,
            this.ESTADOEmple});
            this.datagrewEmpleados.Location = new System.Drawing.Point(44, 92);
            this.datagrewEmpleados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datagrewEmpleados.Name = "datagrewEmpleados";
            this.datagrewEmpleados.RowHeadersWidth = 62;
            this.datagrewEmpleados.RowTemplate.Height = 28;
            this.datagrewEmpleados.Size = new System.Drawing.Size(1009, 380);
            this.datagrewEmpleados.TabIndex = 29;
            // 
            // CODIGOEmple
            // 
            this.CODIGOEmple.HeaderText = "Codigo";
            this.CODIGOEmple.MinimumWidth = 8;
            this.CODIGOEmple.Name = "CODIGOEmple";
            // 
            // NOMBREmple
            // 
            this.NOMBREmple.HeaderText = "Nombre";
            this.NOMBREmple.MinimumWidth = 8;
            this.NOMBREmple.Name = "NOMBREmple";
            // 
            // TELEFONOEmple
            // 
            this.TELEFONOEmple.HeaderText = "Telefono";
            this.TELEFONOEmple.MinimumWidth = 8;
            this.TELEFONOEmple.Name = "TELEFONOEmple";
            // 
            // CARGOEmple
            // 
            this.CARGOEmple.HeaderText = "Cargo";
            this.CARGOEmple.MinimumWidth = 8;
            this.CARGOEmple.Name = "CARGOEmple";
            // 
            // SalarioEmple
            // 
            this.SalarioEmple.HeaderText = "Salario";
            this.SalarioEmple.MinimumWidth = 8;
            this.SalarioEmple.Name = "SalarioEmple";
            // 
            // INGRESOEmple
            // 
            this.INGRESOEmple.HeaderText = "Ingreso";
            this.INGRESOEmple.MinimumWidth = 8;
            this.INGRESOEmple.Name = "INGRESOEmple";
            // 
            // ESTADOEmple
            // 
            this.ESTADOEmple.HeaderText = "Estado";
            this.ESTADOEmple.MinimumWidth = 8;
            this.ESTADOEmple.Name = "ESTADOEmple";
            // 
            // btnNuevoProduct
            // 
            this.btnNuevoProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnNuevoProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnNuevoProduct.Location = new System.Drawing.Point(12, 512);
            this.btnNuevoProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNuevoProduct.Name = "btnNuevoProduct";
            this.btnNuevoProduct.Size = new System.Drawing.Size(151, 43);
            this.btnNuevoProduct.TabIndex = 28;
            this.btnNuevoProduct.Text = "Nuevo Producto";
            this.btnNuevoProduct.UseVisualStyleBackColor = false;
            // 
            // txtBuscarInventario
            // 
            this.txtBuscarInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBuscarInventario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarInventario.Location = new System.Drawing.Point(525, 33);
            this.txtBuscarInventario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscarInventario.Name = "txtBuscarInventario";
            this.txtBuscarInventario.Size = new System.Drawing.Size(210, 34);
            this.txtBuscarInventario.TabIndex = 27;
            // 
            // lblBuscarInventario
            // 
            this.lblBuscarInventario.AutoSize = true;
            this.lblBuscarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBuscarInventario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblBuscarInventario.Location = new System.Drawing.Point(426, 35);
            this.lblBuscarInventario.Name = "lblBuscarInventario";
            this.lblBuscarInventario.Size = new System.Drawing.Size(81, 28);
            this.lblBuscarInventario.TabIndex = 26;
            this.lblBuscarInventario.Text = "Buscar:";
            this.lblBuscarInventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.lblInventario.Location = new System.Drawing.Point(21, 22);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(132, 32);
            this.lblInventario.TabIndex = 25;
            this.lblInventario.Text = "Inventario";
            // 
            // lblCategoriaInvetar
            // 
            this.lblCategoriaInvetar.AutoSize = true;
            this.lblCategoriaInvetar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCategoriaInvetar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaInvetar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCategoriaInvetar.Location = new System.Drawing.Point(744, 35);
            this.lblCategoriaInvetar.Name = "lblCategoriaInvetar";
            this.lblCategoriaInvetar.Size = new System.Drawing.Size(108, 28);
            this.lblCategoriaInvetar.TabIndex = 32;
            this.lblCategoriaInvetar.Text = "Categoria:";
            this.lblCategoriaInvetar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(858, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 33);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.Text = "Todas";
            // 
            // btnEditarProduct
            // 
            this.btnEditarProduct.BackColor = System.Drawing.Color.Gray;
            this.btnEditarProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnEditarProduct.Location = new System.Drawing.Point(185, 512);
            this.btnEditarProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditarProduct.Name = "btnEditarProduct";
            this.btnEditarProduct.Size = new System.Drawing.Size(151, 43);
            this.btnEditarProduct.TabIndex = 34;
            this.btnEditarProduct.Text = "Editar";
            this.btnEditarProduct.UseVisualStyleBackColor = false;
            // 
            // btnEntradaStock
            // 
            this.btnEntradaStock.BackColor = System.Drawing.Color.Gray;
            this.btnEntradaStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntradaStock.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradaStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnEntradaStock.Location = new System.Drawing.Point(356, 512);
            this.btnEntradaStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEntradaStock.Name = "btnEntradaStock";
            this.btnEntradaStock.Size = new System.Drawing.Size(151, 43);
            this.btnEntradaStock.TabIndex = 35;
            this.btnEntradaStock.Text = "Entrada/Stock";
            this.btnEntradaStock.UseVisualStyleBackColor = false;
            // 
            // btnSalidaMerma
            // 
            this.btnSalidaMerma.BackColor = System.Drawing.Color.Gray;
            this.btnSalidaMerma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalidaMerma.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalidaMerma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnSalidaMerma.Location = new System.Drawing.Point(525, 512);
            this.btnSalidaMerma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalidaMerma.Name = "btnSalidaMerma";
            this.btnSalidaMerma.Size = new System.Drawing.Size(151, 43);
            this.btnSalidaMerma.TabIndex = 36;
            this.btnSalidaMerma.Text = "Salida/Merma";
            this.btnSalidaMerma.UseVisualStyleBackColor = false;
            // 
            // btnAjustarStock
            // 
            this.btnAjustarStock.BackColor = System.Drawing.Color.Gray;
            this.btnAjustarStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjustarStock.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustarStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnAjustarStock.Location = new System.Drawing.Point(691, 512);
            this.btnAjustarStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAjustarStock.Name = "btnAjustarStock";
            this.btnAjustarStock.Size = new System.Drawing.Size(151, 43);
            this.btnAjustarStock.TabIndex = 37;
            this.btnAjustarStock.Text = "Ajustar Stock";
            this.btnAjustarStock.UseVisualStyleBackColor = false;
            // 
            // btnEliminarInventar
            // 
            this.btnEliminarInventar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnEliminarInventar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarInventar.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarInventar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnEliminarInventar.Location = new System.Drawing.Point(858, 512);
            this.btnEliminarInventar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarInventar.Name = "btnEliminarInventar";
            this.btnEliminarInventar.Size = new System.Drawing.Size(151, 43);
            this.btnEliminarInventar.TabIndex = 38;
            this.btnEliminarInventar.Text = "Eliminar";
            this.btnEliminarInventar.UseVisualStyleBackColor = false;
            // 
            // btnMovimientosInvent
            // 
            this.btnMovimientosInvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnMovimientosInvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMovimientosInvent.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimientosInvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnMovimientosInvent.Location = new System.Drawing.Point(217, 30);
            this.btnMovimientosInvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMovimientosInvent.Name = "btnMovimientosInvent";
            this.btnMovimientosInvent.Size = new System.Drawing.Size(151, 43);
            this.btnMovimientosInvent.TabIndex = 39;
            this.btnMovimientosInvent.Text = "Movimientos";
            this.btnMovimientosInvent.UseVisualStyleBackColor = false;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1074, 568);
            this.Controls.Add(this.btnMovimientosInvent);
            this.Controls.Add(this.btnEliminarInventar);
            this.Controls.Add(this.btnAjustarStock);
            this.Controls.Add(this.btnSalidaMerma);
            this.Controls.Add(this.btnEntradaStock);
            this.Controls.Add(this.btnEditarProduct);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCategoriaInvetar);
            this.Controls.Add(this.datagrewEmpleados);
            this.Controls.Add(this.btnNuevoProduct);
            this.Controls.Add(this.txtBuscarInventario);
            this.Controls.Add(this.lblBuscarInventario);
            this.Controls.Add(this.lblInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventario";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.datagrewEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView datagrewEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOEmple;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREmple;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONOEmple;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARGOEmple;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioEmple;
        private System.Windows.Forms.DataGridViewTextBoxColumn INGRESOEmple;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADOEmple;
        private System.Windows.Forms.Button btnNuevoProduct;
        private System.Windows.Forms.TextBox txtBuscarInventario;
        private System.Windows.Forms.Label lblBuscarInventario;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Label lblCategoriaInvetar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnEditarProduct;
        private System.Windows.Forms.Button btnEntradaStock;
        private System.Windows.Forms.Button btnSalidaMerma;
        private System.Windows.Forms.Button btnAjustarStock;
        private System.Windows.Forms.Button btnEliminarInventar;
        private System.Windows.Forms.Button btnMovimientosInvent;
    }
}