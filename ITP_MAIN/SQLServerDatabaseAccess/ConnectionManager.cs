using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServerDatabaseAccess
{
    public class ConnectionManager
    {
        //static SqlConnection conn;
        public static SqlConnection getConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=EMCUBE;Initial Catalog=bisdb;Persist Security Info=True;User ID=sa;Password=sa123");
                return conn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
