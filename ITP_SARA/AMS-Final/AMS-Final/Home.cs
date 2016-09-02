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

namespace AMS_Final
{
    public partial class Home : MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }
        public Home(int log, String aL, String uid, String user)
        {
            LoggedIn.setInfo(log, aL, uid, user);
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            StudentAttendance st = new StudentAttendance();
            st.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            staffAttendance staff = new staffAttendance();
            staff.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            staffSalaryDetails staffSalary = new staffSalaryDetails();
            staffSalary.Show();
        }
    }
}
