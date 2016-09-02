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

namespace Login
{
    public partial class LogIn : MetroForm
    {
        DataCon dc;
        DataCon dc2;
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            dc = new DataCon();
            dc.openCon();
            SqlDataReader dr = dc.execSelect("SELECT * FROM tempuser");
            int counter = 0;
            while(dr.Read()){
                SignIn.setDetails((int)dr[0], (String)dr[3], (String)dr[2], (String)dr[1]);
                counter++;
            }
            if (counter == 1)
            {
                dc2 = new DataCon();
                dc2.execInsert("DELETE  FROM tempuser where lid ='" + SignIn.getLogIn() + "'");
                new Dashboard().Show();
                this.Hide();
            }
            else {
                this.Visible = true;
               }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(SignIn.LogIn(metroTextBox1.Text, metroTextBox2.Text)){
                SignIn.makeSession(metroTextBox1.Text);
                Dashboard db = new Dashboard();
                db.Show();
                this.Hide();            
            }
            else{
                MessageBox.Show("Invalid Username or password!");
            }

        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }
  
    }
}
