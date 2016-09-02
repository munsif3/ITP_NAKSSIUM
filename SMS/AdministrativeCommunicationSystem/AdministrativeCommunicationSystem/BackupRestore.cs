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
    public partial class BackupRestore : MetroForm
    {
        DataCon dc;
        SqlCommand cmd;
        SqlDataReader rd;
        String sql;
        public BackupRestore()
        {
            
            dc = new DataCon();
            InitializeComponent();
        }

        private void BackupRestore_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dl = new FolderBrowserDialog();
            if(dl.ShowDialog()==DialogResult.OK){
                metroTextBox4.Text = dl.SelectedPath;
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (!((String.IsNullOrEmpty(metroTextBox4.Text) || (String.IsNullOrEmpty(metroTextBox5.Text)))))
            {
                sql = "BACKUP DATABASE bisdb TO DISK ='" + metroTextBox4.Text + "\\bisdb-" + metroTextBox5.Text + ".bak'";
                cmd = new SqlCommand(sql, dc.getCon());
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dc.closeCon();
                dc.dispCon();
                MessageBox.Show("Successfully Backed up!");
            }
            else {
                MessageBox.Show("one or more empty fields. You cannot leave them blank!");
            }
        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Backup files (*.bak)|*.bak| All Files(*.*)|*.*";
            od.FilterIndex = 0;
            if(od.ShowDialog()==DialogResult.OK){
                metroTextBox1.Text = od.FileName;
            }
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            ADMainMenu am = new ADMainMenu();
            am.Show();
            this.Hide();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            new ADMainMenu().Show();
            this.Hide();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            String command = "RESTORE DATABASE bisdb FROM DISK ='"+metroTextBox1.Text+"' WITH REPLACE";
            DataCon dc4 = new DataCon();
            dc4.openCon();
            SqlCommand cmd = new SqlCommand(command, dc4.getCon());
            dc4.closeCon();
            dc4.dispCon();
            MessageBox.Show("SuccessFully Restored");
        }
    }
}
