using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtremeIS.Forms
{
    public partial class MainForm
    {
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnGearAddOnList_Click(object sender, EventArgs e)
        {

        }

        private void btnReduceAmount_Click(object sender, EventArgs e)
        {

        }

        private void btnIncreaseAmount_Click(object sender, EventArgs e)
        {

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


        private void btnGearWriteOff_Click(object sender, EventArgs e)
        {

        }
    }
}