
namespace InventorySystem
{
    partial class AddPart
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
            this.addPartInHouse = new System.Windows.Forms.RadioButton();
            this.addPartOutSource = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addPartID = new System.Windows.Forms.TextBox();
            this.addPartName = new System.Windows.Forms.TextBox();
            this.addPartInventory = new System.Windows.Forms.TextBox();
            this.addPartPrice = new System.Windows.Forms.TextBox();
            this.addPartMax = new System.Windows.Forms.TextBox();
            this.addPartMin = new System.Windows.Forms.TextBox();
            this.addPartMachineID = new System.Windows.Forms.TextBox();
            this.addpartSave = new System.Windows.Forms.Button();
            this.addpartCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.addPartCompanyName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addPartInHouse
            // 
            this.addPartInHouse.AutoSize = true;
            this.addPartInHouse.Checked = true;
            this.addPartInHouse.Location = new System.Drawing.Point(88, 26);
            this.addPartInHouse.Name = "addPartInHouse";
            this.addPartInHouse.Size = new System.Drawing.Size(68, 17);
            this.addPartInHouse.TabIndex = 0;
            this.addPartInHouse.TabStop = true;
            this.addPartInHouse.Text = "In-House";
            this.addPartInHouse.UseVisualStyleBackColor = true;
            this.addPartInHouse.CheckedChanged += new System.EventHandler(this.addPartInHouse_CheckedChanged);
            // 
            // addPartOutSource
            // 
            this.addPartOutSource.AutoSize = true;
            this.addPartOutSource.Location = new System.Drawing.Point(205, 26);
            this.addPartOutSource.Name = "addPartOutSource";
            this.addPartOutSource.Size = new System.Drawing.Size(80, 17);
            this.addPartOutSource.TabIndex = 1;
            this.addPartOutSource.Text = "Outsourced";
            this.addPartOutSource.UseVisualStyleBackColor = true;
            this.addPartOutSource.CheckedChanged += new System.EventHandler(this.addPartOutSource_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price/Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Machine ID";
            // 
            // addPartID
            // 
            this.addPartID.Location = new System.Drawing.Point(92, 70);
            this.addPartID.Name = "addPartID";
            this.addPartID.Size = new System.Drawing.Size(100, 20);
            this.addPartID.TabIndex = 9;
            this.addPartID.Validated += new System.EventHandler(this.addPartID_Validated);
            // 
            // addPartName
            // 
            this.addPartName.Location = new System.Drawing.Point(92, 106);
            this.addPartName.Name = "addPartName";
            this.addPartName.Size = new System.Drawing.Size(100, 20);
            this.addPartName.TabIndex = 10;
            // 
            // addPartInventory
            // 
            this.addPartInventory.Location = new System.Drawing.Point(92, 149);
            this.addPartInventory.Name = "addPartInventory";
            this.addPartInventory.Size = new System.Drawing.Size(100, 20);
            this.addPartInventory.TabIndex = 11;
            this.addPartInventory.Validated += new System.EventHandler(this.addPartInventory_Validated);
            // 
            // addPartPrice
            // 
            this.addPartPrice.Location = new System.Drawing.Point(92, 192);
            this.addPartPrice.Name = "addPartPrice";
            this.addPartPrice.Size = new System.Drawing.Size(100, 20);
            this.addPartPrice.TabIndex = 12;
            this.addPartPrice.Validated += new System.EventHandler(this.addPartPrice_Validated);
            // 
            // addPartMax
            // 
            this.addPartMax.Location = new System.Drawing.Point(92, 239);
            this.addPartMax.Name = "addPartMax";
            this.addPartMax.Size = new System.Drawing.Size(100, 20);
            this.addPartMax.TabIndex = 13;
            this.addPartMax.Validated += new System.EventHandler(this.addPartMax_Validated);
            // 
            // addPartMin
            // 
            this.addPartMin.Location = new System.Drawing.Point(286, 239);
            this.addPartMin.Name = "addPartMin";
            this.addPartMin.Size = new System.Drawing.Size(100, 20);
            this.addPartMin.TabIndex = 14;
            this.addPartMin.Validated += new System.EventHandler(this.addPartMin_Validated);
            // 
            // addPartMachineID
            // 
            this.addPartMachineID.Location = new System.Drawing.Point(92, 290);
            this.addPartMachineID.Name = "addPartMachineID";
            this.addPartMachineID.Size = new System.Drawing.Size(100, 20);
            this.addPartMachineID.TabIndex = 15;
            this.addPartMachineID.Validated += new System.EventHandler(this.addPartMachineID_Validated);
            // 
            // addpartSave
            // 
            this.addpartSave.Location = new System.Drawing.Point(39, 344);
            this.addpartSave.Name = "addpartSave";
            this.addpartSave.Size = new System.Drawing.Size(75, 23);
            this.addpartSave.TabIndex = 16;
            this.addpartSave.Text = "Save";
            this.addpartSave.UseVisualStyleBackColor = true;
            this.addpartSave.Click += new System.EventHandler(this.addpartSave_Click);
            // 
            // addpartCancel
            // 
            this.addpartCancel.Location = new System.Drawing.Point(243, 344);
            this.addpartCancel.Name = "addpartCancel";
            this.addpartCancel.Size = new System.Drawing.Size(75, 23);
            this.addpartCancel.TabIndex = 17;
            this.addpartCancel.Text = "Cancel";
            this.addpartCancel.UseVisualStyleBackColor = true;
            this.addpartCancel.Click += new System.EventHandler(this.addpartCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Company Name";
            // 
            // addPartCompanyName
            // 
            this.addPartCompanyName.Location = new System.Drawing.Point(92, 290);
            this.addPartCompanyName.Name = "addPartCompanyName";
            this.addPartCompanyName.Size = new System.Drawing.Size(100, 20);
            this.addPartCompanyName.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(225, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Min must be less than Max.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Red;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(236, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Inventory must be between Min and Max";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(199, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Expecting Integer";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Red;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(198, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Expecting Integer";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Red;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(198, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Expecting Integer";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Red;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(89, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 13);
            this.label15.TabIndex = 46;
            this.label15.Text = "Expecting Integer";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Red;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(283, 262);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 13);
            this.label16.TabIndex = 47;
            this.label16.Text = "Expecting Integer";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Red;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(76, 313);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 13);
            this.label17.TabIndex = 48;
            this.label17.Text = "Expecting Integer";
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 379);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addPartCompanyName);
            this.Controls.Add(this.addpartCancel);
            this.Controls.Add(this.addpartSave);
            this.Controls.Add(this.addPartMachineID);
            this.Controls.Add(this.addPartMin);
            this.Controls.Add(this.addPartMax);
            this.Controls.Add(this.addPartPrice);
            this.Controls.Add(this.addPartInventory);
            this.Controls.Add(this.addPartName);
            this.Controls.Add(this.addPartID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addPartOutSource);
            this.Controls.Add(this.addPartInHouse);
            this.Name = "AddPart";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton addPartInHouse;
        private System.Windows.Forms.RadioButton addPartOutSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addPartID;
        private System.Windows.Forms.TextBox addPartName;
        private System.Windows.Forms.TextBox addPartInventory;
        private System.Windows.Forms.TextBox addPartPrice;
        private System.Windows.Forms.TextBox addPartMax;
        private System.Windows.Forms.TextBox addPartMin;
        private System.Windows.Forms.TextBox addPartMachineID;
        private System.Windows.Forms.Button addpartSave;
        private System.Windows.Forms.Button addpartCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox addPartCompanyName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}