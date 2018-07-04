namespace Market_Stock_Tracking_System_with_Forms
{
    partial class ListProducts
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
            this.ProductID = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.ProductQuantity = new System.Windows.Forms.Label();
            this.ProductUnit = new System.Windows.Forms.Label();
            this.ProductsList = new System.Windows.Forms.TextBox();
            this.TurnBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductID
            // 
            this.ProductID.AutoSize = true;
            this.ProductID.Location = new System.Drawing.Point(21, 23);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(58, 13);
            this.ProductID.TabIndex = 1;
            this.ProductID.Text = "Product ID";
            this.ProductID.Click += new System.EventHandler(this.ProductID_Click);
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Location = new System.Drawing.Point(110, 23);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(75, 13);
            this.ProductName.TabIndex = 2;
            this.ProductName.Text = "Product Name";
            this.ProductName.Click += new System.EventHandler(this.ProductName_Click);
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.AutoSize = true;
            this.ProductQuantity.Location = new System.Drawing.Point(220, 23);
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.Size = new System.Drawing.Size(86, 13);
            this.ProductQuantity.TabIndex = 3;
            this.ProductQuantity.Text = "Product Quantity";
            this.ProductQuantity.Click += new System.EventHandler(this.ProductQuantity_Click);
            // 
            // ProductUnit
            // 
            this.ProductUnit.AutoSize = true;
            this.ProductUnit.Location = new System.Drawing.Point(346, 23);
            this.ProductUnit.Name = "ProductUnit";
            this.ProductUnit.Size = new System.Drawing.Size(66, 13);
            this.ProductUnit.TabIndex = 4;
            this.ProductUnit.Text = "Product Unit";
            this.ProductUnit.Click += new System.EventHandler(this.ProductUnit_Click);
            // 
            // ProductsList
            // 
            this.ProductsList.Location = new System.Drawing.Point(12, 39);
            this.ProductsList.Multiline = true;
            this.ProductsList.Name = "ProductsList";
            this.ProductsList.Size = new System.Drawing.Size(415, 203);
            this.ProductsList.TabIndex = 5;
            this.ProductsList.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // TurnBackButton
            // 
            this.TurnBackButton.Location = new System.Drawing.Point(334, 270);
            this.TurnBackButton.Name = "TurnBackButton";
            this.TurnBackButton.Size = new System.Drawing.Size(93, 23);
            this.TurnBackButton.TabIndex = 6;
            this.TurnBackButton.Text = "Turn Back";
            this.TurnBackButton.UseVisualStyleBackColor = true;
            this.TurnBackButton.Click += new System.EventHandler(this.TurnBackButton_Click);
            // 
            // ListProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 323);
            this.Controls.Add(this.TurnBackButton);
            this.Controls.Add(this.ProductsList);
            this.Controls.Add(this.ProductUnit);
            this.Controls.Add(this.ProductQuantity);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.ProductID);
            this.Name = "ListProducts";
            this.Text = "ListProducts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ProductID;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label ProductQuantity;
        private System.Windows.Forms.Label ProductUnit;
        private System.Windows.Forms.TextBox ProductsList;
        private System.Windows.Forms.Button TurnBackButton;
    }
}