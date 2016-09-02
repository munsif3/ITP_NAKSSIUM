using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdministrativeCommunicationSystem
{
    public partial class Communication : MetroForm
    {
        DataCon dc;
        public Communication()
        {
            InitializeComponent();
        }

        private void Communication_Load(object sender, EventArgs e)
        {
            dc = new DataCon();
            metroTabControl2.SelectedTab = tabPage4;
            String query = "SELECT * FROM notification";
            String query2 = "SELECT * FROM email";
            fillGrid(query, 1);
            fillGrid(query2, 2);

           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        
        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        { 
            if(!((DateTime.Compare(Convert.ToDateTime(metroDateTime1.Text), DateTime.Now)<0) || (String.IsNullOrEmpty(metroTextBox2.Text) ||(String.IsNullOrEmpty(metroTextBox13.Text) ||(String.IsNullOrEmpty(metroTextBox3.Text) ))))){
            String fd = metroDateTime1.Value.ToString("yyyy-MM-dd");
            DataCon dc1 = new DataCon();
            SqlDataReader dr = dc1.execSelect("SELECT staff_id from users where access_level like '"+metroTextBox13.Text+"'");
            List<String> rec = new List<string>();
            try
            {
                while (dr.Read())
                {
                    rec.Add((String)dr[0]);
                    //MessageBox.Show("Read :Line");
                }
            }catch(Exception ex2){
                MessageBox.Show(ex2.Message);
            }
            
            dc1.closeCon();
            
            for (int i = 0; i < rec.Count; i++ )
            {
                
                String command = "INSERT INTO notification VALUES ('" + fd + "',GETDATE(), '" + metroTextBox2.Text + "','" + metroTextBox3.Text + "','"+rec[i]+"')";
                new DataCon().execInsert(command);
                MessageBox.Show("Added");
                fillGrid("SELECT * FROM notification", 1, 1);
            }
        }else{
            MessageBox.Show("Empty or Invalid fields. Please Correct and try again!");
        
        }
        }
        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            ADMainMenu am = new ADMainMenu();
            am.Show();
            this.Hide();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            metroTabControl2.SelectedTab = tabPage3;
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {

        }

        private void htmlPanel1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click_2(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
        }

        private void metroButton6_Click_1(object sender, EventArgs e)
        {
            RecipientSelection rs = new RecipientSelection();
            rs.Show();
            this.Hide();
        }

        private void tableLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton10_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel16_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            ADMainMenu ad = new ADMainMenu();
            ad.Show();
            this.Hide();
        }

        private void fillGrid(String query, int i)
        {
            dc.openCon();
            SqlDataAdapter da = dc.selectTable(query);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(i==1){
                metroGrid1.DataSource = dt;
                DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                col.UseColumnTextForButtonValue = true;
                col.Text = "Delete";
                col.Name = "deleteUsr";
                metroGrid1.Columns.Add(col);
                dc.closeCon();
            }else{
                   metroGrid2.DataSource = dt;
                DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                col.UseColumnTextForButtonValue = true;
                col.Text = "Delete";
                col.Name = "deleteUsr";
                metroGrid2.Columns.Add(col);
                dc.closeCon();
            }
        }
        private void fillGrid(String query, int i, int j)
        {
            dc.openCon();
            SqlDataAdapter da = dc.selectTable(query);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (i == 1)
            {
                metroGrid1.DataSource = dt;
                dc.closeCon();
            }
            else
            {
                metroGrid2.DataSource = dt;
                dc.closeCon();
            }
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.Columns[e.ColumnIndex].Name == "deleteUsr")
            {
                String nid1 = metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
                int nid = 0;
                try
                {
                     nid = System.Convert.ToInt32(nid1);
                }catch(Exception e0){
                    MessageBox.Show(e0.Message);
                }
                DataCon d2 = new DataCon();
                String query = "delete from notification where nid like '" + nid + "'";
                d2.execInsert(query);
                String query2 = "SELECT * FROM notification";
                fillGrid(query2,1,2);
            } 
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM notification where subject like '%"+metroTextBox1.Text+"%'";
            fillGrid(query, 1,1);
        }

        private void metroGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid2.Columns[e.ColumnIndex].Name == "deleteUsr")
            {
                String nid1 = metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
                int id = System.Convert.ToInt32(nid1);
                DataCon d2 = new DataCon();
                String query = "delete from email where nid like '" + id + "'";
                d2.execInsert(query);
                String query2 = "SELECT * FROM email";
                fillGrid(query2, 2, 2);
            } 
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM email where subject like '%" + metroTextBox7.Text + "%'";
            fillGrid(query, 2,1);
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            if (!((DateTime.Compare(Convert.ToDateTime(metroDateTime1.Text), DateTime.Now) < 0) || (String.IsNullOrEmpty(metroTextBox2.Text) || (String.IsNullOrEmpty(metroTextBox13.Text) || (String.IsNullOrEmpty(metroTextBox3.Text) || (String.IsNullOrEmpty(metroTextBox12.Text)))))))
            {
                String fd = metroDateTime1.Value.ToString("yyyy-MM-dd");
                DataCon d3 = new DataCon();

                DataCon dc1 = new DataCon();
                SqlDataReader dr = dc1.execSelect("SELECT staff_id from users where access_level like '" + metroTextBox13.Text + "'");
                List<String> rec = new List<string>();
                try
                {
                    while (dr.Read())
                    {
                        rec.Add((String)dr[0]);
                        // MessageBox.Show("Read :Line");
                    }
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message);
                }

                dc1.closeCon();

                for (int i = 0; i < rec.Count; i++)
                {

                    String command = "UPDATE notification set date = '" + fd + "', subject = '" + metroTextBox2.Text + "', message = '" + metroTextBox3.Text + "', staff_id = '" + rec[i] + "' WHERE nid = '" + System.Convert.ToInt32(metroTextBox12.Text) + "'";
                    new DataCon().execInsert(command);
                    MessageBox.Show("Updated");
                }
                fillGrid("SELECT * from notification", 1, 1);
            }
            else {
                MessageBox.Show("Invalid or incomplete fields. Please complete and try agian.");
            }
        }
      
    }
}
