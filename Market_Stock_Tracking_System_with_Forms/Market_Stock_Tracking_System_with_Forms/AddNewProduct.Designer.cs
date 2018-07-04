namespace Market_Stock_Tracking_System_with_Forms
{
    partial class AddNewProduct
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
            this.AddProductButton = new System.Windows.Forms.Button();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Unit = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.UnitTypesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(215, 258);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(118, 23);
            this.AddProductButton.TabIndex = 0;
            this.AddProductButton.Text = "Add New Product";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.IDTextBox.Location = new System.Drawing.Point(183, 40);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(150, 20);
            this.IDTextBox.TabIndex = 1;
            this.IDTextBox.Text = "Please enter Product ID";
            this.IDTextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.NameTextBox.Location = new System.Drawing.Point(183, 90);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(150, 20);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.Text = "Please enter Product Name";
            this.NameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.QuantityTextBox.Location = new System.Drawing.Point(183, 190);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(150, 20);
            this.QuantityTextBox.TabIndex = 3;
            this.QuantityTextBox.Text = "Please enter Product Quantity";
            this.QuantityTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(35, 40);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(58, 13);
            this.ID.TabIndex = 4;
            this.ID.Text = "Product ID";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(35, 90);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(75, 13);
            this.Name.TabIndex = 5;
            this.Name.Text = "Product Name";
            // 
            // Unit
            // 
            this.Unit.AutoSize = true;
            this.Unit.Location = new System.Drawing.Point(35, 140);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(66, 13);
            this.Unit.TabIndex = 6;
            this.Unit.Text = "Product Unit";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(35, 190);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(86, 13);
            this.Quantity.TabIndex = 7;
            this.Quantity.Text = "Product Quantity";
            // 
            // UnitTypesListBox
            // 
            this.UnitTypesListBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.UnitTypesListBox.FormattingEnabled = true;
            this.UnitTypesListBox.Location = new System.Drawing.Point(183, 140);
            this.UnitTypesListBox.Name = "UnitTypesListBox";
            this.UnitTypesListBox.Size = new System.Drawing.Size(150, 30);
            this.UnitTypesListBox.TabIndex = 8;
            this.UnitTypesListBox.SelectedIndexChanged += new System.EventHandler(this.UnitTypes_SelectedIndexChanged);
            // 
            // AddNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 334);
            this.Controls.Add(this.UnitTypesListBox);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Unit);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.AddProductButton);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Unit;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.ListBox UnitTypesListBox;
    }
}