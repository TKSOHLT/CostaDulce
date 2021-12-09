using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class ClassNegocio
    {
        ClassDatos objd = new ClassDatos();
        public DataTable N_listar_Productos()
        {
            return objd.D_Listar_Productos();
        }
        public DataTable N_buscar_Productos(ClassEntidad obje)
        {
            return objd.D_Buscar_Productos(obje);
        }
        public String N_mantenimiento_Producto(ClassEntidad obje)
        {
            return objd.D_mantenimiento_Productos(obje);
        }
        //=====================================================
        public DataTable N_listar_Empleados()
        {
            return objd.D_Listar_Empleados();
        }
        public DataTable N_buscar_Empleados(ClassEntidad obje)
        {
            return objd.D_Buscar_Empleados(obje);
        }
        public String N_mantenimiento_Empleados(ClassEntidad obje)
        {
            return objd.D_mantenimiento_Empleados(obje);
        }
        //======================================================
        public DataTable N_listar_Proveedor()
        {
            return objd.D_Listar_Proveedor();
        }
        public DataTable N_buscar_Proveedor(ClassEntidad obje)
        {
            return objd.D_Buscar_Proveedor(obje);
        }
        public String N_mantenimiento_Proveedor(ClassEntidad obje)
        {
            return objd.D_mantenimiento_Proveedor(obje);
        }
    }
}
