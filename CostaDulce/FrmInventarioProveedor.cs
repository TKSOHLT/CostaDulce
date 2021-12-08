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
    public partial class FrmInventarioProveedor : Form
    {
        private Form formActivado = null;
        private void InventarioMenu_Click(object sender, EventArgs e)
        {

        }

        ClassEntidad objent = new ClassEntidad();
        ClassNegocio objneg = new ClassNegocio();
        public FrmInventarioProveedor()
        {
            InitializeComponent(); 
        }

        void mantenimiento(String accion)
        {
            objent.ID_Proveedor = txtID.Text;
            objent.Nombre_P = txtNombre.Text;
            objent.ApellidoP_P = txtApellidoP_P.Text;
            objent.ApellidoM_P = txtApellidoM_P.Text;
            objent.ID_Producto = txtID_Producto.Text;
            objent.Direccion = txtDireccion.Text;
            objent.Telefono = Convert.ToInt32(txtTelefono.Text);
            objent.accion = accion;
            String men = objneg.N_mantenimiento_Producto(objent);
            MessageBox.Show(men, "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        void limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtApellidoP_P.Text = "";
            txtApellidoM_P.Text = "";
            txtID_Producto.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text="";
            ProveedorBasedeDatos.DataSource = objneg.N_listar_Proveedor();
        }
        private void Wrapper_Paint(object sender, PaintEventArgs e)
        {
            ProveedorBasedeDatos.DataSource = objneg.N_listar_Proveedor();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                if (MessageBox.Show("¿Deseas REGISTRAR " + txtNombre + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("1");
                    limpiar();
                }
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("¿Deseas MODIFICAR el Empleado " + txtNombre + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("2");
                    limpiar();
                }
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if(txtID.Text != "")
            {
                if (MessageBox.Show("¿Deseas ELIMINAR el Empleado " + txtNombre + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("3");
                    limpiar();
                }
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                objent.Nombre_Producto = txtBuscar.Text;
                DataTable dt = new DataTable();
                dt = objneg.N_buscar_Productos(objent);
                ProveedorBasedeDatos.DataSource = dt;
            }
            else
            {
                ProveedorBasedeDatos.DataSource = objneg.N_listar_Productos();
            }
        }

        private void ProveedorBasedeDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = ProveedorBasedeDatos.CurrentCell.RowIndex;

            txtID.Text = ProveedorBasedeDatos[0, fila].Value.ToString();
            txtNombre.Text = ProveedorBasedeDatos[1, fila].Value.ToString();
            txtApellidoP_P.Text = ProveedorBasedeDatos[2, fila].Value.ToString();
            txtApellidoM_P.Text = ProveedorBasedeDatos[3, fila].Value.ToString();
            txtID_Producto.Text = ProveedorBasedeDatos[4, fila].Value.ToString();
            txtDireccion.Text = ProveedorBasedeDatos[5, fila].Value.ToString();
            txtTelefono.Text = ProveedorBasedeDatos[6, fila].Value.ToString();
        }
    }
}
