using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtremeIS.Forms
{
    public partial class MainForm
    {
        private void btnFindMember_Click(object sender, EventArgs e)
        {

        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            var newMember = new AddMemberForm();
            newMember.Show();
        }

        private void btnChangeProfile_Click(object sender, EventArgs e)
        {
            var newMember = new AddMemberForm();
            newMember.Show();
        }

        private void btnSubmitPayment_Click(object sender, EventArgs e)
        {

        }
    }
}
