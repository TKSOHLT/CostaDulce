using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidad;

namespace Capa_Datos
{
    public class ClassDatos
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cdl"].ConnectionString);
        public DataTable D_Listar_Productos()
        {
            SqlCommand cmd = new SqlCommand("listar_Productos", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Buscar_Productos(ClassEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("buscar_Producto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", obje.Nombre_Producto);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public String D_mantenimiento_Productos(ClassEntidad obje)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("mantenimiento_Producto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_Producto", obje.ID_Producto);
            cmd.Parameters.AddWithValue("@Nombre_Producto", obje.Nombre_Producto);
            cmd.Parameters.AddWithValue("@PrecioCompra", obje.PrecioCompra);
            cmd.Parameters.AddWithValue("@PrecioVenta", obje.PrecioVenta);
            cmd.Parameters.AddWithValue("@CantidadUnidades", obje.CantidadUnidades);
            cmd.Parameters.AddWithValue("@Tipo", obje.Tipo);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;
        }
        //====================================================================================
        public DataTable D_Listar_Empleados()
        {
            SqlCommand cmd = new SqlCommand("listar_Empleados", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Buscar_Empleados(ClassEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("buscar_Empleado", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre_E", obje.Nombre_E);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public String D_mantenimiento_Empleados(ClassEntidad obje)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("mantenimiento_Empleado", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_Empleado", obje.ID_Empleado);
            cmd.Parameters.AddWithValue("@Nombre_E", obje.Nombre_E);
            cmd.Parameters.AddWithValue("@ApellidoP_E", obje.ApellidoP_E);
            cmd.Parameters.AddWithValue("@ApellidoM_E", obje.ApellidoM_E);
            cmd.Parameters.AddWithValue("@Edad", obje.Edad);
            cmd.Parameters.AddWithValue("@Salario", obje.Salario);
            cmd.Parameters.AddWithValue("@Direccion", obje.Direccion);
            cmd.Parameters.AddWithValue("@Telefono", obje.Telefono);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;
        }
        //===================================================================================================
        public DataTable D_Listar_Proveedor()
        {
            SqlCommand cmd = new SqlCommand("listar_Proveedor", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Buscar_Proveedor(ClassEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("buscar_Proveedor", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre_E", obje.Nombre_E);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public String D_mantenimiento_Proveedor(ClassEntidad obje)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("mantenimiento_Proveedor", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_Proveedor", obje.ID_Proveedor);
            cmd.Parameters.AddWithValue("@Nombre_P", obje.Nombre_P);
            cmd.Parameters.AddWithValue("@ApellidoP_P", obje.ApellidoP_P);
            cmd.Parameters.AddWithValue("@ApellidoM_P", obje.ApellidoM_P);
            cmd.Parameters.AddWithValue("@ID_Producto", obje.ID_Producto);
            cmd.Parameters.AddWithValue("@Direccion", obje.Direccion);
            cmd.Parameters.AddWithValue("@Telefono", obje.Telefono);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;
        }
    }



}

