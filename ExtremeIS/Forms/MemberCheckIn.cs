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

namespace ExtremeIS.Forms
{
    public partial class MemberCheckIn : Form
    {
        private TabControl tabControl;
        private MainForm mainForm;
        public MemberCheckIn(MainForm mainForm,TabControl tabControl)
        {
            InitializeComponent();
            this.tabControl=tabControl;
            this.mainForm = mainForm;
        }

        private void btn_view_profile_Click(object sender, EventArgs e)
        {
            this.Close();
            tabControl.SelectTab(1);
            mainForm.displayMemberInfo(MemberDAO.getAll()[0]);
        }
    }
}
