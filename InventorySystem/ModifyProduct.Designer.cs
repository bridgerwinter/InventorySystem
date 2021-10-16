
namespace InventorySystem
{
    partial class ModifyProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.save = new System.Windows.Forms.Button();
			this.cancel = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.searchBox = new System.Windows.Forms.TextBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.candPartAdd = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.productMin = new System.Windows.Forms.TextBox();
			this.productMax = new System.Windows.Forms.TextBox();
			this.productPrice = new System.Windows.Forms.TextBox();
			this.productInventory = new System.Windows.Forms.TextBox();
			this.productName = new System.Windows.Forms.TextBox();
			this.productID = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// save
			// 
			this.save.Location = new System.Drawing.Point(709, 542);
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(91, 48);
			this.save.TabIndex = 74;
			this.save.Text = "Save";
			this.save.UseVisualStyleBackColor = true;
			this.save.Click += new System.EventHandler(this.save_Click);
			// 
			// cancel
			// 
			this.cancel.Location = new System.Drawing.Point(806, 542);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(91, 48);
			this.cancel.TabIndex = 73;
			this.cancel.Text = "Cancel";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.cancel_Click);
			// 
			// delete
			// 
			this.delete.Location = new System.Drawing.Point(822, 482);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(75, 23);
			this.delete.TabIndex = 72;
			this.delete.Text = "Delete";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// searchBox
			// 
			this.searchBox.Location = new System.Drawing.Point(651, 28);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(181, 20);
			this.searchBox.TabIndex = 71;
			this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(838, 28);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 70;
			this.searchButton.Text = "Search";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(543, 68);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 13);
			this.label7.TabIndex = 69;
			this.label7.Text = "All Candidate Parts";
			// 
			// candPartAdd
			// 
			this.candPartAdd.Location = new System.Drawing.Point(822, 262);
			this.candPartAdd.Name = "candPartAdd";
			this.candPartAdd.Size = new System.Drawing.Size(75, 23);
			this.candPartAdd.TabIndex = 68;
			this.candPartAdd.Text = "Add";
			this.candPartAdd.UseVisualStyleBackColor = true;
			this.candPartAdd.Click += new System.EventHandler(this.candPartAdd_Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView2.Location = new System.Drawing.Point(399, 317);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView2.Size = new System.Drawing.Size(498, 150);
			this.dataGridView2.TabIndex = 67;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView1.Location = new System.Drawing.Point(399, 93);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(498, 150);
			this.dataGridView1.TabIndex = 66;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.Red;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(30, 286);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(236, 13);
			this.label15.TabIndex = 93;
			this.label15.Text = "Inventory must be between Min and Max";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Red;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(145, 363);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(157, 13);
			this.label14.TabIndex = 92;
			this.label14.Text = "Min must be less than Max";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.Red;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(59, 404);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(107, 13);
			this.label13.TabIndex = 91;
			this.label13.Text = "Expecting Integer";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.Red;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(191, 404);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(107, 13);
			this.label12.TabIndex = 90;
			this.label12.Text = "Expecting Integer";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Red;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(225, 343);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(107, 13);
			this.label11.TabIndex = 89;
			this.label11.Text = "Expecting Integer";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Red;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(225, 302);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(107, 13);
			this.label10.TabIndex = 88;
			this.label10.Text = "Expecting Integer";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Red;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(225, 230);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(107, 13);
			this.label9.TabIndex = 87;
			this.label9.Text = "Expecting Integer";
			// 
			// productMin
			// 
			this.productMin.Location = new System.Drawing.Point(198, 381);
			this.productMin.Name = "productMin";
			this.productMin.Size = new System.Drawing.Size(100, 20);
			this.productMin.TabIndex = 86;
			this.productMin.Validated += new System.EventHandler(this.productMin_Validated);
			// 
			// productMax
			// 
			this.productMax.Location = new System.Drawing.Point(62, 380);
			this.productMax.Name = "productMax";
			this.productMax.Size = new System.Drawing.Size(100, 20);
			this.productMax.TabIndex = 85;
			this.productMax.Validated += new System.EventHandler(this.productMax_Validated);
			// 
			// productPrice
			// 
			this.productPrice.Location = new System.Drawing.Point(119, 340);
			this.productPrice.Name = "productPrice";
			this.productPrice.Size = new System.Drawing.Size(100, 20);
			this.productPrice.TabIndex = 84;
			this.productPrice.Validated += new System.EventHandler(this.productPrice_Validated);
			// 
			// productInventory
			// 
			this.productInventory.Location = new System.Drawing.Point(119, 302);
			this.productInventory.Name = "productInventory";
			this.productInventory.Size = new System.Drawing.Size(100, 20);
			this.productInventory.TabIndex = 83;
			this.productInventory.Validated += new System.EventHandler(this.productInventory_Validated);
			// 
			// productName
			// 
			this.productName.Location = new System.Drawing.Point(119, 263);
			this.productName.Name = "productName";
			this.productName.Size = new System.Drawing.Size(100, 20);
			this.productName.TabIndex = 82;
			// 
			// productID
			// 
			this.productID.Location = new System.Drawing.Point(119, 223);
			this.productID.Name = "productID";
			this.productID.Size = new System.Drawing.Size(100, 20);
			this.productID.TabIndex = 81;
			this.productID.Validated += new System.EventHandler(this.productID_Validated);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(168, 384);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(24, 13);
			this.label6.TabIndex = 80;
			this.label6.Text = "Min";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(30, 383);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(27, 13);
			this.label5.TabIndex = 79;
			this.label5.Text = "Max";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(23, 343);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 13);
			this.label4.TabIndex = 78;
			this.label4.Text = "Price/Cost";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 305);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 13);
			this.label3.TabIndex = 77;
			this.label3.Text = "Inventory";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(30, 266);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 76;
			this.label2.Text = "Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 226);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 75;
			this.label1.Text = "ID";
			// 
			// ModifyProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(924, 641);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.productMin);
			this.Controls.Add(this.productMax);
			this.Controls.Add(this.productPrice);
			this.Controls.Add(this.productInventory);
			this.Controls.Add(this.productName);
			this.Controls.Add(this.productID);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.save);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.searchBox);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.candPartAdd);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.Name = "ModifyProduct";
			this.Text = "Modify Product";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button candPartAdd;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox productMin;
        private System.Windows.Forms.TextBox productMax;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.TextBox productInventory;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.TextBox productID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}