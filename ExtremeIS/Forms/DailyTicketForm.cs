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
    public partial class DailyTicketForm : Form
    {
        public DailyTicketForm()
        {
            InitializeComponent();

            var ticketTypes = DailyTicketsDAO.getAllTypes();
            comboBoxTicketType.Items.AddRange(ticketTypes.ToArray());
            comboBoxTicketType.SelectedIndex = 0;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var dt = (daily_ticket_type)comboBoxTicketType.SelectedItem;
            var quantity = (int)numTicketQuantity.Value;

            var ticket = new daily_ticket()
            {
                issuer_user_account_id = 1,                                         //POPRAVITI ISSUER-a
                daily_ticket_type_id = dt.daily_ticket_type_id,
                price = dt.price,
                create_date = DateTime.Now
            };

            while ((quantity--) > 0)
            {
                DailyTicketsDAO.insert(ticket);
            }
                                                                                   //UBACITI MESSAGEBOX za stampanje karte
            this.Close();
        }

        private void numTicketQuantity_ValueChanged(object sender, EventArgs e)
        {
            var dt = (daily_ticket_type)comboBoxTicketType.SelectedItem;
            var quantity =(int) numTicketQuantity.Value;

            lblTicketPrice.Text = $"{dt.price * quantity}KM";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
