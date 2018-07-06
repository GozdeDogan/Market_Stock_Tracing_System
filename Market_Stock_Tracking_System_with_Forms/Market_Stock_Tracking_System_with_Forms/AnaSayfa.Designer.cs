namespace Market_Stock_Tracking_System_with_Forms
{
    partial class AnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.SearchButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.UnitTypesListBox = new System.Windows.Forms.ListBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.Label();
            this.Unit = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sTOCKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKUNITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKQUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKCARDSTABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTOCK_CARDDataSet = new Market_Stock_Tracking_System_with_Forms.STOCK_CARDDataSet();
            this.sTOCK_CARDS_TABLETableAdapter = new Market_Stock_Tracking_System_with_Forms.STOCK_CARDDataSetTableAdapters.STOCK_CARDS_TABLETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKCARDSTABLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCK_CARDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(21, 377);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(170, 40);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search Product";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(21, 448);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(170, 40);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 325);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.QuantityTextBox);
            this.panel1.Controls.Add(this.UnitTypesListBox);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.IDTextBox);
            this.panel1.Controls.Add(this.AddProductButton);
            this.panel1.Controls.Add(this.Quantity);
            this.panel1.Controls.Add(this.Unit);
            this.panel1.Controls.Add(this.Name);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Location = new System.Drawing.Point(254, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 293);
            this.panel1.TabIndex = 7;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.QuantityTextBox.Location = new System.Drawing.Point(200, 197);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(150, 23);
            this.QuantityTextBox.TabIndex = 13;
            this.QuantityTextBox.Text = "Please enter Product Quantity";
            // 
            // UnitTypesListBox
            // 
            this.UnitTypesListBox.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitTypesListBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.UnitTypesListBox.FormattingEnabled = true;
            this.UnitTypesListBox.ItemHeight = 16;
            this.UnitTypesListBox.Location = new System.Drawing.Point(200, 140);
            this.UnitTypesListBox.Name = "UnitTypesListBox";
            this.UnitTypesListBox.Size = new System.Drawing.Size(150, 20);
            this.UnitTypesListBox.TabIndex = 12;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.NameTextBox.Location = new System.Drawing.Point(200, 80);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(150, 23);
            this.NameTextBox.TabIndex = 11;
            this.NameTextBox.Text = "Please enter Product Name";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.IDTextBox.Location = new System.Drawing.Point(200, 20);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(150, 23);
            this.IDTextBox.TabIndex = 10;
            this.IDTextBox.Text = "Please enter Product ID";
            // 
            // AddProductButton
            // 
            this.AddProductButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.Location = new System.Drawing.Point(180, 249);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(198, 30);
            this.AddProductButton.TabIndex = 9;
            this.AddProductButton.Text = "Add New Product";
            this.AddProductButton.UseVisualStyleBackColor = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(25, 200);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(118, 15);
            this.Quantity.TabIndex = 8;
            this.Quantity.Text = "Product Quantity";
            // 
            // Unit
            // 
            this.Unit.AutoSize = true;
            this.Unit.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unit.Location = new System.Drawing.Point(25, 140);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(87, 15);
            this.Unit.TabIndex = 7;
            this.Unit.Text = "Product Unit";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(25, 80);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(98, 15);
            this.Name.TabIndex = 6;
            this.Name.Text = "Product Name";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(25, 20);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(75, 15);
            this.ID.TabIndex = 5;
            this.ID.Text = "Product ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTOCKIDDataGridViewTextBoxColumn,
            this.sTOCKNAMEDataGridViewTextBoxColumn,
            this.sTOCKUNITDataGridViewTextBoxColumn,
            this.sTOCKQUANTITYDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sTOCKCARDSTABLEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(229, 355);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(467, 133);
            this.dataGridView1.TabIndex = 8;
            // 
            // sTOCKIDDataGridViewTextBoxColumn
            // 
            this.sTOCKIDDataGridViewTextBoxColumn.DataPropertyName = "STOCK_ID";
            this.sTOCKIDDataGridViewTextBoxColumn.HeaderText = "STOCK_ID";
            this.sTOCKIDDataGridViewTextBoxColumn.Name = "sTOCKIDDataGridViewTextBoxColumn";
            // 
            // sTOCKNAMEDataGridViewTextBoxColumn
            // 
            this.sTOCKNAMEDataGridViewTextBoxColumn.DataPropertyName = "STOCK_NAME";
            this.sTOCKNAMEDataGridViewTextBoxColumn.HeaderText = "STOCK_NAME";
            this.sTOCKNAMEDataGridViewTextBoxColumn.Name = "sTOCKNAMEDataGridViewTextBoxColumn";
            // 
            // sTOCKUNITDataGridViewTextBoxColumn
            // 
            this.sTOCKUNITDataGridViewTextBoxColumn.DataPropertyName = "STOCK_UNIT";
            this.sTOCKUNITDataGridViewTextBoxColumn.HeaderText = "STOCK_UNIT";
            this.sTOCKUNITDataGridViewTextBoxColumn.Name = "sTOCKUNITDataGridViewTextBoxColumn";
            // 
            // sTOCKQUANTITYDataGridViewTextBoxColumn
            // 
            this.sTOCKQUANTITYDataGridViewTextBoxColumn.DataPropertyName = "STOCK_QUANTITY";
            this.sTOCKQUANTITYDataGridViewTextBoxColumn.HeaderText = "STOCK_QUANTITY";
            this.sTOCKQUANTITYDataGridViewTextBoxColumn.Name = "sTOCKQUANTITYDataGridViewTextBoxColumn";
            // 
            // sTOCKCARDSTABLEBindingSource
            // 
            this.sTOCKCARDSTABLEBindingSource.DataMember = "STOCK_CARDS_TABLE";
            this.sTOCKCARDSTABLEBindingSource.DataSource = this.sTOCK_CARDDataSet;
            // 
            // sTOCK_CARDDataSet
            // 
            this.sTOCK_CARDDataSet.DataSetName = "STOCK_CARDDataSet";
            this.sTOCK_CARDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTOCK_CARDS_TABLETableAdapter
            // 
            this.sTOCK_CARDS_TABLETableAdapter.ClearBeforeFill = true;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(699, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.pictureBox1);
            //this.Name = "AnaSayfa";
            this.Text = "Market Stock Management System";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKCARDSTABLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCK_CARDDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Unit;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ListBox UnitTypesListBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private STOCK_CARDDataSet sTOCK_CARDDataSet;
        private System.Windows.Forms.BindingSource sTOCKCARDSTABLEBindingSource;
        private STOCK_CARDDataSetTableAdapters.STOCK_CARDS_TABLETableAdapter sTOCK_CARDS_TABLETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOCKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOCKNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOCKUNITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOCKQUANTITYDataGridViewTextBoxColumn;
    }
}

