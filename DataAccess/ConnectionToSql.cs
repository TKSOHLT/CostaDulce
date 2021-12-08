using System;
using System.Configuration;

{
    public abstract class sqlConnection
    {
        private readonly string ConnectionString;
        public sqlConnection()
        {
            ConnectionString= App1.ConnectionStrings["cdl"].ConnectionString;
        }
    }
}
