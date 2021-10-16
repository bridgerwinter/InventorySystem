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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            dataGridView1.DataSource = Inventory.AllParts;
            dataGridView2.DataSource = Inventory.Products;

            //BindingList's do not support sorting.
            //this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void partsAdd_Click(object sender, EventArgs e)
        {
            AddPart ap = new AddPart();
            ap.ShowDialog();
        }

        private void partsModify_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection d = dataGridView1.SelectedRows;
            if (d.Count == 0)
            {
                MessageBox.Show("Please select a row");
            }
            else
            {
                int indexOfRow = dataGridView1.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataGridView1.Rows[indexOfRow];
                string colData = dataGridView1.Rows[indexOfRow].Cells[0].Value.ToString();
                int partID = int.Parse(colData);
                Part part = Inventory.lookupPart(partID);

                
                ModifyPart modifypart = new ModifyPart(part);

                modifypart.Show();
            }
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Selected = false;
            dataGridView2.Rows[0].Selected = false;
        }

        private void MainScreen_Enter(object sender, EventArgs e)
        {
        }


        private void partsDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection d = dataGridView1.SelectedRows;
            if (d.Count == 0)
            {
                MessageBox.Show("Please select a row");
            }
            else
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    var data = dataGridView1.SelectedRows;
                    int indexOfRow = dataGridView1.SelectedRows[0].Index;
                    DataGridViewRow selectedRow = dataGridView1.Rows[indexOfRow];
                    string colData = dataGridView1.Rows[indexOfRow].Cells[0].Value.ToString();
                    int partID = int.Parse(colData);
                    Part part = Inventory.lookupPart(partID);

                    Inventory.deletePart(part);
                }
                else
                {
                    //just relax no worries lil program you're doing your best
                }

            }
        }
        private void partSearch_TextChanged(object sender, EventArgs e)
        {
            if (partSearch.Text == null)
            {
            }
            else
            {
                dataGridView1.DataSource = Inventory.AllParts.Where(x => x.Name.Contains(partSearch.Text)).ToList();
            }
        }

        private void productSearch_TextChanged(object sender, EventArgs e)
        {
            if (productSearch.Text == null)
            {
            }
            else
            {
                dataGridView2.DataSource = Inventory.Products.Where(x => x.Name.Contains(productSearch.Text)).ToList();
            }
        }

        private void productsAdd_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct();
            ap.ShowDialog();
        }
        private void productsModify_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection d = dataGridView2.SelectedRows;
            if (d.Count == 0)
            {
                MessageBox.Show("Please select a row");
            }
            else
            {
                int indexOfRow = dataGridView2.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataGridView2.Rows[indexOfRow];
                string colData = dataGridView2.Rows[indexOfRow].Cells[0].Value.ToString();
                int prodID = int.Parse(colData);
                Product product = Inventory.lookupProduct(prodID);
                

              ModifyProduct modifyProduct = new ModifyProduct(product);

              modifyProduct.Show();
            }
        }

        private void productsDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection d = dataGridView2.SelectedRows;
            if (d.Count == 0)
            {
                MessageBox.Show("Please select a row");
            }
            else
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    var data = dataGridView2.SelectedRows;
                    int indexOfRow = dataGridView2.SelectedRows[0].Index;
                    DataGridViewRow selectedRow = dataGridView2.Rows[indexOfRow];
                    string colData = dataGridView2.Rows[indexOfRow].Cells[0].Value.ToString();
                    int ProductID = int.Parse(colData);
                    Product product = Inventory.lookupProduct(ProductID);
                    if (product.AssociatedParts.Count != 0)
                    {
                        MessageBox.Show("You can't delete an object with parts associated with it.", "Confirm Deletion", MessageBoxButtons.OK);
                    }
                    else
                    {
                        Inventory.removeProduct(ProductID);

                    }
                }
                else
                {
                    //just relax no worries lil program you're doing your best
                }

            }
        }

    }
}
