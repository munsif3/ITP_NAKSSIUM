using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministrativeCommunicationSystem
{
    public partial class ManageUsers : MetroForm
    {
        DataCon dc;
        String defQuery;
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
             dc = new DataCon();
             String defQuery = "SELECT * FROM users";
             fillGrid(defQuery);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            ADMainMenu am = new ADMainMenu();
            am.Show();
            this.Hide();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            new ADMainMenu().Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void fillGrid(String query) {
            dc.openCon();
            
            SqlDataAdapter da = dc.selectTable(query);
            DataTable dt = new DataTable();
            da.Fill(dt);
            metroGrid1.DataSource = dt;
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Delete";
            col.Name = "deleteUsr";
            metroGrid1.Columns.Add(col);
            dc.closeCon();
        }
        private void fillGrid2(String query)
        {
            dc.openCon();

            SqlDataAdapter da = dc.selectTable(query);
            DataTable dt = new DataTable();
            da.Fill(dt);
            metroGrid1.DataSource = dt;
            /*DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Delete";
            col.Name = "deleteUsr";
            metroGrid1.Columns.Add(col);*/
            dc.closeCon();
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.Columns[e.ColumnIndex].Name == "deleteUsr")
            {
                String username = metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
                DataCon d2 = new DataCon();
                String query = "delete from users where username like '"+username+"'";
                d2.execInsert(query);
            } 
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM users where  username like '%"+metroTextBox1.Text+"%'";
            fillGrid2(query);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if(!((String.IsNullOrEmpty(metroTextBox2.Text) ||(String.IsNullOrEmpty(metroTextBox3.Text)) || (String.IsNullOrEmpty(metroTextBox4.Text) || (String.IsNullOrEmpty(metroTextBox5.Text)))))){
                DataCon dc2 = new DataCon();
                String command = "INSERT INTO users VALUES('"+metroTextBox2.Text+"', '"+Security.Encript(metroTextBox3.Text)+"', '"+metroTextBox5.Text+"',NULL, '"+metroTextBox4.Text+"');";
                dc2.execInsert(command);
                fillGrid("SELECT * FROM users");
            }else{
                MessageBox.Show("One or more fields are left empty. Please enter and try again!");
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (!((String.IsNullOrEmpty(metroTextBox2.Text)) || (String.IsNullOrEmpty(metroTextBox3.Text)) || (String.IsNullOrEmpty(metroTextBox4.Text)) || (String.IsNullOrEmpty(metroTextBox5.Text))))
            {
                DataCon d3 = new DataCon();
                String command = "UPDATE users set password = '" + Security.Encript(metroTextBox3.Text) + "', access_level = '" + metroTextBox5.Text + "', staff_id = '" + metroTextBox4.Text + "' where username like '" + metroTextBox2.Text + "'";
                d3.execInsert(command);
                fillGrid("SELECT * FROM users");
            }
            else {
                MessageBox.Show("One or More fields left empty. Please enter and try again!");
            }
        }
    }


}
