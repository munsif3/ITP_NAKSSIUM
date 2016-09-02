using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace performance
{
    public partial class ManageAwardsPrizes : MetroForm
    {
        DataCon dc;
        public ManageAwardsPrizes()
        {
            dc = new DataCon();
            InitializeComponent();
        }
        private void fillGrid(String query)
        {
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
        private void ManageAwardsPrizes_Load(object sender, EventArgs e)
        {
            fillGrid("SELECT * FROM prize");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton11_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            new PerformanceMenu().Show();
            this.Hide();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            fillGrid2("SELECT * FROM prize where name like '%"+metroTextBox2.Text+"%'");
        }
        private void fillGrid2(String query)
        {
            dc.openCon();

            SqlDataAdapter da = dc.selectTable(query);
            DataTable dt = new DataTable();
            da.Fill(dt);
            metroGrid1.DataSource = dt;
            dc.closeCon();
        }

        private void ManageAwardsPrizes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.Columns[e.ColumnIndex].Name == "deleteUsr")
            {
                String pid = metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
         
                DataCon d2 = new DataCon();
                String query = "delete from prize where prizeid like '"+pid+"'";
                d2.execInsert(query);
                String query2 = "SELECT * FROM prize";
                fillGrid2(query2);
            } 
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (!((String.IsNullOrEmpty(metroTextBox1.Text) || (String.IsNullOrEmpty(metroTextBox3.Text)) || (String.IsNullOrEmpty(metroTextBox4.Text) || (String.IsNullOrEmpty(metroTextBox5.Text))))))
            {
                int id = Convert.ToInt32(metroTextBox1.Text);
                float price = (float)Convert.ToDouble(metroTextBox5.Text);
                String command = "INSERT INTO prize VALUES('" + id + "', '" + metroTextBox3.Text + "', '" + metroTextBox4.Text + "', '" + price + "');";
                new DataCon().execInsert(command);
                MessageBox.Show("Added");
                fillGrid2("SELECT * FROM prize");
            }
            else {
                MessageBox.Show("Invalid or Inccomplete fields. please correct them and try again!");
            }
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            if (!((String.IsNullOrEmpty(metroTextBox1.Text) || (String.IsNullOrEmpty(metroTextBox3.Text)) || (String.IsNullOrEmpty(metroTextBox4.Text) || (String.IsNullOrEmpty(metroTextBox5.Text))))))
            {
                DataCon d3 = new DataCon();
                String command = "UPDATE prize set name='" + metroTextBox3.Text + "', price='" + Convert.ToDouble(metroTextBox5.Text) + "', sponsor = '" + metroTextBox4.Text + "' where prizeid ='" + metroTextBox1.Text + "'";
                d3.execInsert(command);
                fillGrid2("SELECT * FROM prize");
            }
            else
            {
                MessageBox.Show("Invalid or Inccomplete fields. please correct them and try again!");
            }
        }
    }
}
