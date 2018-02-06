using ExtremeIS.DAO;
using ExtremeIS.Model;
using ExtremeIS.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExtremeIS
{
    public partial class AddGearForm : Form
    {
        List<Control> checkBoxes;
        List<Control> numericUpDowns;

        List<gear_detailed> gearItemsDetailed;
        List<gear_category> categories;
        List<manufacturer> manufacturers;
        List<gear_size> gearSizes;


        public AddGearForm()
        {
            InitializeComponent();

            checkBoxes = new List<Control>();
            numericUpDowns = new List<Control>();

            checkBoxes.Add(checkBoxXS);
            checkBoxes.Add(checkBoxS);
            checkBoxes.Add(checkBoxM);
            checkBoxes.Add(checkBoxL);
            checkBoxes.Add(checkBoxXL);
            checkBoxes.Add(checkBoxXXL);

            numericUpDowns.Add(nUpDownXS);
            numericUpDowns.Add(nUpDownS);
            numericUpDowns.Add(nUpDownM);
            numericUpDowns.Add(nUpDownL);
            numericUpDowns.Add(nUpDownXL);
            numericUpDowns.Add(nUpDownXXL);
        }


        private void btnAddGearConfirm_Click(object sender, EventArgs e)
        {

            //If gear has sizes new object is made for every item size

            //If gear already exists in database - just update quantity

            var validData = true;
            var exist = false;

            String gn = "";
            String desc = "";
            var gc = new gear_category();
            var gm = new manufacturer();
            var existingItem = new gear();


            if (cBoxGearName.SelectedIndex == -1)
            {
                if (string.IsNullOrEmpty(cBoxGearName.Text))
                {
                    lblGearNameError.Text = "*unijeti naziv opereme";
                    validData = false;
                }
                else
                {
                    gn = cBoxGearName.Text.Trim();
                }
                if (cBoxGearCategory.SelectedIndex == -1)
                {
                    lblGearCategoryError.Text = "*unijeti kategoriju";
                    validData = false;
                }
                else
                {
                    gc = (gear_category)cBoxGearCategory.SelectedItem;
                }
                if (cBoxGearManufacturer.SelectedIndex == -1)
                {
                    lblGearManufacturerError.Text = "*izabrati proizvođača";
                    validData = false;
                }
                else
                {
                    gm = (manufacturer)cBoxGearManufacturer.SelectedItem;
                }
            }
            else
            {
                //User has selected existring gear item - change only quantity
                existingItem = (gear)cBoxGearName.SelectedItem;
                exist = true;
            }

            if (validData)
            {
                if (checkBoxMultipleSizes.Enabled == true)
                {
                    //This category item have sizes 

                    if (checkBoxMultipleSizes.Checked)
                    {
                        //Multiple sizes selected 




                    }
                    else
                    {
                        //Only one size is selected
                        if (cBoxGearSize.SelectedIndex == -1)
                        {
                            lblGearSizeError.Text = "*izabrati veličinu";
                        }
                        else
                        {
                            if (!exist)
                            {
                                var gs = (gear_size)cBoxGearSize.SelectedItem;
                                var gq = Convert.ToInt32(nUpDownGearQuantity.Value);
                                desc = rTextBoxGearDescription.Text.Trim();

                                var newGear = new gear()
                                {
                                    gear_category_id = gc.gear_category_id,
                                    manufacturer_id = gm.manufacturer_id,
                                    name = gn,
                                    descritption = desc
                                };
                                var insertedGearId = GearDAO.insert(newGear);

                                var newGearSizeItem = new gear_size_items()
                                {
                                    gear_id = insertedGearId,
                                    gear_size_id = gs.gear_size_id,
                                    quantity = gq,
                                    available = gq
                                };
                                GearDAO.insertGearSizeItem(newGearSizeItem);
                            }
                            else
                            {
                                //Item already exists update it - if specific size doesn't exist create it 
                                var gs = (gear_size)cBoxGearSize.SelectedItem;
                                var gq = Convert.ToInt32(nUpDownGearQuantity.Value);
                                var gearSizeItems = GearDAO.getAllSizesByGearId(existingItem.gear_id);

                                var updated = false;
                                foreach (var gsi in gearSizeItems)
                                {
                                    if (gsi.gear_size_id == gs.gear_size_id)
                                    {
                                        gsi.quantity += gq;
                                        gsi.available += gq;
                                        updated = GearDAO.updateGearSizeItem(gsi);
                                    }
                                }
                                if (!updated)
                                {
                                    //Create new size for item 
                                    var newGearSizeItem = new gear_size_items()
                                    {
                                        gear_id = existingItem.gear_id,
                                        gear_size_id = gs.gear_size_id,
                                        quantity = gq,
                                        available = gq
                                    };
                                    GearDAO.insertGearSizeItem(newGearSizeItem);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                //This category items have no sizes 
                var gq = Convert.ToInt32(nUpDownGearQuantity.Value);
            }
        }
        

        private void denableComponets(List<Control> componentList, String option)
        {
            foreach (Control c in componentList)
            {
                if (option.Equals("E"))
                {
                    c.Enabled = true;
                }
                else if (option.Equals("D"))
                {
                    c.Enabled = false;
                }
            }
        }

        //Multiple size entering control
        private void checkBoxMultipleSizes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMultipleSizes.Checked == true)
            {
                groupBoxSizes.Enabled = true;
                nUpDownGearQuantity.Enabled = false;
                cBoxGearSize.Enabled = false;
                denableComponets(checkBoxes, "E");
            }
            else
            {
                groupBoxSizes.Enabled = false;
                nUpDownGearQuantity.Enabled = true;
                cBoxGearSize.Enabled = true;
                denableComponets(numericUpDowns, "D");

            }
        }

        private void checkBoxXS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxXS.Checked == true)
            {
                nUpDownXS.Enabled = true;
            }
            else
            {
                nUpDownXS.Enabled = false;
            }
        }

        private void checkBoxS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxS.Checked == true)
            {
                nUpDownS.Enabled = true;
            }
            else
            {
                nUpDownS.Enabled = false;
            }
        }

        private void checkBoxM_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxM.Checked == true)
            {
                nUpDownM.Enabled = true;
            }
            else
            {
                nUpDownM.Enabled = false;
            }
        }

        private void checkBoxL_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxL.Checked == true)
            {
                nUpDownL.Enabled = true;
            }
            else
            {
                nUpDownL.Enabled = false;
            }
        }

        private void checkBoxXL_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxXL.Checked == true)
            {
                nUpDownXL.Enabled = true;
            }
            else
            {
                nUpDownXL.Enabled = false;
            }
        }

        private void checkBoxXXL_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxXXL.Checked == true)
            {
                nUpDownXXL.Enabled = true;
            }
            else
            {
                nUpDownXXL.Enabled = false;
            }
        }


        private void AddGearForm_Load(object sender, EventArgs e)
        {
            manufacturers = GearDAO.getAllManufacturers();
            categories = GearDAO.getAllCategories();
            gearSizes = GearDAO.getAllSizes();
            gearItemsDetailed = GearDAO.getAllDetailed();

            cBoxGearName.Items.AddRange(gearItemsDetailed.ToArray());
            cBoxGearCategory.Items.AddRange(categories.ToArray());
            cBoxGearManufacturer.Items.AddRange(manufacturers.ToArray());
            cBoxGearSize.Items.AddRange(gearSizes.ToArray());
        }

        private void cBoxGearName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxGearName.SelectedIndex > -1)
            {
                cBoxGearManufacturer.Enabled = false;
                cBoxGearCategory.Enabled = false;
                rTextBoxGearDescription.Enabled = false;

            }
            else
            {
                cBoxGearManufacturer.Enabled = true;
                cBoxGearCategory.Enabled = true;
                rTextBoxGearDescription.Enabled = true;

            }
        }
    }
}
