using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using CostaDulce.Properties;

namespace CostaDulce
{
    public partial class FrmPuntoDeVenta : Form
    {
        SqlConnection connection = new SqlConnection("server=localhost;database=Ventas;integrated security=true");

        //private Usuario usuario
        public FrmPuntoDeVenta()
        {
            //(oUsuario=null)
            //usuario = oUsuario();
            InitializeComponent();

        }

        private void FrmPuntoDeVenta_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en conexión");
            }
            //----------------------------------

            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtIdProducto.Text = "";

            txtPagaCon.Text = "";
            txtCambio.Text = "";
            txtTotalAPagar.Text = "0";
            txtCantidad.Text = "1";
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {

        }

        private void txtIdProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtIdProducto.Text == "0")
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (e.KeyData == Keys.Enter)
            {

                SqlCommand command = new SqlCommand(
                    "select producto from ventasProductos where idProducto = " + txtIdProducto.Text + ";", connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();

                txtProducto.Text = reader.GetString(0);

                reader.Close();

                command = new SqlCommand("select precioUnit from ventasProductos where idProducto = " + txtIdProducto.Text + ";", connection);
                reader = command.ExecuteReader();
                reader.Read();

                txtPrecio.Text = reader.GetInt32(0).ToString();

                reader.Close();

                command = new SqlCommand("select stock from ventasProductos where idProducto = " + txtIdProducto.Text + ";", connection);
                reader = command.ExecuteReader();
                reader.Read();

                txtStock.Text = reader.GetInt32(0).ToString();
                reader.Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool producto_existe = false;

            if (int.Parse(txtIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Precio - formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecio.Select();
                return;
            }

            if (Convert.ToInt32(txtStock.Text) < Convert.ToInt32(txtCantidad.Value.ToString()))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            dataGridView1.Rows.Add(new object[]{
            txtIdProducto.Text,
            txtProducto.Text,
            precio.ToString("0.00"),
            txtCantidad.Value.ToString(),
            (txtCantidad.Value * precio).ToString("0.00")
            });

            calcularTotal();
            limpiarProducto();
        }

        private void calcularTotal()
        {
            decimal total = 0;

            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
            }
            txtTotalAPagar.Text = total.ToString("0.00");
        }

        private void limpiarProducto()
        {
            txtIdProducto.Text = "0";
            txtProducto.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtCantidad.Text = "1";
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = 50;
                var h = 100;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Left + (e.CellBounds.Height - h) / 2;

                //e.Graphics.DrawImage(Properties.Resources.borrar, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    dataGridView1.Rows.RemoveAt(index);
                    calcularTotal();
                }
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (txtPrecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
            {
                e.Handled = true;
            }
            else
                if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPagaCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (txtPrecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
            {
                e.Handled = true;
            }
            else
                if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void calcularCambio()
        {
            if (txtTotalAPagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            decimal pagaCon;
            decimal total = Convert.ToDecimal(txtTotalAPagar.Text);

            if (txtPagaCon.Text.Trim() == "")
            {
                txtPagaCon.Text = "0";
            }

            if (decimal.TryParse(txtPagaCon.Text.Trim(), out pagaCon))
            {
                if (pagaCon < total)
                {
                    txtCambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagaCon - total;
                    txtCambio.Text = cambio.ToString("0.00");
                }
            }
        }

        private void txtPagaCon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularCambio();
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {

            for (int i = 0; i <= dataGridView1.RowCount; i++)
                //if (index >= 0)
                dataGridView1.Rows.RemoveAt(i);
        }

    }
}