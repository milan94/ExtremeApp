using ExtremeIS.Model.Entities;
using ExtremeIS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using ExtremeIS.Forms;
namespace ExtremeIS
{
    public partial class MemberCheckIn : Form
    {
        //Auto-close dialog window
        Timer timer = new System.Windows.Forms.Timer();
        int timeLeft = 15;

        private MainForm mainForm;
        private TabControl tabControl;
        private member member;

        private void MemberCheckIn_Load(object sender, EventArgs e)
        {
            {
                timer.Interval = 1000;
                timer.Tick += new EventHandler(timer_Tick);
            }
        }
        void timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                lblClosingTimeLeft.Text = $" zatvaranje prozora za {timeLeft--} s ";
            }
            else
            {
                 this.Close();
            }

        }

        public MemberCheckIn(MainForm mainForm,TabControl tabControl, member member)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tabControl = tabControl;
            this.member = member;
            //Show user informations
            lblLoginMemberFirstName.Text = member.first_name;
            lblLoginMemberLastName.Text = member.last_name;
            lblLoginMemberAttendance.Text = AttendanceDAO.getLastById(member.member_id);

            String loginSuccessText;
            Image loginSuccessImage;
            setMemberLoginStatus(member, out loginSuccessText, out loginSuccessImage);

            lblLoginStatus.Text = loginSuccessText;
            pictureBoxLoginStatus.Image = loginSuccessImage;

            if (String.IsNullOrEmpty(member.profile_picture))
            {
                pictureBoxMemberProfileImage.Image = Properties.Resources.user;
            }
            else
            {
                pictureBoxMemberProfileImage.Image = Image.FromFile(member.profile_picture);
            }
        }


        //Set users status and login image depending on user payments history
        private void setMemberLoginStatus(member m, out String text, out Image img)
        {
            //Default values 
            text = "Neuspješna prijava!";
            img = Properties.Resources.loginFAIL;

            int forMonth = DateTime.Now.Month;
            int forYear = DateTime.Now.Year;
            int forDate = DateTime.Now.Day;

            //Gdje ide provjera da li clan uopste POSTOJI! KADA BUDE CITAC??
            
            Boolean paidForCurrentMonth = MembershipFeePaymentDAO.isPaidFor(m.member_id, forMonth, forYear);
            Boolean CheckedInForCurrentDate = AttendanceDAO.isAlreadyCheckedIn(m.member_id, forDate, forMonth, forYear);
            
            if (!CheckedInForCurrentDate)
            {
                if (paidForCurrentMonth)
                {
                    if (saveAttendance(m,true))
                    {
                        //CheckIn successfull - display infromation and close dialog after x seconds
                        text = "Uspješna prijava!";
                        lblWarning.Text = "Plaćena članarina!";
                        img = Properties.Resources.loginOK;
                        timer.Start();
                    }
                }
                else
                {   //Memeber can CheckIn with warning
                    if (DateTime.Now.Day > 5)
                    {
                        if (saveAttendance(m,false))
                        {
                            //Login successfull - display warning to pay fee 
                            text = "Uspješna prijava";
                            lblWarning.Text = "Platiti članarinu!";
                            img = Properties.Resources.loginWRN;
                        }
                    }
                    else
                    {
                        //Members who paid fee for the last month can chekcIn regularly unitl 5th in next month
                            //Check if it's end of year
                            if (forMonth == 1)
                            {
                                forMonth = 13;
                                forYear--;
                            }
                            Boolean paidForLastMonth = MembershipFeePaymentDAO.isPaidFor(m.member_id, forMonth - 1, forYear);
                        if (paidForLastMonth)
                        {
                            if (saveAttendance(m,true))
                            {
                                //Login successfull - display infromation and remark to pay fee current month also
                                text = "Uspješna prijava";
                                lblWarning.Text = "Platiti članarinu!";
                                img = Properties.Resources.loginWRN;
                            }
                        }
                        else
                        {
                            if (saveAttendance(m,false))
                            {
                                //Login successfull - display warning to pay fee 
                                text = "Uspješna prijava";
                                lblWarning.Text = "Platiti članarinu!";
                                img = Properties.Resources.loginWRN;
                            }

                        }
                    }
                }
            }
            else
            {
                 //CheckIn failed - display infromation and warning - member already CheckedIn
                 text = "Član već prijavljen!";
                 img = Properties.Resources.loginERR;
            }
                
        }


        //Save new attendance
        private Boolean saveAttendance(member m, Boolean isPaid)                //dopuniti kada se popravi baza 
        {
            var newAttendance = new attendance()
            {
                member_id = m.member_id,
                check_in_time = DateTime.Now,
                is_staff = false
            };

            return AttendanceDAO.insert(newAttendance);
        }

        private void btnShowProfile_Click(object sender, EventArgs e)
        {
            this.Close();
            tabControl.SelectedIndex = 1;
            mainForm.displayMemberInfo(member);
        }
    }
}
