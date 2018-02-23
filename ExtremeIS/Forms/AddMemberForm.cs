using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtremeIS.DAO;
using ExtremeIS.Forms;
using ExtremeIS.Model.Entities;

namespace ExtremeIS.Forms
{
    public partial class AddMemberForm : Form
    {
        private static String path = Path.Combine(Environment.CurrentDirectory, "temp.jpg");
        private MainForm mainForm;
        private int memberId = 0;
        private String picturePath = "";

        public AddMemberForm(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
            comboBoxMembershipType.DataSource = MembershipTypeDAO.getAll();
            picturePath = "";
            btnAddMember.Text = "Dodaj";
            this.Name = "Dodavanje novog člana";

        }

        public AddMemberForm(MainForm form, member member)
        {
            Console.WriteLine(path);

            InitializeComponent();
            mainForm = form;
            memberId = member.member_id;
            comboBoxMembershipType.DataSource = MembershipTypeDAO.getAll();
            picturePath = member.profile_picture;
            populateAddMemberForm(member);
            btnAddMember.Text = "Izmjeni";
            this.Name = "Izmjena informacija o članu";
        }
        private void AddMemberForm_Load(object sender, EventArgs e)
        {
            lblMemberID.Text = (MemberDAO.getLast() + 1).ToString();
            dateTimePickerBirthDate.MaxDate = DateTime.Now;
            dateTimePickerRegistrationDate.MaxDate = DateTime.Now;
        }

        private void populateAddMemberForm(member member)
        {
            lblMemberID.Text = member.member_id.ToString();
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
            if (String.IsNullOrEmpty(member.profile_picture))
            {
                pictureBoxProfilePicture.Image = Properties.Resources.user;
            }
            else
            {
                pictureBoxProfilePicture.Image = Image.FromFile(member.profile_picture);

            }
            dateTimePickerBirthDate.Value = member.birth_date.Value;
            textBoxAddress.Text = member.address;
            textBoxPhoneNumber.Text = member.phone_number;
            textBoxEmail.Text = member.email;
            dateTimePickerRegistrationDate.Value = member.registration_date;
            comboBoxMembershipType.SelectedIndex = member.membership_type_id - 1;
            checkBoxActiveMember.Checked = member.active;
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if (validateInput())
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
                    profile_picture = picturePath,
                    active = checkBoxActiveMember.Checked,
                    membership_type_id = comboBoxMembershipType.SelectedIndex + 1
                };


                int result = MemberDAO.insert(member);
                var membership_card = new membership_card()
                {
                    active = true,
                    barcode_number = generateBarcodeNumber(),
                    issuer_user_account_id = mainForm.loggedInUser.user_account_id,
                    member_id = MemberDAO.getLast(),
                    create_date = DateTime.Now
                };
                if (result == 1)
                {
                    DialogResult dialogResult
                    = MessageBox.Show("Korisnik je uspješno dodan! Da li želite da ištampate člansku kartu ?",
                     "Štampanje članske karte", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Bitmap barcodeImage = (Bitmap)generateBarcodeImage(generateBarcodeNumber());
                        barcodeImage.Save(path);
                        new ReportForm(member.first_name, member.last_name, member.member_id.ToString()
                            , path).Show();

                    }

                    else
                    {
                        MessageBox.Show("Došlo je do greške prilikom dodavanja!");

                    }
                }
                else
                {
                    member.member_id = memberId;
                     result = MemberDAO.update(member);
                    if (result == 1)
                    {
                        DialogResult dialogResult
                        = MessageBox.Show("Korisnik je uspješno izmjenjen! " +
                        "Da li želite da ištampate člansku kartu ?",
                         "Štampanje članske karte", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Bitmap barcodeImage = (Bitmap)generateBarcodeImage(MemberDAO.getBarcodeNumber(memberId));
                            barcodeImage.Save(path);
                            new ReportForm(member.first_name, member.last_name, member.member_id.ToString()
                                , path).Show();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Došlo je do greške prilikom izmjene!");

                    }

                }
                mainForm.populateTable(false);
                mainForm.displayMemberInfo(member);
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
        private Boolean validateInput()
        {
            Boolean result = false;

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
                result = true;
            }
            return result;
        }

        private void btnAddProfilePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Otvoriti...",
                Filter = "Slike|*.jpg;*.jpeg;*.png",
                FilterIndex = 3,
                Multiselect = false
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picturePath = ofd.FileName;
                if ("".Equals(picturePath) || picturePath == null)
                {
                    pictureBoxProfilePicture.Image = Properties.Resources.user;

                }
                else
                {
                    pictureBoxProfilePicture.Image = Image.FromFile(picturePath);
                }
            }
        }

        private void btnGenerateMembershipCard_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                lblFirstNameMembershipCard.Text = textBoxFirstName.Text;
                lblLastNameMembershipCard.Text = textBoxLastName.Text;
                lblMemberIdMembershipCard.Text = lblMemberID.Text;

                String barcodeNumber = generateBarcodeNumber();

                pictureBoxBarcodeMembershipCard.Image = generateBarcodeImage(barcodeNumber);
            }
        }

        private String generateBarcodeNumber()
        {
            String barcodeNumber = dateTimePickerBirthDate.Value.ToString("ddyyyyMM");
            char[] charArray = barcodeNumber.ToCharArray();
            Array.Reverse(charArray);
            barcodeNumber = new string(charArray) + lblMemberID.Text;
            return barcodeNumber;
        }

        private Image generateBarcodeImage(String barcodeNumber)
        {
            BarcodeLib.Barcode b = new BarcodeLib.Barcode();
            Image img = b.Encode(BarcodeLib.TYPE.UPCA, barcodeNumber
                , Color.Black, Color.White, 365, 135);
            return img;
        }
    }

}

