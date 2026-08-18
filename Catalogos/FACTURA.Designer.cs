namespace InisioSesion_Asado.FROMS
{
    partial class FACTURA
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
            this.grboxDatosPedido = new System.Windows.Forms.GroupBox();
            this.btnNuvCliente = new System.Windows.Forms.Button();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.cmboxAtendido = new System.Windows.Forms.ComboBox();
            this.cmboxformapago = new System.Windows.Forms.ComboBox();
            this.cmboxClientes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.grboxAggProduct = new System.Windows.Forms.GroupBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.numricCantidad = new System.Windows.Forms.NumericUpDown();
            this.cmboxProducto = new System.Windows.Forms.ComboBox();
            this.cmboxCategorias = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grboxDetalleFact = new System.Windows.Forms.GroupBox();
            this.datagrewDetalleFACT = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnguardarFactura = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnQuitarLine = new System.Windows.Forms.Button();
            this.btnLimpiarAll = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.grboxDatosPedido.SuspendLayout();
            this.grboxAggProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numricCantidad)).BeginInit();
            this.grboxDetalleFact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrewDetalleFACT)).BeginInit();
            this.SuspendLayout();
            // 
            // grboxDatosPedido
            // 
            this.grboxDatosPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.grboxDatosPedido.Controls.Add(this.btnNuvCliente);
            this.grboxDatosPedido.Controls.Add(this.txtObservaciones);
            this.grboxDatosPedido.Controls.Add(this.cmboxAtendido);
            this.grboxDatosPedido.Controls.Add(this.cmboxformapago);
            this.grboxDatosPedido.Controls.Add(this.cmboxClientes);
            this.grboxDatosPedido.Controls.Add(this.label3);
            this.grboxDatosPedido.Controls.Add(this.label2);
            this.grboxDatosPedido.Controls.Add(this.label1);
            this.grboxDatosPedido.Controls.Add(this.lblCliente);
            this.grboxDatosPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grboxDatosPedido.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grboxDatosPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.grboxDatosPedido.Location = new System.Drawing.Point(12, 12);
            this.grboxDatosPedido.Name = "grboxDatosPedido";
            this.grboxDatosPedido.Size = new System.Drawing.Size(1036, 171);
            this.grboxDatosPedido.TabIndex = 0;
            this.grboxDatosPedido.TabStop = false;
            this.grboxDatosPedido.Text = "Datos del Pedido";
            // 
            // btnNuvCliente
            // 
            this.btnNuvCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnNuvCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuvCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuvCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnNuvCliente.Location = new System.Drawing.Point(438, 45);
            this.btnNuvCliente.Name = "btnNuvCliente";
            this.btnNuvCliente.Size = new System.Drawing.Size(136, 40);
            this.btnNuvCliente.TabIndex = 8;
            this.btnNuvCliente.Text = "+Nuevo Cliente";
            this.btnNuvCliente.UseVisualStyleBackColor = false;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtObservaciones.Location = new System.Drawing.Point(711, 113);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(224, 31);
            this.txtObservaciones.TabIndex = 7;
            // 
            // cmboxAtendido
            // 
            this.cmboxAtendido.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxAtendido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmboxAtendido.FormattingEnabled = true;
            this.cmboxAtendido.Location = new System.Drawing.Point(711, 49);
            this.cmboxAtendido.Name = "cmboxAtendido";
            this.cmboxAtendido.Size = new System.Drawing.Size(224, 33);
            this.cmboxAtendido.TabIndex = 6;
            // 
            // cmboxformapago
            // 
            this.cmboxformapago.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxformapago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmboxformapago.FormattingEnabled = true;
            this.cmboxformapago.Location = new System.Drawing.Point(178, 113);
            this.cmboxformapago.Name = "cmboxformapago";
            this.cmboxformapago.Size = new System.Drawing.Size(182, 33);
            this.cmboxformapago.TabIndex = 5;
            // 
            // cmboxClientes
            // 
            this.cmboxClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmboxClientes.FormattingEnabled = true;
            this.cmboxClientes.Location = new System.Drawing.Point(178, 49);
            this.cmboxClientes.Name = "cmboxClientes";
            this.cmboxClientes.Size = new System.Drawing.Size(240, 33);
            this.cmboxClientes.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label3.Location = new System.Drawing.Point(580, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Observacion: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(580, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Atendido por: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(20, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forma de pago: ";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCliente.Location = new System.Drawing.Point(20, 58);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(80, 25);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente: ";
            // 
            // grboxAggProduct
            // 
            this.grboxAggProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.grboxAggProduct.Controls.Add(this.btnAgregarProducto);
            this.grboxAggProduct.Controls.Add(this.numricCantidad);
            this.grboxAggProduct.Controls.Add(this.cmboxProducto);
            this.grboxAggProduct.Controls.Add(this.cmboxCategorias);
            this.grboxAggProduct.Controls.Add(this.label4);
            this.grboxAggProduct.Controls.Add(this.label5);
            this.grboxAggProduct.Controls.Add(this.label7);
            this.grboxAggProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grboxAggProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grboxAggProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.grboxAggProduct.Location = new System.Drawing.Point(12, 200);
            this.grboxAggProduct.Name = "grboxAggProduct";
            this.grboxAggProduct.Size = new System.Drawing.Size(1036, 111);
            this.grboxAggProduct.TabIndex = 1;
            this.grboxAggProduct.TabStop = false;
            this.grboxAggProduct.Text = "Agregar Productos";
            this.grboxAggProduct.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnAgregarProducto.Location = new System.Drawing.Point(880, 38);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(127, 57);
            this.btnAgregarProducto.TabIndex = 9;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // numricCantidad
            // 
            this.numricCantidad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numricCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.numricCantidad.Location = new System.Drawing.Point(771, 55);
            this.numricCantidad.Name = "numricCantidad";
            this.numricCantidad.Size = new System.Drawing.Size(89, 31);
            this.numricCantidad.TabIndex = 7;
            // 
            // cmboxProducto
            // 
            this.cmboxProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmboxProducto.FormattingEnabled = true;
            this.cmboxProducto.Location = new System.Drawing.Point(438, 55);
            this.cmboxProducto.Name = "cmboxProducto";
            this.cmboxProducto.Size = new System.Drawing.Size(224, 33);
            this.cmboxProducto.TabIndex = 6;
            // 
            // cmboxCategorias
            // 
            this.cmboxCategorias.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.cmboxCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmboxCategorias.FormattingEnabled = true;
            this.cmboxCategorias.Location = new System.Drawing.Point(116, 55);
            this.cmboxCategorias.Name = "cmboxCategorias";
            this.cmboxCategorias.Size = new System.Drawing.Size(201, 33);
            this.cmboxCategorias.TabIndex = 4;
            this.cmboxCategorias.Text = "Todas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label4.Location = new System.Drawing.Point(680, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label5.Location = new System.Drawing.Point(336, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Productos: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label7.Location = new System.Drawing.Point(20, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Categoria: ";
            // 
            // grboxDetalleFact
            // 
            this.grboxDetalleFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.grboxDetalleFact.Controls.Add(this.datagrewDetalleFACT);
            this.grboxDetalleFact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grboxDetalleFact.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxDetalleFact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.grboxDetalleFact.Location = new System.Drawing.Point(12, 329);
            this.grboxDetalleFact.Name = "grboxDetalleFact";
            this.grboxDetalleFact.Size = new System.Drawing.Size(742, 218);
            this.grboxDetalleFact.TabIndex = 2;
            this.grboxDetalleFact.TabStop = false;
            this.grboxDetalleFact.Text = "Detalle de Factura";
            // 
            // datagrewDetalleFACT
            // 
            this.datagrewDetalleFACT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.datagrewDetalleFACT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrewDetalleFACT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrewDetalleFACT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.DESCRIPCION,
            this.CANTIDAD,
            this.PRECIO,
            this.SUBTOTAL});
            this.datagrewDetalleFACT.Location = new System.Drawing.Point(6, 48);
            this.datagrewDetalleFACT.Name = "datagrewDetalleFACT";
            this.datagrewDetalleFACT.RowHeadersWidth = 62;
            this.datagrewDetalleFACT.RowTemplate.Height = 28;
            this.datagrewDetalleFACT.Size = new System.Drawing.Size(729, 151);
            this.datagrewDetalleFACT.TabIndex = 0;
            // 
            // CODIGO
            // 
            this.CODIGO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO.HeaderText = "Codigo";
            this.CODIGO.MinimumWidth = 8;
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.Width = 127;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DESCRIPCION.HeaderText = "Descripcion";
            this.DESCRIPCION.MinimumWidth = 8;
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.Width = 175;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CANTIDAD.HeaderText = "Cant.";
            this.CANTIDAD.MinimumWidth = 8;
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.Width = 107;
            // 
            // PRECIO
            // 
            this.PRECIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PRECIO.HeaderText = "Precio";
            this.PRECIO.MinimumWidth = 8;
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.Width = 117;
            // 
            // SUBTOTAL
            // 
            this.SUBTOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SUBTOTAL.HeaderText = "Subtotal";
            this.SUBTOTAL.MinimumWidth = 8;
            this.SUBTOTAL.Name = "SUBTOTAL";
            this.SUBTOTAL.Width = 142;
            // 
            // btnguardarFactura
            // 
            this.btnguardarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnguardarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnguardarFactura.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnguardarFactura.Location = new System.Drawing.Point(783, 392);
            this.btnguardarFactura.Name = "btnguardarFactura";
            this.btnguardarFactura.Size = new System.Drawing.Size(127, 37);
            this.btnguardarFactura.TabIndex = 10;
            this.btnguardarFactura.Text = "Guardar Fact.";
            this.btnguardarFactura.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label6.Location = new System.Drawing.Point(778, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total: ";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.textBox1.Location = new System.Drawing.Point(843, 323);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 34);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "C$120";
            // 
            // btnQuitarLine
            // 
            this.btnQuitarLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnQuitarLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitarLine.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnQuitarLine.Location = new System.Drawing.Point(783, 475);
            this.btnQuitarLine.Name = "btnQuitarLine";
            this.btnQuitarLine.Size = new System.Drawing.Size(127, 37);
            this.btnQuitarLine.TabIndex = 13;
            this.btnQuitarLine.Text = "Quitar Linea";
            this.btnQuitarLine.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarAll
            // 
            this.btnLimpiarAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btnLimpiarAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiarAll.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnLimpiarAll.Location = new System.Drawing.Point(921, 392);
            this.btnLimpiarAll.Name = "btnLimpiarAll";
            this.btnLimpiarAll.Size = new System.Drawing.Size(127, 37);
            this.btnLimpiarAll.TabIndex = 14;
            this.btnLimpiarAll.Text = "Limpiar Todo";
            this.btnLimpiarAll.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.button3.Location = new System.Drawing.Point(921, 475);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 37);
            this.button3.TabIndex = 15;
            this.button3.Text = "Ver/Imprimir";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // FACTURA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1074, 568);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnLimpiarAll);
            this.Controls.Add(this.btnQuitarLine);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnguardarFactura);
            this.Controls.Add(this.grboxDetalleFact);
            this.Controls.Add(this.grboxAggProduct);
            this.Controls.Add(this.grboxDatosPedido);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FACTURA";
            this.Text = "FACTURA";
            this.grboxDatosPedido.ResumeLayout(false);
            this.grboxDatosPedido.PerformLayout();
            this.grboxAggProduct.ResumeLayout(false);
            this.grboxAggProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numricCantidad)).EndInit();
            this.grboxDetalleFact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrewDetalleFACT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grboxDatosPedido;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmboxClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboxAtendido;
        private System.Windows.Forms.ComboBox cmboxformapago;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnNuvCliente;
        private System.Windows.Forms.GroupBox grboxAggProduct;
        private System.Windows.Forms.ComboBox cmboxProducto;
        private System.Windows.Forms.ComboBox cmboxCategorias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numricCantidad;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.GroupBox grboxDetalleFact;
        private System.Windows.Forms.DataGridView datagrewDetalleFACT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBTOTAL;
        private System.Windows.Forms.Button btnguardarFactura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnQuitarLine;
        private System.Windows.Forms.Button btnLimpiarAll;
        private System.Windows.Forms.Button button3;
    }
}