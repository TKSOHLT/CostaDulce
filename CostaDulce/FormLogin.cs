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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.btnLogin.Focus();
            this.FormBorderStyle = FormBorderStyle.None;
        }
      
        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();

            menu.Show();
            //this.Dispose();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

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
