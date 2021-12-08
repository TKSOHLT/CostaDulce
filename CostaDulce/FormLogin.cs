using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Text;
namespace CostaDulce
{
    public partial class frmLogin : Form
    {
        bool alreadyFocused;
        
        public frmLogin()
        {
            InitializeComponent();
            this.btnLogin.Focus();
            this.FormBorderStyle = FormBorderStyle.None;
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(15, 15, this.Width, this.Height, 40, 40);
            this.Region = System.Drawing.Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);
            txtPassword.GotFocus += textBox1_GotFocus;
            txtPassword.MouseUp+= textBox1_MouseUp;
            txtPassword.Leave += textBox1_Leave;
            txtUser.GotFocus += textBox2_GotFocus;
            txtUser.MouseUp += textBox2_MouseUp;
            txtUser.Leave += textBox2_Leave;

        }
      
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "Ingrese usuario")
            {
                if (txtPassword.Text != "Ingrese contraseña")
                {
                    UserModel user = new UserModel();
                    var LoginValido = user.LoginUser(txtUser.Text,txtPassword.Text);
                    if (LoginValido == true)
                    {
                        frmMenu menu = new frmMenu();
                        menu.Show();
                        this.Hide();
                    }
                    else { msError("Nombre de usuario o contraseña incorrectos.\n      Intente de nuevo...");
                        txtPassword.Clear();
                        txtUser.Clear();
                        txtUser.Focus();
                    }

                }
                else msError("PORFAVOR INGRESE LA CONTRASEÑA");
            }
            else msError("PORFAVOR INGRESE EL NOMBRE DE USUARIO");
            //logins();
            //this.Dispose();

        }
        private void msError(String msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }
        public void logins()
        {
            try
            {
                string cdl = ConfigurationManager.ConnectionStrings["cdl"].ConnectionString;
               
                using(SqlConnection conexion =new SqlConnection(cdl))
                {
                  conexion.Open();
                  SqlCommand cmd = new SqlCommand("SELECT NombreUsuario, password FROM costaDulce.dbo.Users WHERE NombreUsuario=@vusuario AND password= @vcontrasena", conexion);
                    
                        cmd.Parameters.AddWithValue("vusuario", txtUser.Text);
                        cmd.Parameters.AddWithValue("vcontrasena", txtPassword.Text);

                    SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("conectado");
                            frmMenu menu = new frmMenu();

                            menu.Show();
                        }
                        else
                            MessageBox.Show("FATAL: NO CONECTADO");
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            /*
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"C:\ProductSans-Regular.ttf");
            foreach(Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
            }
            */
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture();
                NativeMethods.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
        void textBox1_Leave(object sender, EventArgs e) { 
            alreadyFocused = false;
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "Ingrese contraseña";
                txtPassword.UseSystemPasswordChar = false;

            }
        }
        void textBox1_GotFocus(object sender, EventArgs e)
        { // Select all text only if the mouse isn't down. 
            // This makes tabbing to the textbox give focus.
            if (MouseButtons == MouseButtons.None) { this.txtPassword.SelectAll(); alreadyFocused = true; } 
        }
        void textBox1_MouseUp(object sender, MouseEventArgs e)
        { // Web browsers like Google Chrome select the text on mouse up.
          // They only do it if the textbox isn't already focused, 
          // and if the user hasn't selected all text.
            if (!alreadyFocused && this.txtPassword.SelectionLength == 0) { alreadyFocused = true; this.txtPassword.SelectAll(); }

        }
        void textBox2_Leave(object sender, EventArgs e)
        {
            alreadyFocused = false;
            if (txtUser.Text.Equals(""))
            {
                txtUser.Text = "Ingrese usuario";
               
            }
        }
        void textBox2_GotFocus(object sender, EventArgs e)
        { 
            if (MouseButtons == MouseButtons.None) { this.txtUser.SelectAll(); alreadyFocused = true; }
        }
        void textBox2_MouseUp(object sender, MouseEventArgs e)
        { 
            if (!alreadyFocused && this.txtUser.SelectionLength == 0) { alreadyFocused = true; this.txtUser.SelectAll(); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var recoverPassword = new OlvideContraseña();
            recoverPassword.ShowDialog();
        }
    }
}
public class NativeMethods
{
    [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    public static extern System.IntPtr CreateRoundRectRgn
     (
      int nLeftRect, // x-coordinate of upper-left corner
      int nTopRect, // y-coordinate of upper-left corner
      int nRightRect, // x-coordinate of lower-right corner
      int nBottomRect, // y-coordinate of lower-right corner
      int nWidthEllipse, // height of ellipse
      int nHeightEllipse // width of ellipse
     );

    [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
    public static extern bool DeleteObject(System.IntPtr hObject);
    [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
    public static extern bool ReleaseCapture();

    [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
}
