using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtremeIS.Model.Entities;
using ExtremeIS.DAO;
namespace ExtremeIS.Forms
{
    public partial class MainForm : Form
    {
        DateTime lastKeystroke = new DateTime(0);
        List<char> barcode = new List<char>(12);

        public MainForm()
        {
            InitializeComponent();
            populateTable(false);
            this.ActiveControl = textBoxMemberLogin;
            
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            MyCollection.AddRange(MemberDAO.getAllBasicInfo().ToArray());
            textBoxMemberLogin.AutoCompleteCustomSource = MyCollection;
            calendarAttendance.MaxDate = DateTime.Now;
            dateTimePickerReportDateFrom.MaxDate = DateTime.Now;
            dateTimePickerReportDateTo.MaxDate = DateTime.Now;
            dateTimePickerEducationLevelExamDate.MaxDate = DateTime.Now;
            //You can pay for the month three days before
            var payingMonth = DateTime.Now.AddDays(3).Month;
            var payingYear = DateTime.Now.AddDays(3).Year;
            comboBoxMonthMembershipFee.Items.Add(((months)payingMonth).ToString());
            comboBoxMonthMembershipFee.SelectedIndex = 0;
            comboBoxYearMembershipFee.Items.Add(payingYear);
            comboBoxYearMembershipFee.SelectedIndex = 0;

            comboBoxReportCategory.Items.Add("Članovi");
            comboBoxReportCategory.Items.Add("Oprema");
            comboBoxReportCategory.Items.Add("Finansije");
            comboBoxReportCategory.SelectedIndex = 0;
            
        }
        private void btnDailyTicket_Click(object sender, EventArgs e)
        {
            var dailyTicket = new DailyTicketForm();
            dailyTicket.ShowDialog();
        }


        private void btnMemberLogin_Click(object sender, EventArgs e)
        {
            var memberCheckIn = new MemberCheckIn(this,tabControl1);
            memberCheckIn.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tabControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // check timing (keystrokes within 100 ms)
            TimeSpan elapsed = (DateTime.Now - lastKeystroke);
            if (elapsed.TotalMilliseconds > 100)
                barcode.Clear();

            // record keystroke & timestamp
            barcode.Add(e.KeyChar);
            lastKeystroke = DateTime.Now;

            // process barcode
            if (e.KeyChar == 13 && barcode.Count > 0)
            {
                string msg = new String(barcode.ToArray());
                //tabControl1.SelectTab(0);
                textBoxMemberLogin.Text = msg;

                barcode.Clear();
            }
        }

       
    }
}
