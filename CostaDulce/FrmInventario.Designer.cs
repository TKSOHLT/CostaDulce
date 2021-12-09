
namespace CostaDulce
{
    partial class FrmInventario
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
            this.Wrapper = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Productos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Empleados = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Proveedor = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InventarioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpleadosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ProveedorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Wrapper.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Productos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Empleados)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Proveedor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wrapper
            // 
            this.Wrapper.Controls.Add(this.groupBox2);
            this.Wrapper.Controls.Add(this.groupBox1);
            this.Wrapper.Controls.Add(this.groupBox5);
            this.Wrapper.Controls.Add(this.menuStrip1);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(0, 0);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1224, 741);
            this.Wrapper.TabIndex = 3;
            this.Wrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.Wrapper_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.Productos);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(50, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1032, 156);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "-PRODUCTOS-";
            // 
            // Productos
            // 
            this.Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Productos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Productos.Location = new System.Drawing.Point(6, 25);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(1020, 111);
            this.Productos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.Empleados);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1032, 165);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "-EMPLEADO-";
            // 
            // Empleados
            // 
            this.Empleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Empleados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Empleados.Location = new System.Drawing.Point(6, 25);
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(1020, 114);
            this.Empleados.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox5.Controls.Add(this.Proveedor);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(50, 405);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1032, 165);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "-PROVEEDOR-";
            // 
            // Proveedor
            // 
            this.Proveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Proveedor.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Proveedor.Location = new System.Drawing.Point(6, 27);
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Size = new System.Drawing.Size(1020, 114);
            this.Proveedor.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InventarioMenu,
            this.EmpleadosMenu,
            this.ProveedorMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1224, 35);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // InventarioMenu
            // 
            this.InventarioMenu.Name = "InventarioMenu";
            this.InventarioMenu.Size = new System.Drawing.Size(129, 31);
            this.InventarioMenu.Text = "Inventario";
            this.InventarioMenu.Click += new System.EventHandler(this.InventarioMenu_Click);
            // 
            // EmpleadosMenu
            // 
            this.EmpleadosMenu.Name = "EmpleadosMenu";
            this.EmpleadosMenu.Size = new System.Drawing.Size(140, 31);
            this.EmpleadosMenu.Text = "Empleados";
            this.EmpleadosMenu.Click += new System.EventHandler(this.EmpleadosMenu_Click);
            // 
            // ProveedorMenu
            // 
            this.ProveedorMenu.Name = "ProveedorMenu";
            this.ProveedorMenu.Size = new System.Drawing.Size(155, 31);
            this.ProveedorMenu.Text = "Proveedores";
            this.ProveedorMenu.Click += new System.EventHandler(this.ProveedorMenu_Click);
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 741);
            this.ControlBox = false;
            this.Controls.Add(this.Wrapper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInventario";
            this.Text = "FrmCompras";
            this.Wrapper.ResumeLayout(false);
            this.Wrapper.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Productos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Empleados)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Proveedor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Wrapper;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InventarioMenu;
        private System.Windows.Forms.ToolStripMenuItem EmpleadosMenu;
        private System.Windows.Forms.ToolStripMenuItem ProveedorMenu;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView Proveedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Empleados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Productos;
    }
}