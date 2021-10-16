
namespace InventorySystem
{
    partial class ModifyPart
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
            this.addpartCancel = new System.Windows.Forms.Button();
            this.modfiypartSave = new System.Windows.Forms.Button();
            this.mpmin = new System.Windows.Forms.TextBox();
            this.mpmax = new System.Windows.Forms.TextBox();
            this.mpprice = new System.Windows.Forms.TextBox();
            this.mpinventory = new System.Windows.Forms.TextBox();
            this.mpname = new System.Windows.Forms.TextBox();
            this.mppartid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mpcompanyname = new System.Windows.Forms.TextBox();
            this.mpmachineid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.addPartOutSource = new System.Windows.Forms.RadioButton();
            this.addPartInHouse = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // addpartCancel
            // 
            this.addpartCancel.Location = new System.Drawing.Point(249, 312);
            this.addpartCancel.Name = "addpartCancel";
            this.addpartCancel.Size = new System.Drawing.Size(75, 23);
            this.addpartCancel.TabIndex = 35;
            this.addpartCancel.Text = "Cancel";
            this.addpartCancel.UseVisualStyleBackColor = true;
            this.addpartCancel.Click += new System.EventHandler(this.addpartCancel_Click);
            // 
            // modfiypartSave
            // 
            this.modfiypartSave.Location = new System.Drawing.Point(88, 312);
            this.modfiypartSave.Name = "modfiypartSave";
            this.modfiypartSave.Size = new System.Drawing.Size(75, 23);
            this.modfiypartSave.TabIndex = 34;
            this.modfiypartSave.Text = "Save";
            this.modfiypartSave.UseVisualStyleBackColor = true;
            this.modfiypartSave.Click += new System.EventHandler(this.modfiypartSave_Click);
            // 
            // mpmin
            // 
            this.mpmin.Location = new System.Drawing.Point(238, 213);
            this.mpmin.Name = "mpmin";
            this.mpmin.Size = new System.Drawing.Size(100, 20);
            this.mpmin.TabIndex = 32;
            this.mpmin.Validated += new System.EventHandler(this.mpmin_Validated);
            // 
            // mpmax
            // 
            this.mpmax.Location = new System.Drawing.Point(88, 213);
            this.mpmax.Name = "mpmax";
            this.mpmax.Size = new System.Drawing.Size(100, 20);
            this.mpmax.TabIndex = 31;
            this.mpmax.Validated += new System.EventHandler(this.mpmax_Validated);
            // 
            // mpprice
            // 
            this.mpprice.Location = new System.Drawing.Point(88, 173);
            this.mpprice.Name = "mpprice";
            this.mpprice.Size = new System.Drawing.Size(100, 20);
            this.mpprice.TabIndex = 30;
            this.mpprice.Validated += new System.EventHandler(this.mpprice_Validated);
            // 
            // mpinventory
            // 
            this.mpinventory.Location = new System.Drawing.Point(88, 132);
            this.mpinventory.Name = "mpinventory";
            this.mpinventory.Size = new System.Drawing.Size(100, 20);
            this.mpinventory.TabIndex = 29;
            this.mpinventory.TextChanged += new System.EventHandler(this.mpinventory_Validated);
            // 
            // mpname
            // 
            this.mpname.Location = new System.Drawing.Point(88, 93);
            this.mpname.Name = "mpname";
            this.mpname.Size = new System.Drawing.Size(100, 20);
            this.mpname.TabIndex = 28;
            // 
            // mppartid
            // 
            this.mppartid.Location = new System.Drawing.Point(88, 53);
            this.mppartid.Name = "mppartid";
            this.mppartid.Size = new System.Drawing.Size(100, 20);
            this.mppartid.TabIndex = 27;
            this.mppartid.TextChanged += new System.EventHandler(this.mppartid_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Price/Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID";
            // 
            // mpcompanyname
            // 
            this.mpcompanyname.Location = new System.Drawing.Point(88, 267);
            this.mpcompanyname.Name = "mpcompanyname";
            this.mpcompanyname.Size = new System.Drawing.Size(100, 20);
            this.mpcompanyname.TabIndex = 36;
            // 
            // mpmachineid
            // 
            this.mpmachineid.Location = new System.Drawing.Point(88, 267);
            this.mpmachineid.Name = "mpmachineid";
            this.mpmachineid.Size = new System.Drawing.Size(100, 20);
            this.mpmachineid.TabIndex = 37;
            this.mpmachineid.Validated += new System.EventHandler(this.mpmachineid_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Company Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "MachineID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Red;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(193, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 13);
            this.label14.TabIndex = 50;
            this.label14.Text = "Expecting Integer";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Red;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(193, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "Expecting Integer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(193, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Expecting Integer";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Red;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(236, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Inventory must be between Min and Max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(194, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Min must be less than Max.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Red;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(81, 290);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 13);
            this.label17.TabIndex = 51;
            this.label17.Text = "Expecting Integer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Red;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(81, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "Expecting Integer";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Red;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(231, 237);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 13);
            this.label15.TabIndex = 53;
            this.label15.Text = "Expecting Integer";
            // 
            // addPartOutSource
            // 
            this.addPartOutSource.AutoSize = true;
            this.addPartOutSource.Location = new System.Drawing.Point(205, 12);
            this.addPartOutSource.Name = "addPartOutSource";
            this.addPartOutSource.Size = new System.Drawing.Size(80, 17);
            this.addPartOutSource.TabIndex = 55;
            this.addPartOutSource.Text = "Outsourced";
            this.addPartOutSource.UseVisualStyleBackColor = true;
            this.addPartOutSource.CheckedChanged += new System.EventHandler(this.addPartOutSource_CheckedChanged_1);
            // 
            // addPartInHouse
            // 
            this.addPartInHouse.AutoSize = true;
            this.addPartInHouse.Checked = true;
            this.addPartInHouse.Location = new System.Drawing.Point(88, 12);
            this.addPartInHouse.Name = "addPartInHouse";
            this.addPartInHouse.Size = new System.Drawing.Size(68, 17);
            this.addPartInHouse.TabIndex = 54;
            this.addPartInHouse.TabStop = true;
            this.addPartInHouse.Text = "In-House";
            this.addPartInHouse.UseVisualStyleBackColor = true;
            this.addPartInHouse.CheckedChanged += new System.EventHandler(this.addPartInHouse_CheckedChanged_1);
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(394, 385);
            this.Controls.Add(this.addPartOutSource);
            this.Controls.Add(this.addPartInHouse);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mpmachineid);
            this.Controls.Add(this.mpcompanyname);
            this.Controls.Add(this.addpartCancel);
            this.Controls.Add(this.modfiypartSave);
            this.Controls.Add(this.mpmin);
            this.Controls.Add(this.mpmax);
            this.Controls.Add(this.mpprice);
            this.Controls.Add(this.mpinventory);
            this.Controls.Add(this.mpname);
            this.Controls.Add(this.mppartid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifyPart";
            this.Text = "Modify Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addpartCancel;
        private System.Windows.Forms.Button modfiypartSave;
        private System.Windows.Forms.TextBox mpmin;
        private System.Windows.Forms.TextBox mpmax;
        private System.Windows.Forms.TextBox mpprice;
        private System.Windows.Forms.TextBox mpinventory;
        private System.Windows.Forms.TextBox mpname;
        private System.Windows.Forms.TextBox mppartid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mpcompanyname;
        private System.Windows.Forms.TextBox mpmachineid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton addPartOutSource;
        private System.Windows.Forms.RadioButton addPartInHouse;
    }
}