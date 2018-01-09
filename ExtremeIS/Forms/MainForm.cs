using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtremeIS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {

            InitializeComponent();
        }
        

        private void btnDailyTicket_Click(object sender, EventArgs e)
        {
            var dailyTicket = new DailyTicketForm();
            dailyTicket.Show();
        }


        private void btnMemberLogin_Click(object sender, EventArgs e)
        {
            var memberCheckIn = new MemberCheckIn();
            memberCheckIn.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
