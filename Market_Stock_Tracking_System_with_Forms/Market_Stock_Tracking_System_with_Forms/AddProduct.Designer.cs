namespace Market_Stock_Tracking_System_with_Forms
{
    partial class AddProduct
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Unit = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.UnitTypes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(183, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Please enter Product ID";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Location = new System.Drawing.Point(183, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Please enter Product Name";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3.Location = new System.Drawing.Point(183, 190);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Please enter Product Quantity";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
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
            // UnitTypes
            // 
            this.UnitTypes.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.UnitTypes.FormattingEnabled = true;
            this.UnitTypes.Location = new System.Drawing.Point(183, 140);
            this.UnitTypes.Name = "UnitTypes";
            this.UnitTypes.Size = new System.Drawing.Size(150, 30);
            this.UnitTypes.TabIndex = 8;
            this.UnitTypes.SelectedIndexChanged += new System.EventHandler(this.UnitTypes_SelectedIndexChanged);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 334);
            this.Controls.Add(this.UnitTypes);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Unit);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "AddProduct";
            this.Text = "Add Products";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Unit;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.ListBox UnitTypes;
    }
}