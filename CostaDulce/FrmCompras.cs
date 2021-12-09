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
            DateTime fecha = new DateTime(2021, 12, 06);

            string query = "INSERT INTO Compra (articulo, id_Ingreso, id_Proveed, id_Usuario, cantidad, fecha, precioUnit, precioTot) VALUES (@articulo, @id_Ingreso, @id_Proveed, @id_Usuario, @cantidad, @fecha, @precioUnit, @precioTot)";
            cn.LeerCadena();
            SqlCommand comando = new SqlCommand(query, cn.LeerCadena());
            comando.Parameters.AddWithValue("@articulo", txtidingreso.Text);
            comando.Parameters.AddWithValue("@id_Ingreso", txtidingreso.Text);

            comando.Parameters.AddWithValue("@id_Proveed", txtidingreso.Text);
            comando.Parameters.AddWithValue("@id_Usuario", txtidingreso.Text);
            comando.Parameters.AddWithValue("@cantidad", txtidingreso.Text);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@precioUnit", txtidingreso.Text);
            comando.Parameters.AddWithValue("@precioTot", txtidingreso.Text);

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
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            M_Compas comp = new M_Compas();
            dgvcompras.DataSource = comp.MostrarDatos();
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
    }
}
