using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostaDulce
{
    public partial class FrmCompras : Form
    {
        BdComun cn = new BdComun();
        M_Compas comp = new M_Compas();

        string fecha = DateTime.Now.ToString("dd/MM/yyyy");
        public FrmCompras()
        {
            InitializeComponent();
           


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO Compra (articulo, id_Ingreso, id_Proveed, id_Usuario, cantidad, fecha, precioUnit, precioTot) VALUES (@articulo, @id_Ingreso, @id_Proveed, @id_Usuario, @cantidad, @fecha, @precioUnit, @precioTot)";
            cn.LeerCadena();
            SqlCommand comando = new SqlCommand(query, cn.LeerCadena());
            comando.Parameters.AddWithValue("@articulo", txtarticulo.Text);
            comando.Parameters.AddWithValue("@id_Ingreso", txtidingreso.Text);

            comando.Parameters.AddWithValue("@id_Proveed", txtidproveed.Text);
            comando.Parameters.AddWithValue("@id_Usuario", txtidusuario.Text);
            comando.Parameters.AddWithValue("@cantidad", txtcantidad.Text);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@precioUnit", txtprecioUnit.Text);
            comando.Parameters.AddWithValue("@precioTot", txtprecioTot.Text);

            try
            {
                cn.LeerCadena();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problema con la BD");
            }
            MessageBox.Show("Se han ingresado correctamente los productos");

            limpiar();
        }

        void limpiar()
        {
            txtarticulo.Text = "";
            txtidingreso.Text = "";
            txtidproveed.Text = "";
            txtidusuario.Text = "";
            txtcantidad.Text = "";
            txtprecioUnit.Text = "";
            txtprecioTot.Text = "";
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            M_Compas comp = new M_Compas();
            dgvcompras.DataSource = comp.MostrarDatos();
            txtFecha.Text = fecha;
            dgvcompras.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
           
        }

        private void dgvcompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {

        }

        private void txtprecioUnit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
