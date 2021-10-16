using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class ModifyPart : Form
    {
        public ModifyPart(Part part)
        {
            InitializeComponent();

            mppartid.Text = part.PartID.ToString();
            mpname.Text = part.Name;
            mpinventory.Text = part.InStock.ToString();
            mpprice.Text = part.Price.ToString();
            mpmax.Text = part.Max.ToString();
            mpmin.Text = part.Min.ToString();

            if (part is Outsource)
            {
                addPartOutSource.Checked = true;
                addPartInHouse.Checked = false;
                mpmachineid.Text = null;
                mpmachineid.Hide();
                label8.Hide();
                mpcompanyname.Show();
                label7.Show();
                Outsource os = (Outsource)part;
                mpcompanyname.Text = os.CompanyName;
            }
            else if (part is InHouse)
            {
                addPartInHouse.Checked = true;
                addPartOutSource.Checked = false;
                mpcompanyname.Text = null;
                mpcompanyname.Hide();
                label7.Hide();
                mpmachineid.Show();
                label8.Show();
                InHouse ih = (InHouse)part;
                mpmachineid.Text = ih.MachineID.ToString();

            }
            else
            {
                //something went very wrong here

            }
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();
            label15.Hide();
            label17.Hide();
        }



        private void modfiypartSave_Click(object sender, EventArgs e)
        {
            int partMachineID;
            int partMax;
            int partMin;
            int partInventory;
            decimal partPrice;
            int partID;
            int.TryParse(mppartid.Text, out partID);
            string partName = mpname.Text;
            decimal.TryParse(mpprice.Text, out partPrice);
            int.TryParse(mpinventory.Text, out partInventory);
            int.TryParse(mpmin.Text, out partMin);
            int.TryParse(mpmax.Text, out partMax);
            int.TryParse(mpmachineid.Text, out partMachineID);
            string partCompanyName = mpcompanyname.Text;


            if (addPartInHouse.Checked == true)
            {
                Part part = new InHouse(partID, partName, partPrice, partInventory, partMin, partMax, partMachineID);
                Inventory.updatePart(partID, part);
                Close();
            }
            else
            {
                Part part = new Outsource(partID, partName, partPrice, partInventory, partMin, partMax, partCompanyName);
                Inventory.updatePart(partID, part);
                Close();
            }
        }

        private void mppartid_Validated(object sender, EventArgs e)
        {
            int partID;
            if (int.TryParse(mppartid.Text, out partID))
            {
                label11.Hide();
            }
            else
            {
                label11.Show();
            }
        }

        private void mpinventory_Validated(object sender, EventArgs e)
        {
            int partMax;
            int partMin;
            int partInventory;
            int.TryParse(mpmax.Text, out partMax);
            int.TryParse(mpmin.Text, out partMin);
            int.TryParse(mpinventory.Text, out partInventory);
            if (partInventory >= partMin && partInventory <= partMax)
            {
                label10.Hide();
            }
            else
            {
                label10.Show();
            }
        }

        private void mpprice_Validated(object sender, EventArgs e)
        {
            decimal partPrice;
            if (decimal.TryParse(mpprice.Text, out partPrice))
            {
                label14.Hide();
            }
            else
            {
                label14.Show();
            }
        }

        private void mpmax_Validated(object sender, EventArgs e)
        {
            int partMax;
            int partMin;
            int partInventory;
            int.TryParse(mpmax.Text, out partMax);
            int.TryParse(mpmin.Text, out partMin);
            if (partMin > partMax)
            {
                label15.Show();
            }
            else
            {
                label15.Hide();
            }
            if (int.TryParse(mpmin.Text, out partMin))
            {
                label12.Hide();
            }
            else
            {
                label12.Show();
            }
            int.TryParse(mpinventory.Text, out partInventory);
            if (partInventory >= partMin && partInventory <= partMax)
            {
                label10.Hide();
            }
            else
            {
                label10.Show();
            }
        }

        private void mpmin_Validated(object sender, EventArgs e)
        {
            int partMax;
            int partMin;
            int partInventory;
            int.TryParse(mpmax.Text, out partMax);
            int.TryParse(mpmin.Text, out partMin);
            if (partMin > partMax)
            {
                label15.Show();
            }
            else
            {
                label15.Hide();
            }
            if (int.TryParse(mpmin.Text, out partMin))
            {
                label12.Hide();
            }
            else
            {
                label12.Show();
            }
            int.TryParse(mpinventory.Text, out partInventory);
            if (partInventory >= partMin && partInventory <= partMax)
            {
                label10.Hide();
            }
            else
            {
                label10.Show();
            }
        }

        private void mpmachineid_Validated(object sender, EventArgs e)
        {
            int partMachineID;
            if (int.TryParse(mpmachineid.Text, out partMachineID))
            {
                label17.Hide();
            }
            else
            {
                label17.Show();
            }
        }

        private void addpartCancel_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void addPartInHouse_CheckedChanged_1(object sender, EventArgs e)
        {
            mpcompanyname.Text = null;
            mpcompanyname.Hide();
            label7.Hide();
            mpmachineid.Show();
            label8.Show();
        }

        private void addPartOutSource_CheckedChanged_1(object sender, EventArgs e)
        {
            mpmachineid.Text = null;
            mpmachineid.Hide();
            label8.Hide();
            mpcompanyname.Show();
            label7.Show();
        }
    }

}
