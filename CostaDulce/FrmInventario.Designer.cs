
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InventarioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpleadosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ProveedorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Wrapper.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wrapper
            // 
            this.Wrapper.Controls.Add(this.menuStrip1);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(0, 0);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1224, 741);
            this.Wrapper.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InventarioMenu,
            this.EmpleadosMenu,
            this.ProveedorMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1224, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // InventarioMenu
            // 
            this.InventarioMenu.Name = "InventarioMenu";
            this.InventarioMenu.Size = new System.Drawing.Size(72, 20);
            this.InventarioMenu.Text = "Inventario";
            this.InventarioMenu.Click += new System.EventHandler(this.InventarioMenu_Click);
            // 
            // EmpleadosMenu
            // 
            this.EmpleadosMenu.Name = "EmpleadosMenu";
            this.EmpleadosMenu.Size = new System.Drawing.Size(77, 20);
            this.EmpleadosMenu.Text = "Empleados";
            this.EmpleadosMenu.Click += new System.EventHandler(this.EmpleadosMenu_Click);
            // 
            // ProveedorMenu
            // 
            this.ProveedorMenu.Name = "ProveedorMenu";
            this.ProveedorMenu.Size = new System.Drawing.Size(84, 20);
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
    }
}