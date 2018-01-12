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

        private int selectedMemberRowIndex;
        private List<member> members;

        public MainForm()
        {

            InitializeComponent();
            populateTable();
        }

        private void populateTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Ime", typeof(string));
            table.Columns.Add("Prezime", typeof(string));

            members = MemberDAO.getAll();

            foreach (var member in members)
            {
                table.Rows.Add(member.member_id, member.first_name, member.last_name);
            }

            dataGridViewMembers.DataSource = table;


        }



        private void btnDailyTicket_Click(object sender, EventArgs e)
        {
            var dailyTicket = new DailyTicketForm();
            dailyTicket.ShowDialog();
        }


        private void btnMemberLogin_Click(object sender, EventArgs e)
        {
            var memberCheckIn = new MemberCheckIn();
            memberCheckIn.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedMemberRowIndex = dataGridViewMembers.CurrentCell.RowIndex;
            if (selectedMemberRowIndex < members.Count)
            {
                var member = members[selectedMemberRowIndex];
                lblFirstNameProfileView.Text = member.first_name;
                lblLastNameProfileView.Text = member.last_name;
                lblBirthDateProfileView.Text = String.Format("{0:MM.dd.yyyy}", member.birth_date);
                lblAddressProfileView.Text = member.address;
                lblSexProfileView.Text = member.sex;
                lblPhoneNumberProfileView.Text = member.phone_number;
                lblEmailProfileView.Text = member.email;
                lblRegistrationDateProfileView.Text = String.Format("{0:MM.dd.yyyy}", member.registration_date);
                lblMembershipTypeProfileView.Text = MembershipTypeDAO.getById(member.membership_type_id);
                lblEducationLevelProfileView.Text = EducationLevelDAO.getById(member.education_level_id);
            }
        }
    }
}
