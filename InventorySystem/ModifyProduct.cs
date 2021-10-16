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
    public partial class ModifyProduct : Form
    {
        public BindingList<Part> dgArray = new BindingList<Part>();

        public ModifyProduct(Product product)
        {
            InitializeComponent();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();
            label15.Hide();

            productName.Text = product.Name;
            productInventory.Text = product.InStock.ToString();
            productMax.Text = product.Max.ToString();
            productMin.Text = product.Min.ToString();
            productID.Text = product.ProductID.ToString();
            productPrice.Text = product.Price.ToString();
            dgArray = product.AssociatedParts;
            dataGridView2.DataSource = product.AssociatedParts;
            dataGridView1.DataSource = Inventory.AllParts;
            dataGridView1.Rows[0].Selected = false;
        }

        private void productID_Validated(object sender, EventArgs e)
        {
            int partID;
            if (int.TryParse(productID.Text, out partID))
            {
                label9.Hide();
            }
            else
            {
                label9.Show();
            }
        }

        private void productInventory_Validated(object sender, EventArgs e)
        {
            int partMax;
            int partMin;
            int partInventory;
            int.TryParse(productMax.Text, out partMax);
            int.TryParse(productMin.Text, out partMin);
            int.TryParse(productInventory.Text, out partInventory);
            if (int.TryParse(productInventory.Text, out partInventory))
            {
                label10.Hide();
            }
            else
            {
                label10.Show();
            }
            if (partInventory >= partMin && partInventory <= partMax)
            {
                label15.Hide();
            }
            else
            {
                label15.Show();
            }
        }

        private void productPrice_Validated(object sender, EventArgs e)
        {
            decimal partPrice;
            if (decimal.TryParse(productPrice.Text, out partPrice))
            {
                label11.Hide();
            }
            else
            {
                label11.Show();
            }
        }

        private void productMax_Validated(object sender, EventArgs e)
        {
            int partMax;
            int partMin;
            int partInventory;
            int.TryParse(productMax.Text, out partMax);
            int.TryParse(productMin.Text, out partMin);
            if (partMin > partMax)
            {
                label14.Show();
            }
            else
            {
                label14.Hide();
            }
            if (int.TryParse(productMax.Text, out partMin))
            {
                label13.Hide();
            }
            else
            {
                label13.Show();
            }
            int.TryParse(productInventory.Text, out partInventory);
            if (partInventory >= partMin && partInventory <= partMax)
            {
                label15.Hide();
            }
            else
            {
                label15.Show();
            }
        }

        private void productMin_Validated(object sender, EventArgs e)
        {
            int partMax;
            int partMin;
            int partInventory;
            int.TryParse(productMax.Text, out partMax);
            int.TryParse(productMin.Text, out partMin);
            if (partMin > partMax)
            {
                label14.Show();
            }
            else
            {
                label14.Hide();
            }
            if (int.TryParse(productMin.Text, out partMin))
            {
                label12.Hide();
            }
            else
            {
                label12.Show();
            }
            int.TryParse(productInventory.Text, out partInventory);
            if (partInventory >= partMin && partInventory <= partMax)
            {
                label15.Hide();
            }
            else
            {
                label15.Show();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void candPartAdd_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection d = dataGridView1.SelectedRows;
            if (d.Count == 0)
            {
                MessageBox.Show("Please select a row");
            }
            else
            {
                var data = dataGridView1.SelectedRows;
                int indexOfRow = dataGridView1.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataGridView1.Rows[indexOfRow];
                string colData = dataGridView1.Rows[indexOfRow].Cells[0].Value.ToString();
                int partID = int.Parse(colData);
                Part part = Inventory.lookupPart(partID);
                dgArray.Add(part);
                dataGridView2.DataSource = dgArray;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            int prodMax;
            int prodMin;
            int prodInventory;
            decimal prodPrice;
            int prodID;
            int.TryParse(productID.Text, out prodID);
            string prodName = productName.Text;
            decimal.TryParse(productPrice.Text, out prodPrice);
            int.TryParse(productInventory.Text, out prodInventory);
            int.TryParse(productMin.Text, out prodMin);
            int.TryParse(productMax.Text, out prodMax);
            Product product = new Product(prodID, prodName, prodPrice, prodInventory, prodMin, prodMax);
            if (label9.Visible == true || label10.Visible == true || label11.Visible == true || label12.Visible == true || label13.Visible == true
                || label14.Visible == true || label15.Visible)
            {
                MessageBox.Show("Please make correction on product values");
            }
            else
            {
                product.AssociatedParts = dgArray;
                Inventory.updateProduct(prodID, product);
                Close();
            }
        }
        private void delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection d = dataGridView2.SelectedRows;
            if (d.Count == 0)
            {
                MessageBox.Show("Please select a row");
            }
            else
            {
                var data = dataGridView2.SelectedRows;
                int indexOfRow = dataGridView2.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataGridView2.Rows[indexOfRow];
                string colData = dataGridView2.Rows[indexOfRow].Cells[0].Value.ToString();
                int partID = int.Parse(colData);
                Part part = Inventory.lookupPart(partID);
                dgArray.Remove(part);
                dataGridView2.DataSource = dgArray;
            }
        }

		private void searchBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void searchButton_Click(object sender, EventArgs e)
		{

		}
	}
}
