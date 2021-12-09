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
    public partial class FrmInventarioEmpleado : Form
    {

        ClassEntidad objent = new ClassEntidad();
        ClassNegocio objneg = new ClassNegocio();

        private Form formActivado = null;
        public FrmInventarioEmpleado()
        {
            InitializeComponent();
        }
        void mantenimiento(String accion)
        {
            objent.ID_Empleado = txtID_Empleado.Text;
            objent.Nombre_E = txtNombre.Text;
            objent.ApellidoP_E = txtApellidoP_E.Text;
            objent.ApellidoM_E = txtApellidoM_E.Text;
            objent.Edad = Convert.ToInt32(txtEdad_E.Text);
            objent.Salario = Convert.ToInt32(txtSalario_E.Text);
            objent.Direccion = txtDireccion_E.Text;
            objent.Telefono = Convert.ToInt32(txtTelefono_E.Text);
            objent.accion = accion;
            String men = objneg.N_mantenimiento_Empleados(objent);
            MessageBox.Show(men, "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        void limpiar()
        {
            txtID_Empleado.Text = "";
            txtNombre.Text = "";
            txtApellidoP_E.Text = "";
            txtApellidoM_E.Text = "";
            txtEdad_E.Text = "";
            txtSalario_E.Text = "";
            txtDireccion_E.Text = "";
            txtTelefono_E.Text = "";
            EmpledoBasedeDatos.DataSource = objneg.N_listar_Empleados();
        }

        private void Wrapper_Paint(object sender, PaintEventArgs e)
        {
            EmpledoBasedeDatos.DataSource = objneg.N_listar_Empleados();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (txtID_Empleado.Text == "")
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
            if (txtID_Empleado.Text != "")
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
            if (txtID_Empleado.Text != "")
            {
                if (MessageBox.Show("¿Deseas ELIMINAR el Empleado " + txtNombre + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("3");
                    limpiar();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                objent.Nombre_Producto = txtBuscar.Text;
                DataTable dt = new DataTable();
                dt = objneg.N_buscar_Productos(objent);
                EmpledoBasedeDatos.DataSource = dt;
            }
            else
            {
                EmpledoBasedeDatos.DataSource = objneg.N_listar_Productos();
            }
        }

        private void EmpledoBasedeDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = EmpledoBasedeDatos.CurrentCell.RowIndex;

            txtID_Empleado.Text = EmpledoBasedeDatos[0, fila].Value.ToString();
            txtNombre.Text = EmpledoBasedeDatos[1, fila].Value.ToString();
            txtApellidoP_E.Text = EmpledoBasedeDatos[2, fila].Value.ToString();
            txtApellidoM_E.Text = EmpledoBasedeDatos[3, fila].Value.ToString();
            txtEdad_E.Text = EmpledoBasedeDatos[4, fila].Value.ToString();
            txtSalario_E.Text = EmpledoBasedeDatos[5, fila].Value.ToString();
            txtDireccion_E.Text = EmpledoBasedeDatos[6, fila].Value.ToString();
            txtTelefono_E.Text = EmpledoBasedeDatos[7, fila].Value.ToString();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
