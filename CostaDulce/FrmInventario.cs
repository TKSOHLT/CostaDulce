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
    public partial class FrmInventario : Form
    {
        ClassNegocio objneg = new ClassNegocio();

        private Form formActivado = null;
        public FrmInventario()
        {
            InitializeComponent();
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

        private void InventarioMenu_Click(object sender, EventArgs e)
        {
            openFormsOnWrapper(new FrmInventarioProducto());
        }

        private void EmpleadosMenu_Click(object sender, EventArgs e)
        {
            openFormsOnWrapper(new FrmInventarioEmpleado());
        }

        private void ProveedorMenu_Click(object sender, EventArgs e)
        {
            openFormsOnWrapper(new FrmInventarioProveedor());
        }

        private void Wrapper_Paint(object sender, PaintEventArgs e)
        {

            Empleados.DataSource = objneg.N_listar_Empleados();
            Productos.DataSource = objneg.N_listar_Productos();
            Proveedor.DataSource = objneg.N_listar_Proveedor();
        }
    }
}
