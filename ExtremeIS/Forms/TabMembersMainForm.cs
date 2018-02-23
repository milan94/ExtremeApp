using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ExtremeIS.DAO;
using ExtremeIS.Model.Entities;

namespace ExtremeIS.Forms

{
    public partial class MainForm
    {
        private int selectedMemberRowIndex;
        private List<member> members;
        private enum months
        {
            Januar = 1, Februar, Mart, April, Maj,
            Jun, Jul, Avgust, Septembar, Oktobar, Novembar, Decembar
        };

        public void populateTable(Boolean isSearchResult)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Ime", typeof(string));
            table.Columns.Add("Prezime", typeof(string));

            if (!isSearchResult)
            {
                members = MemberDAO.getAll();
            }
            foreach (var member in members)
            {
                table.Rows.Add(member.member_id, member.first_name, member.last_name);
            }

            dataGridViewMembers.DataSource = table;
            // disable sorting of columns
            foreach (DataGridViewColumn column in dataGridViewMembers.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }
        private void btnFindMember_Click(object sender, EventArgs e)
        {
            var searchTerm = textBoxMember.Text.ToLower();
                if(String.IsNullOrEmpty(searchTerm))
            {
                populateTable(false);
            }
            else {
                members.Clear();
                List<member> allMembers=MemberDAO.getAll();
                List<member> results;
                var isNumeric = int.TryParse(searchTerm, out var n);
                if (isNumeric)
                { 
                    results = allMembers.FindAll(x => x.member_id.Equals(n));
                    if (results.Count == 1)
                    {
                        members.Add(results.First());
                    }
                }
                else
                {
                    results = allMembers.FindAll(x => x.first_name.ToLower()
                    .Contains(searchTerm));
                    foreach (var result in results)
                    {
                        members.Add(result);
                    }
                    results = allMembers.FindAll(x => x.last_name.ToLower().Contains(searchTerm));
                    foreach (var result in results)
                    {
                        if (!members.Contains(result))
                        {
                            members.Add(result);
                        }
                    }
                }
                populateTable(true);

            }
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            var newMember = new AddMemberForm(this);
            newMember.ShowDialog();
        }

        private void btnChangeProfile_Click(object sender, EventArgs e)
        {
            var newMember = new AddMemberForm(this, members[selectedMemberRowIndex]);
            newMember.ShowDialog();
        }

        private void btnSubmitPayment_Click(object sender, EventArgs e)
        {
            membeship_fee_payment membershipFeePayment = new membeship_fee_payment();
            member member = members[selectedMemberRowIndex];
            membershipFeePayment.member_id = member.member_id;

            //hardcoded
            membershipFeePayment.issuer_user_account_id = 1;

            Enum.TryParse(comboBoxMonthMembershipFee.Text, out months month);
            membershipFeePayment.month = (sbyte)month;
            membershipFeePayment.year = short.Parse(comboBoxYearMembershipFee.Text);
            membershipFeePayment.is_free_of_charge = checkBoxFreeOfCharge.Checked;
            if (checkBoxFreeOfCharge.Checked)
            {
                membershipFeePayment.price = 0;
            }
            else
            {
                membershipFeePayment.price = MembershipTypeDAO.getById(member.membership_type_id).fee_price;
            }
            membershipFeePayment.is_paid = true;
            membershipFeePayment.payment_date = DateTime.Now;

            int result = MembershipFeePaymentDAO.insert(membershipFeePayment);
            if (result == 1)
            {
                MessageBox.Show("Uspješno uplaćena članarina za mjesec " + month);
                displayMemberInfo(members[selectedMemberRowIndex]);
            }
            else
            {
                MessageBox.Show("Došlo je do greške prilikom uplate za mjesec " + month);
            }
        }

        private void populateCalendar(int memberId)
        {
            List<DateTime> attendances = AttendanceDAO.getAllById(memberId);
            calendarAttendance.RemoveAllBoldedDates();
            if (attendances.Count != 0)
            {
                foreach (var attendance in attendances)
                    calendarAttendance.AddBoldedDate(attendance);
            }
            calendarAttendance.UpdateBoldedDates();
        }

        private void dataGridViewMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedMemberRowIndex = dataGridViewMembers.CurrentCell.RowIndex;
            if (selectedMemberRowIndex < members.Count)
            {
                var member = members[selectedMemberRowIndex];
                displayMemberInfo(member);
            }

        }
        public void displayMemberInfo(member member)
        {
            panelNoMemberSelected.Hide();
            lblAddEducationLevelError.Text = "";
            lblFirstNameProfileView.Text = member.first_name;
            lblLastNameProfileView.Text = member.last_name;
            lblBirthDateProfileView.Text = String.Format("{0:dd.MM.yyyy}", member.birth_date);
            lblAddressProfileView.Text = member.address;
            lblSexProfileView.Text = member.sex;
            lblPhoneNumberProfileView.Text = member.phone_number;
            lblEmailProfileView.Text = member.email;
            lblRegistrationDateProfileView.Text = String.Format("{0:dd.MM.yyyy}", member.registration_date);
            lblMembershipTypeProfileView.Text = MembershipTypeDAO.getById(member.membership_type_id).name;
            lblFirstAndLastNameAttendance.Text = member.first_name + " " + member.last_name;
            lblFirstAndLastNameMembershipFee.Text = member.first_name + " " + member.last_name;
            lblFirstAndLastNameEducation.Text = member.first_name + " " + member.last_name;
            lblMeberIdProfileView.Text = member.member_id.ToString();
            
            if (String.IsNullOrEmpty(member.profile_picture))
            {
                pictureBoxProfilePicture.Image = Properties.Resources.user;
                

            }
            else
            {
                pictureBoxProfilePicture.Image = Image.FromFile(member.profile_picture);

            }
            var lastAttendance = AttendanceDAO.getLastById(member.member_id);

            lblLastAttendance.Text = lastAttendance;
            
            populateCalendar(member.member_id);

            //You can pay for the month three days before
            var payingMonth = DateTime.Now.AddDays(3).Month;
            var payingYear = DateTime.Now.AddDays(3).Year;
            comboBoxMonthMembershipFee.SelectedIndex = 0;
            comboBoxYearMembershipFee.SelectedIndex = 0;

            populateMembershipFeeStatistic();
            var memberEducations = MemberEducationDAO.getById(member.member_id);

            comboBoxEducationLevel4.Items.Clear();
            comboBoxEducationLevel3.Items.Clear();
            comboBoxEducationLevel2.Items.Clear();
            comboBoxEducationLevel1.Items.Clear();

            lblEducationLevelExamDate4.Text = "/";
            lblEducationLevelExamDate3.Text = "/";
            lblEducationLevelExamDate2.Text = "/";
            lblEducationLevelExamDate1.Text = "/";

            comboBoxEducationLevel4.Enabled = false;
            comboBoxEducationLevel3.Enabled = false;
            comboBoxEducationLevel2.Enabled = false;
            comboBoxEducationLevel1.Enabled = false;


            switch (memberEducations.Count)
            {
                case 4:
                    lblEducationLevelExamDate4.Text = memberEducations[3].exam_date.ToString("dd.MM.yyyy.");
                    comboBoxEducationLevel4.Items.Add(memberEducations[3].commission_member_1);
                    comboBoxEducationLevel4.Items.Add(memberEducations[3].commission_member_2);
                    comboBoxEducationLevel4.Items.Add(memberEducations[3].commission_member_3);
                    comboBoxEducationLevel4.SelectedIndex = 0;
                    comboBoxEducationLevel4.Enabled = true;
                    goto case 3;
                case 3:
                    lblEducationLevelExamDate3.Text = memberEducations[2].exam_date.ToString("dd.MM.yyyy.");
                    comboBoxEducationLevel3.Items.Add(memberEducations[2].commission_member_1);
                    comboBoxEducationLevel3.Items.Add(memberEducations[2].commission_member_2);
                    comboBoxEducationLevel3.Items.Add(memberEducations[2].commission_member_3);
                    comboBoxEducationLevel3.SelectedIndex = 0;
                    comboBoxEducationLevel3.Enabled = true;
                    goto case 2;
                case 2:
                    lblEducationLevelExamDate2.Text = memberEducations[1].exam_date.ToString("dd.MM.yyyy.");
                    comboBoxEducationLevel2.Items.Add(memberEducations[1].commission_member_1);
                    comboBoxEducationLevel2.Items.Add(memberEducations[1].commission_member_2);
                    comboBoxEducationLevel2.Items.Add(memberEducations[1].commission_member_3);
                    comboBoxEducationLevel2.SelectedIndex = 0;
                    comboBoxEducationLevel2.Enabled = true;
                    goto case 1;
                case 1:
                    lblEducationLevelExamDate1.Text = memberEducations[0].exam_date.ToString("dd.MM.yyyy.");
                    comboBoxEducationLevel1.Items.Add(memberEducations[0].commission_member_1);
                    comboBoxEducationLevel1.Items.Add(memberEducations[0].commission_member_2);
                    comboBoxEducationLevel1.Items.Add(memberEducations[0].commission_member_3);
                    comboBoxEducationLevel1.SelectedIndex = 0;
                    comboBoxEducationLevel1.Enabled = true;
                    break;
            }
            int lastPayedMonth = MembershipFeePaymentDAO.getLastPaidMonth(member.member_id);
            if (lastPayedMonth == payingMonth)
            {
                comboBoxMonthMembershipFee.Enabled = false;
                comboBoxYearMembershipFee.Enabled = false;
                btnSubmitPayment.Enabled = false;
            }
            else
            {
                comboBoxMonthMembershipFee.Enabled = true;
                comboBoxYearMembershipFee.Enabled = true;
                btnSubmitPayment.Enabled = true;
            }
        }
        public void populateMembershipFeeStatistic()
        {
            var member = members[selectedMemberRowIndex];
            lblFeePrice.Text = MembershipTypeDAO.getById(member.membership_type_id).fee_price.ToString();
            var month = MembershipFeePaymentDAO.getLastPaidMonth(member.member_id);
            if (month == 0)
            {
                lblLastPayedMonth.Text = "/";
            }
            else
            {
                lblLastPayedMonth.Text = ((months)month).ToString();
            }
            lblFeeSummary.Text = MembershipFeePaymentDAO.getNumberOfPaidMembershipFees(member.member_id).ToString();

        }
        private void textBoxMember_TextChanged(object sender, EventArgs e)
        {
            btnFindMember_Click(sender, e);
        }
        private void btnAddEducationLevel_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBoxCommissionMember3.Text)||
                String.IsNullOrEmpty(textBoxCommissionMember2.Text)||
                String.IsNullOrEmpty(textBoxCommissionMember1.Text))
            {
                lblAddEducationLevelError.ForeColor = System.Drawing.Color.Red;
                lblAddEducationLevelError.Text = "*Niste unijeli sve podatke";
            }
            else
            {
                member_education memberEducation = new member_education();
                memberEducation.commission_member_1 = textBoxCommissionMember1.Text;
                memberEducation.commission_member_2 = textBoxCommissionMember2.Text;
                memberEducation.commission_member_3 = textBoxCommissionMember3.Text;
                memberEducation.exam_date = dateTimePickerEducationLevelExamDate.Value;

                // vraca sve dosadasnje stepene, pa dodaje novi (tj. sledeci stepen)
                var memberEducations=MemberEducationDAO.getById(members[selectedMemberRowIndex].member_id);
                memberEducation.education_level_id = memberEducations.Count() + 1;
                memberEducation.member_id = members[selectedMemberRowIndex].member_id;
                MemberEducationDAO.insert(memberEducation);
                textBoxCommissionMember1.Clear();
                textBoxCommissionMember2.Clear();
                textBoxCommissionMember3.Clear();
                lblAddEducationLevelError.Text = "";
                displayMemberInfo(members[selectedMemberRowIndex]);
            }
        }
    }
}
