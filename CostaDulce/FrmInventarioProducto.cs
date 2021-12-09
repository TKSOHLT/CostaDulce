using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Entidad;
using Capa_Negocio;


namespace CostaDulce
{
    public partial class FrmInventarioProducto : Form
    {
        private Form formActivado = null;

        ClassEntidad objent = new ClassEntidad();
        ClassNegocio objneg = new ClassNegocio();

        public FrmInventarioProducto()
        {
            InitializeComponent();
        }

        void mantenimiento(String accion)
        {
            objent.ID_Producto = txtID_Producto.Text;
            objent.Nombre_Producto = txtNombre_Producto.Text;
            objent.PrecioCompra = Convert.ToInt32(txtPrecioCompra.Text);
            objent.PrecioVenta = Convert.ToInt32(txtPrecioVenta.Text);
            objent.CantidadUnidades = Convert.ToInt32(txtCantidad.Text);
            objent.Tipo = txtTipo.Text;
            objent.accion = accion;
            String men = objneg.N_mantenimiento_Producto(objent);
            MessageBox.Show(men, "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        void limpiar()
        {
            txtNombre_Producto.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            txtCantidad.Text = "";
            txtBuscar.Text = "";
            txtTipo.Text = "";
            ProductosBasedeDatos.DataSource = objneg.N_listar_Productos();
        }

        private void Wrapper_Paint(object sender, PaintEventArgs e)
        {
            ProductosBasedeDatos.DataSource = objneg.N_listar_Productos();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (txtID_Producto.Text == "")
            {
                if (MessageBox.Show("¿Deseas REGISTRAR el producto " + txtNombre_Producto + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("1");
                    limpiar();
                }
            }

        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            if (txtID_Producto.Text != "")
            {
                if (MessageBox.Show("¿Deseas MODIFICAR el producto " + txtNombre_Producto + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("2");
                    limpiar();
                }
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (txtID_Producto.Text != "")
            {
                if (MessageBox.Show("¿Deseas ELIMINAR el producto " + txtNombre_Producto + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("3");
                    limpiar();
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                objent.Nombre_Producto = txtBuscar.Text;
                DataTable dt = new DataTable();
                dt = objneg.N_buscar_Productos(objent);
                ProductosBasedeDatos.DataSource = dt;
            }
            else
            {
                ProductosBasedeDatos.DataSource = objneg.N_listar_Productos();
            }
        }

        private void ProductosBasedeDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = ProductosBasedeDatos.CurrentCell.RowIndex;

            txtID_Producto.Text = ProductosBasedeDatos[0, fila].Value.ToString();
            txtNombre_Producto.Text = ProductosBasedeDatos[1, fila].Value.ToString();
            txtPrecioCompra.Text = ProductosBasedeDatos[2, fila].Value.ToString();
            txtPrecioVenta.Text = ProductosBasedeDatos[3, fila].Value.ToString();
            txtCantidad.Text = ProductosBasedeDatos[4, fila].Value.ToString();
            txtTipo.Text = ProductosBasedeDatos[4, fila].Value.ToString();
        }
    }
}
