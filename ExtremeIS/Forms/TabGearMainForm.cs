using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ExtremeIS.DAO;
using ExtremeIS.Model;
namespace ExtremeIS.Forms
{
    public partial class MainForm
    {
        private List<gear_detailed> allGear;

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

        private void btnAddGear_Click(object sender, EventArgs e)               //PREBACITI U PARTIAL ZA OPERMU
        {
            var addNewGear = new AddGearForm();
            addNewGear.ShowDialog();
        }

        private void populateGearTable()
        {
            DataTable gearTable = new DataTable();
            gearTable.Columns.Add("ID", typeof(int));
            gearTable.Columns.Add("Naziv", typeof(string));
            gearTable.Columns.Add("Proizvođač", typeof(string));
            gearTable.Columns.Add("Kategorija", typeof(string));
            gearTable.Columns.Add("Opis", typeof(string));
            gearTable.Columns.Add("Veličina", typeof(string));
            gearTable.Columns.Add("Ukupno", typeof(int));
            gearTable.Columns.Add("Dostupno", typeof(int));

            allGear = GearDAO.getAllDetailed();

            foreach (var g in allGear)
            {
                gearTable.Rows.Add(g.gear_id,
                               g.name,
                               g.manufacturer_name,
                               g.gear_category_name,
                               g.description,
                               g.size_value,
                               g.quantity,
                               g.available
                               );
            }

            dataGridViewGear.DataSource = gearTable;
            cBoxGearSearchCategory.Items.AddRange(GearDAO.getAllCategories().ToArray());
        }
    }
}
