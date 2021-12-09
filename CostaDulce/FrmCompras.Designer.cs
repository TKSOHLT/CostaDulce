
namespace CostaDulce
{
    partial class FrmCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompras));
            this.dgvcompras = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblingreso = new System.Windows.Forms.Label();
            this.txtidingreso = new System.Windows.Forms.TextBox();
            this.lblproveedor = new System.Windows.Forms.Label();
            this.txtidproveed = new System.Windows.Forms.TextBox();
            this.lblidusuario = new System.Windows.Forms.Label();
            this.txtidusuario = new System.Windows.Forms.TextBox();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblimpuesto = new System.Windows.Forms.Label();
            this.btnañadiringreso = new System.Windows.Forms.Button();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtprecioTot = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtprecioUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtarticulo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAñadirCompra = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompras)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvcompras
            // 
            this.dgvcompras.AllowUserToAddRows = false;
            this.dgvcompras.AllowUserToDeleteRows = false;
            this.dgvcompras.AllowUserToResizeColumns = false;
            this.dgvcompras.AllowUserToResizeRows = false;
            this.dgvcompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvcompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcompras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(198)))), ((int)(((byte)(254)))));
            this.dgvcompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvcompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvcompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcompras.Location = new System.Drawing.Point(33, 12);
            this.dgvcompras.Name = "dgvcompras";
            this.dgvcompras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcompras.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcompras.Size = new System.Drawing.Size(1138, 364);
            this.dgvcompras.TabIndex = 1;
            this.dgvcompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcompras_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.panel2.Controls.Add(this.dgvcompras);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1224, 389);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblingreso
            // 
            this.lblingreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblingreso.AutoSize = true;
            this.lblingreso.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblingreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblingreso.Location = new System.Drawing.Point(20, 93);
            this.lblingreso.Name = "lblingreso";
            this.lblingreso.Size = new System.Drawing.Size(87, 15);
            this.lblingreso.TabIndex = 0;
            this.lblingreso.Text = "ID INGRESO";
            // 
            // txtidingreso
            // 
            this.txtidingreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtidingreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.txtidingreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidingreso.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidingreso.Location = new System.Drawing.Point(121, 93);
            this.txtidingreso.Name = "txtidingreso";
            this.txtidingreso.Size = new System.Drawing.Size(98, 26);
            this.txtidingreso.TabIndex = 1;
            // 
            // lblproveedor
            // 
            this.lblproveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblproveedor.AutoSize = true;
            this.lblproveedor.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblproveedor.Location = new System.Drawing.Point(258, 58);
            this.lblproveedor.Name = "lblproveedor";
            this.lblproveedor.Size = new System.Drawing.Size(110, 15);
            this.lblproveedor.TabIndex = 2;
            this.lblproveedor.Text = "ID PROVEEDOR";
            this.lblproveedor.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtidproveed
            // 
            this.txtidproveed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtidproveed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.txtidproveed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidproveed.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidproveed.Location = new System.Drawing.Point(386, 58);
            this.txtidproveed.Name = "txtidproveed";
            this.txtidproveed.Size = new System.Drawing.Size(119, 26);
            this.txtidproveed.TabIndex = 3;
            // 
            // lblidusuario
            // 
            this.lblidusuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblidusuario.AutoSize = true;
            this.lblidusuario.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblidusuario.Location = new System.Drawing.Point(258, 98);
            this.lblidusuario.Name = "lblidusuario";
            this.lblidusuario.Size = new System.Drawing.Size(86, 15);
            this.lblidusuario.TabIndex = 4;
            this.lblidusuario.Text = "ID USUARIO";
            // 
            // txtidusuario
            // 
            this.txtidusuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtidusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.txtidusuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidusuario.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidusuario.Location = new System.Drawing.Point(386, 94);
            this.txtidusuario.Name = "txtidusuario";
            this.txtidusuario.Size = new System.Drawing.Size(119, 26);
            this.txtidusuario.TabIndex = 5;
            // 
            // lblfecha
            // 
            this.lblfecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblfecha.Location = new System.Drawing.Point(327, 146);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(53, 15);
            this.lblfecha.TabIndex = 6;
            this.lblfecha.Text = "FECHA";
            // 
            // lblimpuesto
            // 
            this.lblimpuesto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblimpuesto.AutoSize = true;
            this.lblimpuesto.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimpuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblimpuesto.Location = new System.Drawing.Point(520, 58);
            this.lblimpuesto.Name = "lblimpuesto";
            this.lblimpuesto.Size = new System.Drawing.Size(79, 15);
            this.lblimpuesto.TabIndex = 9;
            this.lblimpuesto.Text = "CANTIDAD";
            // 
            // btnañadiringreso
            // 
            this.btnañadiringreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnañadiringreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            this.btnañadiringreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnañadiringreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnañadiringreso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnañadiringreso.Location = new System.Drawing.Point(15, 302);
            this.btnañadiringreso.Name = "btnañadiringreso";
            this.btnañadiringreso.Size = new System.Drawing.Size(237, 38);
            this.btnañadiringreso.TabIndex = 0;
            this.btnañadiringreso.Text = "Añadir compra";
            this.btnañadiringreso.UseVisualStyleBackColor = false;
            this.btnañadiringreso.Visible = false;
            this.btnañadiringreso.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcantidad.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(665, 58);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(136, 26);
            this.txtcantidad.TabIndex = 10;
            // 
            // lbltotal
            // 
            this.lbltotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Product Sans", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbltotal.Location = new System.Drawing.Point(56, 146);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(51, 15);
            this.lbltotal.TabIndex = 11;
            this.lbltotal.Text = "TOTAL";
            // 
            // txtprecioTot
            // 
            this.txtprecioTot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtprecioTot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.txtprecioTot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprecioTot.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecioTot.Location = new System.Drawing.Point(121, 141);
            this.txtprecioTot.Name = "txtprecioTot";
            this.txtprecioTot.Size = new System.Drawing.Size(109, 26);
            this.txtprecioTot.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 352);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "Añadir Compra";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(143)))), ((int)(((byte)(177)))));
            this.panel4.Controls.Add(this.txtFecha);
            this.panel4.Controls.Add(this.txtprecioUnit);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtarticulo);
            this.panel4.Controls.Add(this.txtidingreso);
            this.panel4.Controls.Add(this.txtcantidad);
            this.panel4.Controls.Add(this.lblimpuesto);
            this.panel4.Controls.Add(this.txtprecioTot);
            this.panel4.Controls.Add(this.lblproveedor);
            this.panel4.Controls.Add(this.txtidusuario);
            this.panel4.Controls.Add(this.lblingreso);
            this.panel4.Controls.Add(this.lblidusuario);
            this.panel4.Controls.Add(this.lblfecha);
            this.panel4.Controls.Add(this.lbltotal);
            this.panel4.Controls.Add(this.txtidproveed);
            this.panel4.Location = new System.Drawing.Point(33, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(877, 214);
            this.panel4.TabIndex = 14;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFecha.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(386, 141);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 26);
            this.txtFecha.TabIndex = 17;
            // 
            // txtprecioUnit
            // 
            this.txtprecioUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.txtprecioUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprecioUnit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecioUnit.Location = new System.Drawing.Point(666, 93);
            this.txtprecioUnit.Name = "txtprecioUnit";
            this.txtprecioUnit.Size = new System.Drawing.Size(136, 26);
            this.txtprecioUnit.TabIndex = 16;
            this.txtprecioUnit.TextChanged += new System.EventHandler(this.txtprecioUnit_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(520, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "PRECIO UNITARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "PRODUCTO";
            // 
            // txtarticulo
            // 
            this.txtarticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.txtarticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtarticulo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtarticulo.Location = new System.Drawing.Point(121, 57);
            this.txtarticulo.Name = "txtarticulo";
            this.txtarticulo.Size = new System.Drawing.Size(100, 26);
            this.txtarticulo.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.bunifuFlatButton1);
            this.panel3.Controls.Add(this.btnAñadirCompra);
            this.panel3.Controls.Add(this.btnañadiringreso);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(969, 389);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 352);
            this.panel3.TabIndex = 14;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 3;
            this.bunifuFlatButton1.ButtonText = "CANCELAR";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.SystemColors.Highlight;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(33, 203);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(200, 88);
            this.bunifuFlatButton1.TabIndex = 7;
            this.bunifuFlatButton1.Text = "CANCELAR";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnAñadirCompra
            // 
            this.btnAñadirCompra.Activecolor = System.Drawing.Color.Transparent;
            this.btnAñadirCompra.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAñadirCompra.BorderRadius = 3;
            this.btnAñadirCompra.ButtonText = "Añadir Compra";
            this.btnAñadirCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadirCompra.DisabledColor = System.Drawing.SystemColors.Highlight;
            this.btnAñadirCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirCompra.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAñadirCompra.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAñadirCompra.Iconimage")));
            this.btnAñadirCompra.Iconimage_right = null;
            this.btnAñadirCompra.Iconimage_right_Selected = null;
            this.btnAñadirCompra.Iconimage_Selected = null;
            this.btnAñadirCompra.IconMarginLeft = 0;
            this.btnAñadirCompra.IconMarginRight = 0;
            this.btnAñadirCompra.IconRightVisible = true;
            this.btnAñadirCompra.IconRightZoom = 0D;
            this.btnAñadirCompra.IconVisible = true;
            this.btnAñadirCompra.IconZoom = 90D;
            this.btnAñadirCompra.IsTab = false;
            this.btnAñadirCompra.Location = new System.Drawing.Point(33, 77);
            this.btnAñadirCompra.Name = "btnAñadirCompra";
            this.btnAñadirCompra.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAñadirCompra.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAñadirCompra.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAñadirCompra.selected = false;
            this.btnAñadirCompra.Size = new System.Drawing.Size(200, 88);
            this.btnAñadirCompra.TabIndex = 6;
            this.btnAñadirCompra.Text = "Añadir Compra";
            this.btnAñadirCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadirCompra.Textcolor = System.Drawing.Color.White;
            this.btnAñadirCompra.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirCompra.Click += new System.EventHandler(this.btnAñadirCompra_Click);
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1224, 741);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCompras";
            this.Text = "FrmCompras";
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompras)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcompras;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblingreso;
        private System.Windows.Forms.TextBox txtidingreso;
        private System.Windows.Forms.Label lblproveedor;
        private System.Windows.Forms.TextBox txtidproveed;
        private System.Windows.Forms.Label lblidusuario;
        private System.Windows.Forms.TextBox txtidusuario;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblimpuesto;
        private System.Windows.Forms.Button btnañadiringreso;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtprecioTot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtarticulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprecioUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFecha;
        private Bunifu.Framework.UI.BunifuFlatButton btnAñadirCompra;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}