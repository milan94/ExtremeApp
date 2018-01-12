using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtremeIS.DAO;
using ExtremeIS.Model.Entities;
namespace ExtremeIS
{
    public partial class AddMemberForm : Form
    {
        public AddMemberForm()
        {
            InitializeComponent();

            comboBoxEducationLevel.DataSource = EducationLevelDAO.getAll();
            comboBoxMembershipType.DataSource = MembershipTypeDAO.getAll();
        }

        public AddMemberForm(member member)
        {
            InitializeComponent();
            comboBoxEducationLevel.DataSource = EducationLevelDAO.getAll();
            comboBoxMembershipType.DataSource = MembershipTypeDAO.getAll();
            populateAddMemberForm(member);
        }

        private void populateAddMemberForm(member member)
        {
            textBoxFirstName.Text = member.first_name;
            textBoxLastName.Text = member.last_name;
            if (member.sex.Equals("M"))
            {
                radioButtonSexMale.Checked = true;
            }
            else if (member.sex.Equals("Ž"))
            {
                radioButtonSexFemale.Checked = true;
            }
            dateTimePickerBirthDate.Value = member.birth_date.Value;
            textBoxAddress.Text = member.address;
            textBoxPhoneNumber.Text = member.phone_number;
            textBoxEmail.Text = member.email;
            dateTimePickerRegistrationDate.Value = member.registration_date;
            comboBoxEducationLevel.SelectedIndex = member.education_level_id - 1;
            comboBoxMembershipType.SelectedIndex = member.membership_type_id - 1;
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {

            if (textBoxFirstName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Niste unijeli ime osobe");
            }
            else if (textBoxLastName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Niste unijeli prezime osobe");
            }

            //If birthDate is todays date show error message

            else if (dateTimePickerBirthDate.Value.Date == DateTime.Today)
            {
                MessageBox.Show("Niste unijeli datum rodjenja osobe");
            }
            else if (textBoxAddress.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Niste unijeli adresu osobe");
            }
            else if (textBoxPhoneNumber.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Niste unijeli broj telefona osobe");
            }
            else if (textBoxEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Niste unijeli email osobe");
            }
            else
            {
                String sex;
                if (radioButtonSexMale.Checked)
                {
                    sex = "M";
                }
                else
                {
                    sex = "Ž";
                }
                var member = new member()
                {
                    first_name = textBoxFirstName.Text,
                    last_name = textBoxLastName.Text,
                    sex = sex,
                    birth_date = dateTimePickerBirthDate.Value.Date,
                    address = textBoxAddress.Text,
                    phone_number = textBoxPhoneNumber.Text,
                    email = textBoxEmail.Text,
                    registration_date = dateTimePickerRegistrationDate.Value.Date,
                    last_modified = DateTime.Now,
                    active = true,
                    education_level_id = comboBoxEducationLevel.SelectedIndex + 1,
                    membership_type_id = comboBoxMembershipType.SelectedIndex + 1
                };
                int result = MemberDAO.insert(member);
                MessageBox.Show("Korisnik je uspješno dodan!");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult
                 = MessageBox.Show("Da li ste sigurni da zelite da odustanete ?", 
                 "Da li ste sigurni?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

