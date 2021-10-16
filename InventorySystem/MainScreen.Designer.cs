
namespace InventorySystem
{
    partial class MainScreen
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.partSearch = new System.Windows.Forms.TextBox();
            this.productSearch = new System.Windows.Forms.TextBox();
            this.partButton = new System.Windows.Forms.Button();
            this.productButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.partsAdd = new System.Windows.Forms.Button();
            this.partsModify = new System.Windows.Forms.Button();
            this.partsDelete = new System.Windows.Forms.Button();
            this.productsAdd = new System.Windows.Forms.Button();
            this.productsModify = new System.Windows.Forms.Button();
            this.productsDelete = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.outsourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // partSearch
            // 
            this.partSearch.Location = new System.Drawing.Point(127, 64);
            this.partSearch.Name = "partSearch";
            this.partSearch.Size = new System.Drawing.Size(171, 20);
            this.partSearch.TabIndex = 1;
            this.partSearch.TextChanged += new System.EventHandler(this.partSearch_TextChanged);
            // 
            // productSearch
            // 
            this.productSearch.Location = new System.Drawing.Point(1098, 66);
            this.productSearch.Name = "productSearch";
            this.productSearch.Size = new System.Drawing.Size(171, 20);
            this.productSearch.TabIndex = 2;
            this.productSearch.TextChanged += new System.EventHandler(this.productSearch_TextChanged);
            // 
            // partButton
            // 
            this.partButton.Location = new System.Drawing.Point(304, 64);
            this.partButton.Name = "partButton";
            this.partButton.Size = new System.Drawing.Size(75, 23);
            this.partButton.TabIndex = 3;
            this.partButton.Text = "Search";
            this.partButton.UseVisualStyleBackColor = true;
            // 
            // productButton
            // 
            this.productButton.Location = new System.Drawing.Point(1275, 64);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(75, 23);
            this.productButton.TabIndex = 4;
            this.productButton.Text = "Search";
            this.productButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1008, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Products";
            // 
            // partsAdd
            // 
            this.partsAdd.Location = new System.Drawing.Point(15, 334);
            this.partsAdd.Name = "partsAdd";
            this.partsAdd.Size = new System.Drawing.Size(88, 35);
            this.partsAdd.TabIndex = 9;
            this.partsAdd.Text = "Add";
            this.partsAdd.UseVisualStyleBackColor = true;
            this.partsAdd.Click += new System.EventHandler(this.partsAdd_Click);
            // 
            // partsModify
            // 
            this.partsModify.Location = new System.Drawing.Point(137, 334);
            this.partsModify.Name = "partsModify";
            this.partsModify.Size = new System.Drawing.Size(88, 35);
            this.partsModify.TabIndex = 10;
            this.partsModify.Text = "Modify";
            this.partsModify.UseVisualStyleBackColor = true;
            this.partsModify.Click += new System.EventHandler(this.partsModify_Click);
            // 
            // partsDelete
            // 
            this.partsDelete.Location = new System.Drawing.Point(257, 334);
            this.partsDelete.Name = "partsDelete";
            this.partsDelete.Size = new System.Drawing.Size(88, 35);
            this.partsDelete.TabIndex = 11;
            this.partsDelete.Text = "Delete";
            this.partsDelete.UseVisualStyleBackColor = true;
            this.partsDelete.Click += new System.EventHandler(this.partsDelete_Click);
            // 
            // productsAdd
            // 
            this.productsAdd.Location = new System.Drawing.Point(1009, 334);
            this.productsAdd.Name = "productsAdd";
            this.productsAdd.Size = new System.Drawing.Size(97, 37);
            this.productsAdd.TabIndex = 12;
            this.productsAdd.Text = "Add";
            this.productsAdd.UseVisualStyleBackColor = true;
            this.productsAdd.Click += new System.EventHandler(this.productsAdd_Click);
            // 
            // productsModify
            // 
            this.productsModify.Location = new System.Drawing.Point(1128, 334);
            this.productsModify.Name = "productsModify";
            this.productsModify.Size = new System.Drawing.Size(97, 37);
            this.productsModify.TabIndex = 13;
            this.productsModify.Text = "Modify";
            this.productsModify.UseVisualStyleBackColor = true;
            this.productsModify.Click += new System.EventHandler(this.productsModify_Click);
            // 
            // productsDelete
            // 
            this.productsDelete.Location = new System.Drawing.Point(1251, 334);
            this.productsDelete.Name = "productsDelete";
            this.productsDelete.Size = new System.Drawing.Size(97, 37);
            this.productsDelete.TabIndex = 14;
            this.productsDelete.Text = "Delete";
            this.productsDelete.UseVisualStyleBackColor = true;
            this.productsDelete.Click += new System.EventHandler(this.productsDelete_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(641, 399);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(101, 46);
            this.exit.TabIndex = 15;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(17, 108);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(645, 206);
            this.dataGridView1.TabIndex = 16;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(724, 108);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(625, 206);
            this.dataGridView2.TabIndex = 17;
            // 
            // outsourceBindingSource
            // 
            this.outsourceBindingSource.DataSource = typeof(InventorySystem.Outsource);
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataSource = typeof(InventorySystem.Inventory);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 470);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.productsDelete);
            this.Controls.Add(this.productsModify);
            this.Controls.Add(this.productsAdd);
            this.Controls.Add(this.partsDelete);
            this.Controls.Add(this.partsModify);
            this.Controls.Add(this.partsAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productButton);
            this.Controls.Add(this.partButton);
            this.Controls.Add(this.productSearch);
            this.Controls.Add(this.partSearch);
            this.Controls.Add(this.label1);
            this.Name = "MainScreen";
            this.Text = "IMS ";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.Enter += new System.EventHandler(this.MainScreen_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox partSearch;
        private System.Windows.Forms.TextBox productSearch;
        private System.Windows.Forms.Button partButton;
        private System.Windows.Forms.Button productButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button partsAdd;
        private System.Windows.Forms.Button partsModify;
        private System.Windows.Forms.Button partsDelete;
        private System.Windows.Forms.Button productsAdd;
        private System.Windows.Forms.Button productsModify;
        private System.Windows.Forms.Button productsDelete;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.BindingSource outsourceBindingSource;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

