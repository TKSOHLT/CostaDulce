using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CostaDulce
{
    public class BdComun
    {
        public SqlConnection LeerCadena()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cdl"].ConnectionString);
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            else
            {
                cn.Close();
            }
            return cn;
        }
    }
}
