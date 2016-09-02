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
    public partial class ManagePerformance : MetroForm
    {
        DataCon dc;
        public ManagePerformance()
        {
            dc = new DataCon();
            InitializeComponent();
        }

        private void ManagePerformance_Load(object sender, EventArgs e)
        {
            fillGrid("SELECT exam_id, exam_subject, class_id, admission_no, marks FROM exam_marks", 1);
        }
        private void fillGrid(String query, int i)
        {
            dc.openCon();
            SqlDataAdapter da = dc.selectTable(query);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (i == 1)
            {
                metroGrid1.DataSource = dt;
                DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                col.UseColumnTextForButtonValue = true;
                col.Text = "Delete";
                col.Name = "deleteUsr";
                metroGrid1.Columns.Add(col);
                dc.closeCon();
            }
            else if (i == 3)
            {
                metroGrid3.DataSource = dt;
                dc.closeCon();
            }
            else if (i == 4)
            {
                metroGrid4.DataSource = dt;
                dc.closeCon();
            }
            else {
                metroGrid5.DataSource = dt;
                dc.closeCon();
            }
        }
        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            new PerformanceMenu().Show();
            this.Hide();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            fillGrid("SELECT exam_id, exam_subject, class_id, admission_no, marks FROM exam_marks WHERE '" + metroComboBox2.Text + "' like '" + metroTextBox5.Text + "'", 1, 1);
        }
        private void fillGrid(String query, int i, int j)
        {
            dc.openCon();
            SqlDataAdapter da = dc.selectTable(query);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            if (i == 1)
            {
                metroGrid1.DataSource = dt;
                dc.closeCon();
            }
            else if (i == 3)
            {
                metroGrid3.DataSource = dt;
                dc.closeCon();
            }
            else if (i == 4)
            {
                metroGrid4.DataSource = dt;
                dc.closeCon();
            }
            else
            {
                metroGrid5.DataSource = dt;
                dc.closeCon();
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            fillGrid("SELECT name FROM unions WHERE president like '" + metroTextBox6.Text + "' OR v_president like '" + metroTextBox6.Text + "' OR secretary like '" + metroTextBox6.Text + "' OR treasurer like '" + metroTextBox6.Text + "'", 3, 1);
            fillGrid("SELECT name, category, position FROM competition c, participate p, applicant a WHERE c.compid = p.compid AND p.aid = a.aid AND a.studentid like '" + metroTextBox6.Text + "'", 4, 1);
            fillGrid("SELECT exam_id, exam_subject, marks FROM exam_marks e WHERE e.admission_no like '" + metroTextBox6.Text + "'", 5, 1);
        }

        private void ManagePerformance_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.Columns[e.ColumnIndex].Name == "deleteUsr")
            {
                String ex_id = metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
                String ex_sub = metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
                String ad = metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
                DataCon d2 = new DataCon();
                String query = "delete from exam_marks where exam_id like '"+ex_id+" AND exam_subject like '"+ex_sub+"' AND admission_no like '"+ad+"'";
                d2.execInsert(query);
                String query2 = "SELECT exam_id, exam_subject, class_id, admission_no, marks FROM exam_marks";
                fillGrid(query2, 1, 2);
            } 
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (!((String.IsNullOrEmpty(metroTextBox1.Text) || (String.IsNullOrEmpty(metroTextBox3.Text)) || (String.IsNullOrEmpty(metroTextBox4.Text) || (String.IsNullOrEmpty(metroTextBox7.Text)) || (String.IsNullOrEmpty(metroTextBox2.Text))))))
            {
                String command = "INSERT INTO exam_result VALUES ('" + metroTextBox1.Text + "', '" + metroTextBox7.Text + "','" + metroTextBox2.Text + "','" + metroTextBox4.Text + "','" + Convert.ToInt32(metroTextBox3.Text) + "', '" + 0 + "');";

                new DataCon().execInsert(command);

                MessageBox.Show("Added");
                fillGrid("SELECT exam_id, exam_subject, class_id, admission_no, marks from exam_marks", 1, 1);
            }
            else {
                MessageBox.Show("Invalid or Incomplete fields please complete them and try again!");
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            if (!((String.IsNullOrEmpty(metroTextBox1.Text) || (String.IsNullOrEmpty(metroTextBox3.Text)) || (String.IsNullOrEmpty(metroTextBox4.Text) || (String.IsNullOrEmpty(metroTextBox7.Text)) || (String.IsNullOrEmpty(metroTextBox2.Text))))))
            {
                DataCon d3 = new DataCon();
                String command = "UPDATE exam_result set marks='" + Convert.ToInt32(metroTextBox3.Text) + "', class_id = '" + metroTextBox2.Text + "' where exam_id='" + metroTextBox1.Text + "' AND exam_subject = '" + metroTextBox7.Text + "' AND admission_no='" + metroTextBox4.Text + "'";
                d3.execInsert(command);
                fillGrid("SELECT exam_id, exam_subject, class_id, admission_no, marks from exam_marks", 1, 1);
            }
            else {
                MessageBox.Show("Invalid or Incomplete field values. please complete and try again!");
            }
        }
    }
}
