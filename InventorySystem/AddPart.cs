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
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
            addPartCompanyName.Text = null;
            addPartCompanyName.Hide();
            label8.Hide();
            addPartMachineID.Show();
            label7.Show();

            label9.Hide();
            label10.Hide();
            label11.Hide();
            label13.Hide();
            label14.Hide();
            label15.Hide();
            label16.Hide();
            label17.Hide();
        }

        private void addpartCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addpartSave_Click(object sender, EventArgs e)
        {
            int partMachineID;
            int partMax;
            int partMin;
            int partInventory;
            decimal partPrice;
            int partID;
            int.TryParse(addPartID.Text, out partID);
            string partName = addPartName.Text;
            decimal.TryParse(addPartPrice.Text, out partPrice);
            int.TryParse(addPartInventory.Text, out partInventory);
            int.TryParse(addPartMin.Text, out partMin);
            int.TryParse(addPartMax.Text, out partMax);
            string partCompanyName = addPartCompanyName.Text;
            int.TryParse(addPartMachineID.Text, out partMachineID);
            try
            {
                //int partMachineID = int.Parse(addPartMachineID.Text);
                if (partCompanyName == "")
                {
                    Part part = new InHouse(partID, partName, partPrice, partInventory, partMin, partMax, partMachineID);
                    Inventory.AllParts.Add(part);
                }
                else
                {
                    Part part = new Outsource(partID, partName, partPrice, partInventory, partMin, partMax, partCompanyName);
                    Inventory.AllParts.Add(part);
                }
            }
            catch(Exception)
            {
            }
            Close();

        }

        private void addPartInHouse_CheckedChanged(object sender, EventArgs e)
        {
           
            addPartCompanyName.Text = null;
            addPartCompanyName.Hide();
            label8.Hide();
            addPartMachineID.Show();
            label7.Show();
        }

        private void addPartOutSource_CheckedChanged(object sender, EventArgs e)
        {
            addPartMachineID.Text = null;
            addPartMachineID.Hide();
            label7.Hide();
            addPartCompanyName.Show();
            label8.Show();
        }

        private void addPartMin_Validated(object sender, EventArgs e)
        {
            int partMax;
            int partMin;
            int partInventory;
            int.TryParse(addPartMax.Text, out partMax);
            int.TryParse(addPartMin.Text, out partMin);
            if (partMin > partMax)
            {
                label9.Show();
            }
            else
            {
                label9.Hide();
            }
            if(int.TryParse(addPartMin.Text,out partMin))
            {
                label16.Hide();
            }
            else
            {
                label16.Show();
            }
            int.TryParse(addPartInventory.Text, out partInventory);
            if (partInventory >= partMin && partInventory <= partMax)
            {
                label10.Hide();
            }
            else
            {
                label10.Show();
            }
        }

        private void addPartInventory_Validated(object sender, EventArgs e)
        {
            int partMax;
            int partMin;
            int partInventory;
            int.TryParse(addPartMax.Text, out partMax);
            int.TryParse(addPartMin.Text, out partMin);
            int.TryParse(addPartInventory.Text, out partInventory);
            if (partInventory >= partMin && partInventory <= partMax)
            {
                label10.Hide();
            }
            else
            {
                label10.Show();
            }
            if (int.TryParse(addPartInventory.Text, out partInventory))
            {
                label13.Hide();
            }
            else
            {
                label13.Show();
            }
        }

        private void addPartMax_Validated(object sender, EventArgs e)
        {
            int partMax;
            int partMin;
            int partInventory;

            int.TryParse(addPartMax.Text, out partMax);
            int.TryParse(addPartMin.Text, out partMin);
            if (partMin > partMax)
            {
                label9.Show();
            }
            else
            {
                label9.Hide();
            }
            if (int.TryParse(addPartMax.Text, out partMax))
            {
                label15.Hide();
            }
            else
            {
                label15.Show();
            }
            int.TryParse(addPartInventory.Text, out partInventory);
            if (partInventory >= partMin && partInventory <= partMax)
            {
                label10.Hide();
            }
            else
            {
                label10.Show();
            }
        }

        private void addPartPrice_Validated(object sender, EventArgs e)
        {
            decimal partPrice;
            if (decimal.TryParse(addPartPrice.Text, out partPrice))
            {
                label14.Hide();
            }
            else
            {
                label14.Show();
            }
        }

        private void addPartID_Validated(object sender, EventArgs e)
        {
            int partID;
            if (int.TryParse(addPartID.Text, out partID))
            {
                label11.Hide();
            }
            else
            {
                label11.Show();
            }
        }

        private void addPartMachineID_Validated(object sender, EventArgs e)
        {
            int partMachineID;
            if (int.TryParse(addPartID.Text, out partMachineID))
            {
                label17.Hide();
            }
            else
            {
                label17.Show();
            }
        }
    }
}
