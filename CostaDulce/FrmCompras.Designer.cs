
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtprecioTot = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtarticulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprecioUnit = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
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
            this.lblingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblingreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblingreso.Location = new System.Drawing.Point(142, 72);
            this.lblingreso.Name = "lblingreso";
            this.lblingreso.Size = new System.Drawing.Size(95, 16);
            this.lblingreso.TabIndex = 0;
            this.lblingreso.Text = "ID INGRESO";
            // 
            // txtidingreso
            // 
            this.txtidingreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtidingreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.txtidingreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidingreso.Location = new System.Drawing.Point(145, 97);
            this.txtidingreso.Name = "txtidingreso";
            this.txtidingreso.Size = new System.Drawing.Size(92, 20);
            this.txtidingreso.TabIndex = 1;
            // 
            // lblproveedor
            // 
            this.lblproveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblproveedor.AutoSize = true;
            this.lblproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblproveedor.Location = new System.Drawing.Point(257, 72);
            this.lblproveedor.Name = "lblproveedor";
            this.lblproveedor.Size = new System.Drawing.Size(122, 16);
            this.lblproveedor.TabIndex = 2;
            this.lblproveedor.Text = "ID PROVEEDOR";
            this.lblproveedor.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtidproveed
            // 
            this.txtidproveed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtidproveed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.txtidproveed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidproveed.Location = new System.Drawing.Point(260, 97);
            this.txtidproveed.Name = "txtidproveed";
            this.txtidproveed.Size = new System.Drawing.Size(119, 20);
            this.txtidproveed.TabIndex = 3;
            // 
            // lblidusuario
            // 
            this.lblidusuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblidusuario.AutoSize = true;
            this.lblidusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblidusuario.Location = new System.Drawing.Point(392, 72);
            this.lblidusuario.Name = "lblidusuario";
            this.lblidusuario.Size = new System.Drawing.Size(95, 16);
            this.lblidusuario.TabIndex = 4;
            this.lblidusuario.Text = "ID USUARIO";
            // 
            // txtidusuario
            // 
            this.txtidusuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtidusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.txtidusuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidusuario.Location = new System.Drawing.Point(395, 97);
            this.txtidusuario.Name = "txtidusuario";
            this.txtidusuario.Size = new System.Drawing.Size(109, 20);
            this.txtidusuario.TabIndex = 5;
            // 
            // lblfecha
            // 
            this.lblfecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblfecha.Location = new System.Drawing.Point(142, 132);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(58, 16);
            this.lblfecha.TabIndex = 6;
            this.lblfecha.Text = "FECHA";
            // 
            // lblimpuesto
            // 
            this.lblimpuesto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblimpuesto.AutoSize = true;
            this.lblimpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimpuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblimpuesto.Location = new System.Drawing.Point(518, 72);
            this.lblimpuesto.Name = "lblimpuesto";
            this.lblimpuesto.Size = new System.Drawing.Size(85, 16);
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
            this.btnañadiringreso.Location = new System.Drawing.Point(15, 101);
            this.btnañadiringreso.Name = "btnañadiringreso";
            this.btnañadiringreso.Size = new System.Drawing.Size(237, 38);
            this.btnañadiringreso.TabIndex = 0;
            this.btnañadiringreso.Text = "Añadir compra";
            this.btnañadiringreso.UseVisualStyleBackColor = false;
            this.btnañadiringreso.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcantidad.Location = new System.Drawing.Point(521, 97);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(109, 20);
            this.txtcantidad.TabIndex = 10;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncancelar.Location = new System.Drawing.Point(15, 174);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(237, 38);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbltotal.Location = new System.Drawing.Point(784, 72);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(57, 16);
            this.lbltotal.TabIndex = 11;
            this.lbltotal.Text = "TOTAL";
            // 
            // txtprecioTot
            // 
            this.txtprecioTot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtprecioTot.BackColor = System.Drawing.Color.AliceBlue;
            this.txtprecioTot.Location = new System.Drawing.Point(787, 97);
            this.txtprecioTot.Name = "txtprecioTot";
            this.txtprecioTot.Size = new System.Drawing.Size(109, 20);
            this.txtprecioTot.TabIndex = 12;
            // 
            // panel1
            // 
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(153)))), ((int)(((byte)(220)))));
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
            this.panel4.Size = new System.Drawing.Size(930, 214);
            this.panel4.TabIndex = 14;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btncancelar);
            this.panel3.Controls.Add(this.btnañadiringreso);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(969, 389);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 352);
            this.panel3.TabIndex = 14;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtarticulo
            // 
            this.txtarticulo.Location = new System.Drawing.Point(25, 96);
            this.txtarticulo.Name = "txtarticulo";
            this.txtarticulo.Size = new System.Drawing.Size(100, 20);
            this.txtarticulo.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "PRODUCTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(638, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "PRECIO UNITARIO";
            // 
            // txtprecioUnit
            // 
            this.txtprecioUnit.Location = new System.Drawing.Point(642, 97);
            this.txtprecioUnit.Name = "txtprecioUnit";
            this.txtprecioUnit.Size = new System.Drawing.Size(136, 20);
            this.txtprecioUnit.TabIndex = 16;
            this.txtprecioUnit.TextChanged += new System.EventHandler(this.txtprecioUnit_TextChanged);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(145, 152);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 17;
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
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
        private System.Windows.Forms.Button btncancelar;
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
    }
}