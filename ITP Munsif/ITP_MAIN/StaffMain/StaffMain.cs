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

namespace StaffMain
{
    public partial class StaffMain : MetroForm
    {
        public StaffMain()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            var staffDet = new StaffDetail();
            staffDet.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            var vacancy = new Vacancy();
            vacancy.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            var leave = new LeaveRequest();
            leave.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            var pay = new Payroll();
            pay.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            var report = new Report();
            report.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
