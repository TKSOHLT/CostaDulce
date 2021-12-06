
namespace CostaDulce
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.Header = new System.Windows.Forms.Panel();
            this.lblHead = new System.Windows.Forms.Label();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sidebar = new System.Windows.Forms.Panel();
            this.btnInventario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCompras = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPuntoDeVenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Header.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(178)))));
            this.Header.Controls.Add(this.lblHead);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(200, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1224, 77);
            this.Header.TabIndex = 1;
            this.Header.Paint += new System.Windows.Forms.PaintEventHandler(this.Header_Paint);
            // 
            // lblHead
            // 
            this.lblHead.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHead.AutoEllipsis = true;
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Product Sans", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(6, 21);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(121, 43);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "INICIO";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Wrapper
            // 
            this.Wrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Wrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.Wrapper.Location = new System.Drawing.Point(200, 76);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1224, 725);
            this.Wrapper.TabIndex = 2;
            this.Wrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.Header_Paint);
            // 
            // btnExit
            // 
            this.btnExit.Activecolor = System.Drawing.Color.Transparent;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderRadius = 0;
            this.btnExit.ButtonText = "Salir";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExit.Iconimage")));
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 0;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = true;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = true;
            this.btnExit.IconZoom = 90D;
            this.btnExit.IsTab = false;
            this.btnExit.Location = new System.Drawing.Point(0, 750);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.Transparent;
            this.btnExit.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(200, 51);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Salir";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Textcolor = System.Drawing.Color.White;
            this.btnExit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 77);
            this.panel1.TabIndex = 0;
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.Sidebar.Controls.Add(this.btnExit);
            this.Sidebar.Controls.Add(this.btnPuntoDeVenta);
            this.Sidebar.Controls.Add(this.btnCompras);
            this.Sidebar.Controls.Add(this.btnInventario);
            this.Sidebar.Controls.Add(this.panel1);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(200, 801);
            this.Sidebar.TabIndex = 0;
            // 
            // btnInventario
            // 
            this.btnInventario.Activecolor = System.Drawing.Color.Transparent;
            this.btnInventario.BackColor = System.Drawing.Color.Transparent;
            this.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventario.BorderRadius = 0;
            this.btnInventario.ButtonText = "Inventario";
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.DisabledColor = System.Drawing.Color.Gray;
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInventario.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInventario.Iconimage")));
            this.btnInventario.Iconimage_right = null;
            this.btnInventario.Iconimage_right_Selected = null;
            this.btnInventario.Iconimage_Selected = null;
            this.btnInventario.IconMarginLeft = 0;
            this.btnInventario.IconMarginRight = 0;
            this.btnInventario.IconRightVisible = true;
            this.btnInventario.IconRightZoom = 0D;
            this.btnInventario.IconVisible = true;
            this.btnInventario.IconZoom = 90D;
            this.btnInventario.IsTab = false;
            this.btnInventario.Location = new System.Drawing.Point(0, 77);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Normalcolor = System.Drawing.Color.Transparent;
            this.btnInventario.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnInventario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInventario.selected = false;
            this.btnInventario.Size = new System.Drawing.Size(200, 99);
            this.btnInventario.TabIndex = 1;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Textcolor = System.Drawing.Color.White;
            this.btnInventario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Activecolor = System.Drawing.Color.Transparent;
            this.btnCompras.BackColor = System.Drawing.Color.Transparent;
            this.btnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompras.BorderRadius = 0;
            this.btnCompras.ButtonText = "Compras";
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.DisabledColor = System.Drawing.Color.Gray;
            this.btnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompras.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCompras.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCompras.Iconimage")));
            this.btnCompras.Iconimage_right = null;
            this.btnCompras.Iconimage_right_Selected = null;
            this.btnCompras.Iconimage_Selected = null;
            this.btnCompras.IconMarginLeft = 0;
            this.btnCompras.IconMarginRight = 0;
            this.btnCompras.IconRightVisible = true;
            this.btnCompras.IconRightZoom = 0D;
            this.btnCompras.IconVisible = true;
            this.btnCompras.IconZoom = 90D;
            this.btnCompras.IsTab = false;
            this.btnCompras.Location = new System.Drawing.Point(0, 176);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCompras.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCompras.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCompras.selected = false;
            this.btnCompras.Size = new System.Drawing.Size(200, 99);
            this.btnCompras.TabIndex = 0;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Textcolor = System.Drawing.Color.White;
            this.btnCompras.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnPuntoDeVenta
            // 
            this.btnPuntoDeVenta.Activecolor = System.Drawing.Color.Transparent;
            this.btnPuntoDeVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnPuntoDeVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPuntoDeVenta.BorderRadius = 0;
            this.btnPuntoDeVenta.ButtonText = "Punto de Venta";
            this.btnPuntoDeVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPuntoDeVenta.DisabledColor = System.Drawing.Color.Gray;
            this.btnPuntoDeVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPuntoDeVenta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPuntoDeVenta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPuntoDeVenta.Iconimage")));
            this.btnPuntoDeVenta.Iconimage_right = null;
            this.btnPuntoDeVenta.Iconimage_right_Selected = null;
            this.btnPuntoDeVenta.Iconimage_Selected = null;
            this.btnPuntoDeVenta.IconMarginLeft = 0;
            this.btnPuntoDeVenta.IconMarginRight = 0;
            this.btnPuntoDeVenta.IconRightVisible = true;
            this.btnPuntoDeVenta.IconRightZoom = 0D;
            this.btnPuntoDeVenta.IconVisible = true;
            this.btnPuntoDeVenta.IconZoom = 90D;
            this.btnPuntoDeVenta.IsTab = false;
            this.btnPuntoDeVenta.Location = new System.Drawing.Point(0, 275);
            this.btnPuntoDeVenta.Name = "btnPuntoDeVenta";
            this.btnPuntoDeVenta.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPuntoDeVenta.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnPuntoDeVenta.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPuntoDeVenta.selected = false;
            this.btnPuntoDeVenta.Size = new System.Drawing.Size(200, 99);
            this.btnPuntoDeVenta.TabIndex = 2;
            this.btnPuntoDeVenta.Text = "Punto de Venta";
            this.btnPuntoDeVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPuntoDeVenta.Textcolor = System.Drawing.Color.White;
            this.btnPuntoDeVenta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuntoDeVenta.Click += new System.EventHandler(this.btnPuntoDeVenta_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(255)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1424, 801);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Sidebar);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(1440, 840);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.Sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel Wrapper;
        private System.Windows.Forms.Label lblHead;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Sidebar;
        private Bunifu.Framework.UI.BunifuFlatButton btnPuntoDeVenta;
        private Bunifu.Framework.UI.BunifuFlatButton btnCompras;
        private Bunifu.Framework.UI.BunifuFlatButton btnInventario;
    }
}