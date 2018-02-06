using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtremeIS.Forms
{
    public partial class MainForm
    {

        private void comboBoxReportCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxReportCategory.SelectedIndex==0)
            {
                comboBoxReportType.Items.Clear();
                comboBoxReportType.Items.Add("Prisustva - pojedinačno");
                comboBoxReportType.Items.Add("Prisustva - zbirno");
                comboBoxReportType.SelectedIndex = 0;
            }
            else if (comboBoxReportCategory.SelectedIndex==1)
            {
                comboBoxReportType.Items.Clear();
                comboBoxReportType.Items.Add("Popis");
                comboBoxReportType.Items.Add("Iznajmljivanje");
                comboBoxReportType.SelectedIndex = 0;
            }
            else if (comboBoxReportCategory.SelectedIndex==2)
            {
                comboBoxReportType.Items.Clear();
                comboBoxReportType.Items.Add("Članarine");
                comboBoxReportType.Items.Add("Dnevne karte");
                comboBoxReportType.SelectedIndex = 0;
            }
        }
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dateTimePickerReportDateFrom.Value;
            DateTime dateTo = dateTimePickerReportDateTo.Value;
            String category = comboBoxReportCategory.Text;
            String type = comboBoxReportType.Text;
            if (dateTo.Date >= dateFrom.Date)
            {
                new ReportForm(category,type,dateFrom, dateTo).Show();
            }
            else
            {
                MessageBox.Show("Datum do mora biti manji ili jednak od datuma od");
            }
        }
    }
}
