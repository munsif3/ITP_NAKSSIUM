using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SQLServerDatabaseAccess;
using System.Windows.Forms;

namespace performance
{
    class DataCon
    {
         private SqlConnection sc;

        public DataCon() {
            sc = ConnectionManager.getConnection();
             //sc = new SqlConnection("Data Source=IHSANIZWER-PC\\IHSANSERVER;Initial Catalog=bisdb;Integrated Security=True");
             sc.Open();
        }

        
        public SqlDataReader execSelect(String query) {
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = sc;
            SqlDataReader dr = null;

            try { 
                dr = cmd.ExecuteReader();
            }catch(Exception e){
                MessageBox.Show(e.Message);
            }

            return dr;
        }

        public SqlDataAdapter selectTable(String query) {
            SqlCommand cmd = sc.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            try
            {
                cmd.ExecuteNonQuery();
            }catch(Exception ep){
                MessageBox.Show(ep.Message);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            return da;
        }

        public void execInsert(String command) {
            SqlCommand cmd = sc.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = command;
            try
            {
                cmd.ExecuteNonQuery();
            }catch(SqlException e1){
                if (e1.Number == 2627)
                    MessageBox.Show("There is already a record in the database with the same ID. Enter a different one.");
                else
                    MessageBox.Show(e1.Message);
            }
            closeCon();
        }

        public void openCon() {
            if (sc.State.ToString() == "Closed")
            {
                sc.Open();
            }
        }
        public void closeCon() {
            sc.Close();
        }

        public void dispCon() {
            sc.Dispose();
        }

        public SqlConnection getCon() {
            return sc;
        }
    }
    
}
