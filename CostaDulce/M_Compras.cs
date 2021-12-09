using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaDulce
{
    public class M_Compas
    {
        BdComun cn = new BdComun();
        public DataTable MostrarDatos()
        {
            SqlDataAdapter da = new SqlDataAdapter("Mostrar_Compras", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
