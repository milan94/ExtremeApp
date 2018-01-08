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

        private void lblFeeMonth_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxFreeOfCharge_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDailyTicket_Click(object sender, EventArgs e)
        {
            var dailyTicket = new DailyTicketForm();
            dailyTicket.Show();
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            var newMember = new AddMemberForm();
            newMember.Show();
        }

        private void btnGearRenting_Click(object sender, EventArgs e)
        {
            var newBorrowing = new BorrowGearForm();
            newBorrowing.Show();
        }

        private void btnGearBorrowing_Click(object sender, EventArgs e)
        {
            var newRenting = new RentGearForm();
            newRenting.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newMember = new AddMemberForm();
            newMember.Show();
        }

        private void btnMemberLogin_Click(object sender, EventArgs e)
        {
            var memberCheckIn = new MemberCheckIn();
            memberCheckIn.Show();
        }
    }
}
