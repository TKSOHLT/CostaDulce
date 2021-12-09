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
    public partial class frmDatosUsuario : Form
    {
        public frmDatosUsuario()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void loadUserData()
        {
            lblNombreUsuario.Text = Cache.UserLoginCache.loginName;
            lblNombre.Text = Cache.UserLoginCache.name;
            lblapellido.Text = Cache.UserLoginCache.lastn;
            lblcorreo.Text = Cache.UserLoginCache.mail;
            //panel
            txtuser.Text = Cache.UserLoginCache.loginName;
            txtname.Text = Cache.UserLoginCache.name;
            txtlastn.Text = Cache.UserLoginCache.lastn;
            txtmail.Text = Cache.UserLoginCache.mail;
            txtpass.Text = Cache.UserLoginCache.password;
            txtconfpass.Text = Cache.UserLoginCache.password;
            txtcupass.Text = "";
        }
        private void initializePassEditor()
        {
            LinkEditPass.Text = "editar";
            txtpass.Enabled = false;
            txtpass.UseSystemPasswordChar = true;
            txtconfpass.Enabled = false;
            txtconfpass.UseSystemPasswordChar = true;

        }
        private void reset()
        {
            loadUserData();
            initializePassEditor();
        }
        
      
        private void frmDatosUsuario_Load(object sender, EventArgs e)
        {
            loadUserData();
            initializePassEditor();
        }

        private void btneditar_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            loadUserData();
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {

            if (txtpass.Text.Length >= 5)
            {

                if (txtpass.Text == txtconfpass.Text)
                {
                    if (txtcupass.Text == Cache.UserLoginCache.password)
                    {
                        var userModel = new UserModel(id: Cache.UserLoginCache.UserID, loginName: txtuser.Text, pass: txtpass.Text
                                                      , name: txtname.Text, lastN: txtlastn.Text, mail: txtmail.Text);
                        var result = userModel.editUsrProfile();
                        MessageBox.Show(result);
                        reset();
                        panel1.Visible = false;
                    }
                    else MessageBox.Show("CONTRASEÑA INCORRECTA");
                }
                else MessageBox.Show("LAS CONTRASEÑAS NO COINCIDEN");
            }
            else MessageBox.Show("la contraseña deber tener almenos 5 caracteres");
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            reset();
        }

        private void LinkEditPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LinkEditPass.Text == "editar")
            {
                LinkEditPass.Text = "Cancelar";
                txtpass.Enabled = true;
                txtpass.Text = "";
                txtconfpass.Enabled = true;
                txtconfpass.Text = "";
            }
            else if (LinkEditPass.Text == "Cancelar")
            {
                initializePassEditor();
                txtpass.Text = Cache.UserLoginCache.password;
                txtconfpass.Text = Cache.UserLoginCache.password;
            }
        }
    }
}
