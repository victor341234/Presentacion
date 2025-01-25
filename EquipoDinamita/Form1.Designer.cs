namespace EquipoDinamita
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxbID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbStock = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelProducto = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnPantallas = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnTablillas = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCarcasas = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnBotones = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnGenerarPedido = new System.Windows.Forms.Button();
            this.LabelAlerta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbIdPantallaCP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxbIdTablillaCP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxbIdCarcasaCP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxbIdBotonesCP = new System.Windows.Forms.TextBox();
            this.TxbNumeroUnidades = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxbNombrePedido = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxbNombreEstereoCP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxbID
            // 
            this.TxbID.Location = new System.Drawing.Point(425, 52);
            this.TxbID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxbID.Name = "TxbID";
            this.TxbID.Size = new System.Drawing.Size(528, 39);
            this.TxbID.TabIndex = 0;
            this.TxbID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbStock_KeyPress);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(421, 29);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(122, 25);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID_Pantalla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // TxbNombre
            // 
            this.TxbNombre.Location = new System.Drawing.Point(424, 130);
            this.TxbNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxbNombre.Name = "TxbNombre";
            this.TxbNombre.Size = new System.Drawing.Size(529, 39);
            this.TxbNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numero de piezas:";
            // 
            // TxbStock
            // 
            this.TxbStock.Location = new System.Drawing.Point(424, 369);
            this.TxbStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxbStock.Name = "TxbStock";
            this.TxbStock.Size = new System.Drawing.Size(170, 39);
            this.TxbStock.TabIndex = 4;
            this.TxbStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbStock_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 542);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1786, 384);
            this.dataGridView1.TabIndex = 8;
            // 
            // labelProducto
            // 
            this.labelProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducto.Location = new System.Drawing.Point(14, 52);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(397, 229);
            this.labelProducto.TabIndex = 13;
            this.labelProducto.Text = "Pantallas";
            this.labelProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.Location = new System.Drawing.Point(14, 350);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(369, 61);
            this.BtnIngresar.TabIndex = 14;
            this.BtnIngresar.Text = "Agregar Producto  +";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(726, 268);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(228, 61);
            this.BtnEliminar.TabIndex = 15;
            this.BtnEliminar.Text = "Eliminar  -";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(425, 195);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(241, 61);
            this.BtnEditar.TabIndex = 16;
            this.BtnEditar.Text = "Editar  °";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem12,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1814, 53);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.toolStripMenuItem12.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnPantallas,
            this.BtnTablillas,
            this.BtnCarcasas,
            this.BtnBotones});
            this.toolStripMenuItem12.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(202, 49);
            this.toolStripMenuItem12.Text = "Productos:";
            // 
            // BtnPantallas
            // 
            this.BtnPantallas.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPantallas.Name = "BtnPantallas";
            this.BtnPantallas.Size = new System.Drawing.Size(206, 38);
            this.BtnPantallas.Text = "Pantallas";
            this.BtnPantallas.Click += new System.EventHandler(this.BtnPantallas_Click);
            // 
            // BtnTablillas
            // 
            this.BtnTablillas.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTablillas.Name = "BtnTablillas";
            this.BtnTablillas.Size = new System.Drawing.Size(206, 38);
            this.BtnTablillas.Text = "Tablillas";
            this.BtnTablillas.Click += new System.EventHandler(this.BtnTablillas_Click);
            // 
            // BtnCarcasas
            // 
            this.BtnCarcasas.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCarcasas.Name = "BtnCarcasas";
            this.BtnCarcasas.Size = new System.Drawing.Size(206, 38);
            this.BtnCarcasas.Text = "Carcasa";
            this.BtnCarcasas.Click += new System.EventHandler(this.BtnCarcasas_Click);
            // 
            // BtnBotones
            // 
            this.BtnBotones.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBotones.Name = "BtnBotones";
            this.BtnBotones.Size = new System.Drawing.Size(206, 38);
            this.BtnBotones.Text = "Botones";
            this.BtnBotones.Click += new System.EventHandler(this.BtnBotones_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(132, 49);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.labelProducto);
            this.groupBox1.Controls.Add(this.BtnIngresar);
            this.groupBox1.Controls.Add(this.TxbID);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Controls.Add(this.TxbStock);
            this.groupBox1.Controls.Add(this.BtnEditar);
            this.groupBox1.Controls.Add(this.TxbNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtnEliminar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(961, 474);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestor de Inventario:";
            // 
            // BtnGenerarPedido
            // 
            this.BtnGenerarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerarPedido.Location = new System.Drawing.Point(24, 341);
            this.BtnGenerarPedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGenerarPedido.Name = "BtnGenerarPedido";
            this.BtnGenerarPedido.Size = new System.Drawing.Size(299, 70);
            this.BtnGenerarPedido.TabIndex = 19;
            this.BtnGenerarPedido.Text = "Generar Pedido";
            this.BtnGenerarPedido.UseVisualStyleBackColor = true;
            this.BtnGenerarPedido.Click += new System.EventHandler(this.BtnGenerarPedido_Click);
            // 
            // LabelAlerta
            // 
            this.LabelAlerta.AutoSize = true;
            this.LabelAlerta.BackColor = System.Drawing.Color.Silver;
            this.LabelAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAlerta.Location = new System.Drawing.Point(344, 11);
            this.LabelAlerta.Name = "LabelAlerta";
            this.LabelAlerta.Size = new System.Drawing.Size(27, 38);
            this.LabelAlerta.TabIndex = 31;
            this.LabelAlerta.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ingrese Id.Pantalla:";
            // 
            // TxbIdPantallaCP
            // 
            this.TxbIdPantallaCP.Location = new System.Drawing.Point(24, 244);
            this.TxbIdPantallaCP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxbIdPantallaCP.Name = "TxbIdPantallaCP";
            this.TxbIdPantallaCP.Size = new System.Drawing.Size(121, 35);
            this.TxbIdPantallaCP.TabIndex = 17;
            this.TxbIdPantallaCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbStock_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ingrese Id.Tablilla:";
            // 
            // TxbIdTablillaCP
            // 
            this.TxbIdTablillaCP.Location = new System.Drawing.Point(243, 249);
            this.TxbIdTablillaCP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxbIdTablillaCP.Name = "TxbIdTablillaCP";
            this.TxbIdTablillaCP.Size = new System.Drawing.Size(128, 35);
            this.TxbIdTablillaCP.TabIndex = 25;
            this.TxbIdTablillaCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbStock_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(446, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ingrese Id.Carcasa:";
            // 
            // TxbIdCarcasaCP
            // 
            this.TxbIdCarcasaCP.Location = new System.Drawing.Point(450, 248);
            this.TxbIdCarcasaCP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxbIdCarcasaCP.Name = "TxbIdCarcasaCP";
            this.TxbIdCarcasaCP.Size = new System.Drawing.Size(127, 35);
            this.TxbIdCarcasaCP.TabIndex = 27;
            this.TxbIdCarcasaCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbStock_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(654, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Ingrese Id.Botones:";
            // 
            // TxbIdBotonesCP
            // 
            this.TxbIdBotonesCP.Location = new System.Drawing.Point(658, 248);
            this.TxbIdBotonesCP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxbIdBotonesCP.Name = "TxbIdBotonesCP";
            this.TxbIdBotonesCP.Size = new System.Drawing.Size(123, 35);
            this.TxbIdBotonesCP.TabIndex = 29;
            this.TxbIdBotonesCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbStock_KeyPress);
            // 
            // TxbNumeroUnidades
            // 
            this.TxbNumeroUnidades.Location = new System.Drawing.Point(197, 142);
            this.TxbNumeroUnidades.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxbNumeroUnidades.Name = "TxbNumeroUnidades";
            this.TxbNumeroUnidades.Size = new System.Drawing.Size(121, 35);
            this.TxbNumeroUnidades.TabIndex = 32;
            this.TxbNumeroUnidades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbStock_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Numero_Unidades";
            // 
            // TxbNombrePedido
            // 
            this.TxbNombrePedido.Location = new System.Drawing.Point(294, 44);
            this.TxbNombrePedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxbNombrePedido.Name = "TxbNombrePedido";
            this.TxbNombrePedido.Size = new System.Drawing.Size(532, 35);
            this.TxbNombrePedido.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(275, 25);
            this.label9.TabIndex = 35;
            this.label9.Text = "Ingrese Nombre Del Pedido";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.TxbNombreEstereoCP);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.BtnGenerarPedido);
            this.groupBox2.Controls.Add(this.TxbNombrePedido);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TxbIdPantallaCP);
            this.groupBox2.Controls.Add(this.TxbNumeroUnidades);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TxbIdTablillaCP);
            this.groupBox2.Controls.Add(this.TxbIdBotonesCP);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxbIdCarcasaCP);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(968, 61);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(832, 474);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crear Pedido:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(367, 341);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 70);
            this.button1.TabIndex = 38;
            this.button1.Text = "Historial Pedidos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnMostrarEstereo_Click);
            // 
            // TxbNombreEstereoCP
            // 
            this.TxbNombreEstereoCP.Location = new System.Drawing.Point(197, 98);
            this.TxbNombreEstereoCP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxbNombreEstereoCP.Name = "TxbNombreEstereoCP";
            this.TxbNombreEstereoCP.Size = new System.Drawing.Size(628, 35);
            this.TxbNombreEstereoCP.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 25);
            this.label10.TabIndex = 37;
            this.label10.Text = "Tipo Estereo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1814, 941);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LabelAlerta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxbID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbStock;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem BtnPantallas;
        private System.Windows.Forms.ToolStripMenuItem BtnTablillas;
        private System.Windows.Forms.ToolStripMenuItem BtnCarcasas;
        private System.Windows.Forms.ToolStripMenuItem BtnBotones;
        private System.Windows.Forms.Button BtnGenerarPedido;
        private System.Windows.Forms.Label LabelAlerta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbIdPantallaCP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxbIdTablillaCP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxbIdCarcasaCP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxbIdBotonesCP;
        private System.Windows.Forms.TextBox TxbNumeroUnidades;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxbNombrePedido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxbNombreEstereoCP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
    }
}

