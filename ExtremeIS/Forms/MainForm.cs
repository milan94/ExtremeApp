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

        public user_account loggedInUser;
        List<member> allMembers;

        public MainForm()
        {
            InitializeComponent();
            populateTable(false);
            this.ActiveControl = comboBoxMemberLogin;
            populateGearTable();
        }
        public MainForm(user_account user)
        {
            InitializeComponent();
            loggedInUser = user;
            this.ActiveControl = comboBoxMemberLogin;
            populateTable(false);                                                    //Prebaciti u load mozda??
            populateGearTable();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            allMembers = MemberDAO.getAll();
            member member = MemberDAO.getById(loggedInUser.member_id);
            lblLogedUser.Text = member.first_name + " " + member.last_name;
            comboBoxMemberLogin.Items.AddRange(allMembers.ToArray());
            userMemberCheckIn();
            populateAttendaceList();

            //AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            //MyCollection.AddRange(MemberDAO.getAllBasicInfo().ToArray());
            //comboBoxMemberLogin.AutoCompleteCustomSource = MyCollection;

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
        private void userMemberCheckIn()
        {
            DateTime today = DateTime.Now;
            Boolean CheckedInForCurrentDate =
                AttendanceDAO.isAlreadyCheckedIn(loggedInUser.member_id, today.Day, today.Month, today.Year);

            if (!CheckedInForCurrentDate)
            {
                var user_member = MemberDAO.getById(loggedInUser.member_id);                //UBACITI POLJE TrUE za placen dolazak
                var newAttendance = new attendance()
                {
                    member_id = user_member.member_id,
                    check_in_time = DateTime.Now,
                    is_staff = true
                };
                AttendanceDAO.insert(newAttendance);
            }

        }
        private void btnDailyTicket_Click(object sender, EventArgs e)
        {
            var dailyTicket = new DailyTicketForm();
            dailyTicket.ShowDialog();
        }


        private void btnMemberLogin_Click(object sender, EventArgs e)
        {
            //input validation 
            if (comboBoxMemberLogin.SelectedIndex > -1)
            {
                var member = (member)comboBoxMemberLogin.SelectedItem;
                var membercheckin = new MemberCheckIn(this,tabControl1,member);
                membercheckin.ShowDialog();
                populateAttendaceList();
                comboBoxMemberLogin.SelectedIndex = -1;
            }
            else
            {
                lblMemberLoginFailed.ForeColor = System.Drawing.Color.Red;
                lblMemberLoginFailed.Text = "Neispravan unos!";
            }
        }

        private void comboBoxMemberLogin_TextChanged(object sender, EventArgs e)
        {
            lblMemberLoginFailed.ForeColor = System.Drawing.Color.LightGray;
            lblMemberLoginFailed.Text = "Pretraga članova po imenu ";
        }

        private void populateAttendaceList()
        {
            var attendanceListMembers = AttendanceDAO.getAllToday();
            this.objectListView1.SetObjects(attendanceListMembers);
            lblAttendance.Text = $"Pregled trenutno prijavljenih članova ({attendanceListMembers.Count()}) ";
        }
        private void comboBoxMemberLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMemberLogin_Click(this, new EventArgs());
            }
        }
        public void displayNewAttendance()
        {
            //treba napraviti da se pretplati na novo prijavljivanje i na novu prodatu kartu 
            //tako da kada dodje to tog nekog dogadjaja da se popuni u tabeli prisutnih 

            //drugi nacin je pristup direktno u bazi da se radi provjera u tabeli attendance? 
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Utils.Utilities.getPasswordHash("root", "roo"));                //POPRAVITI OVO SAMO ZA TEST SLUZI

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
                comboBoxMemberLogin.Text = msg;

                barcode.Clear();
            }
        }

       
    }
}
