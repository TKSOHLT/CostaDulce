using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class ClassEntidad
    {
        public String ID_Producto { get; set; }
        public String Nombre_Producto { get; set; }
        public float PrecioCompra { get; set; }
        public float PrecioVenta { get; set; }
        public int CantidadUnidades { get; set; }
        public String Tipo { get; set; }
        public String accion { get; set; }
//========================================================================        
        public String ID_Empleado { get; set; }
        public String Nombre_E { get; set; }
        public String ApellidoP_E { get; set; }
        public String ApellidoM_E { get; set; }
        public int Edad { get; set; }
        public String Direccion { get; set; }
        public int Telefono { get; set; }
        public float Salario { get; set; }

        //==========================================================================
        public String ID_Proveedor { get; set; }
        public String Nombre_P { get; set; }
        public String ApellidoP_P { get; set; }
        public String ApellidoM_P { get; set; }

    }
}
