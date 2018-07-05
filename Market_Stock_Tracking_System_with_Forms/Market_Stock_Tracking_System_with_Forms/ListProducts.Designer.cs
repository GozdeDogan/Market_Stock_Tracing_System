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
            this.TurnBackButton = new System.Windows.Forms.Button();
            this.SortByID = new System.Windows.Forms.Button();
            this.SortByName = new System.Windows.Forms.Button();
            this.SortByQuantity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TurnBackButton
            // 
            this.TurnBackButton.Location = new System.Drawing.Point(12, 12);
            this.TurnBackButton.Name = "TurnBackButton";
            this.TurnBackButton.Size = new System.Drawing.Size(100, 31);
            this.TurnBackButton.TabIndex = 0;
            this.TurnBackButton.Text = "Turn Back";
            this.TurnBackButton.UseVisualStyleBackColor = true;
            this.TurnBackButton.Click += new System.EventHandler(this.TurnBackButton_Click);
            // 
            // SortByID
            // 
            this.SortByID.Location = new System.Drawing.Point(327, 12);
            this.SortByID.Name = "SortByID";
            this.SortByID.Size = new System.Drawing.Size(81, 31);
            this.SortByID.TabIndex = 1;
            this.SortByID.Text = "Sort by ID";
            this.SortByID.UseVisualStyleBackColor = true;
            // 
            // SortByName
            // 
            this.SortByName.Location = new System.Drawing.Point(430, 12);
            this.SortByName.Name = "SortByName";
            this.SortByName.Size = new System.Drawing.Size(115, 31);
            this.SortByName.TabIndex = 2;
            this.SortByName.Text = "Sort by Name";
            this.SortByName.UseVisualStyleBackColor = true;
            // 
            // SortByQuantity
            // 
            this.SortByQuantity.Location = new System.Drawing.Point(567, 12);
            this.SortByQuantity.Name = "SortByQuantity";
            this.SortByQuantity.Size = new System.Drawing.Size(108, 31);
            this.SortByQuantity.TabIndex = 3;
            this.SortByQuantity.Text = "Sort by Quantity";
            this.SortByQuantity.UseVisualStyleBackColor = true;
            // 
            // ListProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 397);
            this.Controls.Add(this.SortByQuantity);
            this.Controls.Add(this.SortByName);
            this.Controls.Add(this.SortByID);
            this.Controls.Add(this.TurnBackButton);
            this.Name = "ListProducts";
            this.Text = "ListProducts";
            this.Load += new System.EventHandler(this.ListProducts_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TurnBackButton;
        private System.Windows.Forms.Button SortByID;
        private System.Windows.Forms.Button SortByName;
        private System.Windows.Forms.Button SortByQuantity;
    }
}