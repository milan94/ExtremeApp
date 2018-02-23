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
using ExtremeIS.Forms;
using ExtremeIS.Model.Entities;

namespace ExtremeIS
{
    public partial class LoginForm : Form
    {      

         public LoginForm()
         {
            InitializeComponent();
         }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Input validation
            if (!(String.IsNullOrEmpty(textBoxUsername.Text) || String.IsNullOrEmpty(textBoxPassword.Text)))
            {
                var username = textBoxUsername.Text.Trim().ToLowerInvariant();
                var password = textBoxPassword.Text.Trim();
                
                //User identification 
                var identifiedUser = UserAccountDAO.identifyUser(username);
                if (identifiedUser != null)
                {
                    //User authentication 
                    var loginSuccessful = UserAccountDAO.authenticateUser
                        (identifiedUser, password);
                    if (loginSuccessful)
                    {
                        //Login OK
                        Hide();
                        var mainForm = new MainForm(identifiedUser);
                        mainForm.Show();
                    }
                    else
                    {
                        lblLoginFalse.Text = "Pogrešna lozinka!";
                        textBoxPassword.Clear();
                    }
                }
                else
                {
                    lblLoginFalse.Text = "Neuspješna prijava!";
                    textBoxPassword.Clear();
                    textBoxUsername.Clear();
                }
            }
            else
            {
                lblLoginFalse.Text = "Uniesi korisničko ime i loznku!";
            }
        }

        
        private void textBoxPassword_TextChanged(object sender, KeyPressEventArgs e)
        {
            lblLoginFalse.Text = String.Empty;
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(textBoxUsername.Text);
            
        }
    }
}
