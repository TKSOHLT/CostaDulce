using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostaDulce
{
    public partial class frmMenu : Form
    {
        //Variable Form para cerrar un formulario y evitar que se abran muchos a la vez
        private Form formActivado = null;
        public frmMenu()
        {
            InitializeComponent();
           //this.FormBorderStyle=FormBorderStyle.
        }

        private void FullScreen()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //  this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            
        }

        //Pantalla completa
        private void frmMenu_Load(object sender, EventArgs e)
        {
            
            FullScreen();
            LoadDataUser();
            
        }
        private void LoadDataUser()
        {
            lblnombreusuario.Text = Cache.UserLoginCache.name+" "+Cache.UserLoginCache.lastn;
        }
        //Diseño de los botones
        public void SelectingButtons(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            btnCompras.Textcolor = Color.White;
            btnInventario.Textcolor = Color.White;
            btnPuntoDeVenta.Textcolor = Color.White;
            btnExit.Textcolor = Color.White;
            btnPerfil.Textcolor = Color.White;

            sender.selected = true;

            if (sender.selected)
            {
                
                sender.Textcolor = Color.FromArgb(122, 213, 1);
            }
        }

        private void btnPuntoDeVenta_Click(object sender, EventArgs e)
        {
            //Diseño de botón
            SelectingButtons((Bunifu.Framework.UI.BunifuFlatButton) sender);
            //---
            openFormsOnWrapper(new FrmPuntoDeVenta());
            lblHead.Text = "Punto de venta";
            lblHead.Dock = DockStyle.Top;
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            //Diseño de botón
            SelectingButtons((Bunifu.Framework.UI.BunifuFlatButton)sender);
            //---
            openFormsOnWrapper(new FrmInventario());
            lblHead.Text = "Inventario";
            lblHead.Dock = DockStyle.Top;

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            //Diseño de botón
            SelectingButtons((Bunifu.Framework.UI.BunifuFlatButton)sender);
            
            //---
            openFormsOnWrapper(new FrmCompras());
            lblHead.Text = "Compras";
            lblHead.Dock = DockStyle.None;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Diseño de botón
            //---
            Application.Exit();

        }

        private void openFormsOnWrapper(Form FormHijo)
        {
            if (formActivado != null)
                formActivado.Close();
            formActivado = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.Dock = DockStyle.Fill;
            Wrapper.Controls.Add(FormHijo);
            Wrapper.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
        }

        private void Header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            SelectingButtons((Bunifu.Framework.UI.BunifuFlatButton)sender);

            //---
            openFormsOnWrapper(new frmDatosUsuario());
            lblHead.Text = "Usuarios y contraseñas";
            lblHead.Dock = DockStyle.None;
        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblnombreusuario_Click(object sender, EventArgs e)
        {

        }
    }
}
