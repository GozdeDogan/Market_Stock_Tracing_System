﻿namespace StockManagementSystem_with_Form
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UpdateThisButton = new System.Windows.Forms.Button();
            this.MoneyUnitComboBox = new System.Windows.Forms.ComboBox();
            this.MoneyTextBox = new System.Windows.Forms.TextBox();
            this.UnitListComboBox = new System.Windows.Forms.ComboBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.ProductMoneyUnit = new System.Windows.Forms.Label();
            this.ProductUnitQuantity = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.ProductID = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.AddNewProduct = new System.Windows.Forms.Button();
            this.MainPagePicture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ByNameRadioButton = new System.Windows.Forms.RadioButton();
            this.ByIDRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchProduct = new System.Windows.Forms.Button();
            this.SearchElementTextBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateDataGridView = new System.Windows.Forms.Button();
            this.DataGridView_Products = new System.Windows.Forms.DataGridView();
            this.UpdateSelectButton = new System.Windows.Forms.Button();
            this.stockManagementSystemDatabaseDataSet = new StockManagementSystem_with_Form.StockManagementSystemDatabaseDataSet();
            this.productCardsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_Cards_TableTableAdapter = new StockManagementSystem_with_Form.StockManagementSystemDatabaseDataSetTableAdapters.Product_Cards_TableTableAdapter();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMoneyUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPagePicture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCardsTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.UpdateThisButton);
            this.panel2.Controls.Add(this.MoneyUnitComboBox);
            this.panel2.Controls.Add(this.MoneyTextBox);
            this.panel2.Controls.Add(this.UnitListComboBox);
            this.panel2.Controls.Add(this.QuantityTextBox);
            this.panel2.Controls.Add(this.ProductMoneyUnit);
            this.panel2.Controls.Add(this.ProductUnitQuantity);
            this.panel2.Controls.Add(this.ProductName);
            this.panel2.Controls.Add(this.ProductID);
            this.panel2.Controls.Add(this.NameTextBox);
            this.panel2.Controls.Add(this.IDTextBox);
            this.panel2.Controls.Add(this.AddNewProduct);
            this.panel2.Location = new System.Drawing.Point(204, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 189);
            this.panel2.TabIndex = 1;
            // 
            // UpdateThisButton
            // 
            this.UpdateThisButton.BackColor = System.Drawing.Color.Goldenrod;
            this.UpdateThisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateThisButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdateThisButton.Location = new System.Drawing.Point(376, 104);
            this.UpdateThisButton.Name = "UpdateThisButton";
            this.UpdateThisButton.Size = new System.Drawing.Size(124, 62);
            this.UpdateThisButton.TabIndex = 14;
            this.UpdateThisButton.Text = "Update This Product";
            this.UpdateThisButton.UseVisualStyleBackColor = false;
            this.UpdateThisButton.Click += new System.EventHandler(this.UpdateThisButton_Click);
            // 
            // MoneyUnitComboBox
            // 
            this.MoneyUnitComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MoneyUnitComboBox.FormattingEnabled = true;
            this.MoneyUnitComboBox.Items.AddRange(new object[] {
            "TL",
            "$",
            "€"});
            this.MoneyUnitComboBox.Location = new System.Drawing.Point(287, 138);
            this.MoneyUnitComboBox.Name = "MoneyUnitComboBox";
            this.MoneyUnitComboBox.Size = new System.Drawing.Size(64, 28);
            this.MoneyUnitComboBox.TabIndex = 13;
            // 
            // MoneyTextBox
            // 
            this.MoneyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MoneyTextBox.Location = new System.Drawing.Point(203, 138);
            this.MoneyTextBox.Name = "MoneyTextBox";
            this.MoneyTextBox.Size = new System.Drawing.Size(70, 26);
            this.MoneyTextBox.TabIndex = 12;
            // 
            // UnitListComboBox
            // 
            this.UnitListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitListComboBox.FormattingEnabled = true;
            this.UnitListComboBox.Items.AddRange(new object[] {
            "km",
            "m",
            "cm",
            "ton",
            "kg",
            "g",
            "mg",
            "lt",
            "piece",
            "packet",
            "box",
            "bottle"});
            this.UnitListComboBox.Location = new System.Drawing.Point(203, 96);
            this.UnitListComboBox.Name = "UnitListComboBox";
            this.UnitListComboBox.Size = new System.Drawing.Size(70, 28);
            this.UnitListComboBox.TabIndex = 10;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTextBox.Location = new System.Drawing.Point(287, 96);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(64, 26);
            this.QuantityTextBox.TabIndex = 9;
            // 
            // ProductMoneyUnit
            // 
            this.ProductMoneyUnit.AutoSize = true;
            this.ProductMoneyUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductMoneyUnit.Location = new System.Drawing.Point(8, 143);
            this.ProductMoneyUnit.Name = "ProductMoneyUnit";
            this.ProductMoneyUnit.Size = new System.Drawing.Size(167, 20);
            this.ProductMoneyUnit.TabIndex = 8;
            this.ProductMoneyUnit.Text = "Product Money-Unit";
            // 
            // ProductUnitQuantity
            // 
            this.ProductUnitQuantity.AutoSize = true;
            this.ProductUnitQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductUnitQuantity.Location = new System.Drawing.Point(8, 104);
            this.ProductUnitQuantity.Name = "ProductUnitQuantity";
            this.ProductUnitQuantity.Size = new System.Drawing.Size(182, 20);
            this.ProductUnitQuantity.TabIndex = 7;
            this.ProductUnitQuantity.Text = "Product Unit-Quantity";
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.Location = new System.Drawing.Point(8, 62);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(122, 20);
            this.ProductName.TabIndex = 6;
            this.ProductName.Text = "Product Name";
            // 
            // ProductID
            // 
            this.ProductID.AutoSize = true;
            this.ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductID.Location = new System.Drawing.Point(8, 19);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(95, 20);
            this.ProductID.TabIndex = 5;
            this.ProductID.Text = "Product ID";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(203, 56);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(148, 26);
            this.NameTextBox.TabIndex = 2;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.Location = new System.Drawing.Point(203, 13);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(148, 26);
            this.IDTextBox.TabIndex = 1;
            // 
            // AddNewProduct
            // 
            this.AddNewProduct.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.AddNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddNewProduct.Location = new System.Drawing.Point(376, 19);
            this.AddNewProduct.Name = "AddNewProduct";
            this.AddNewProduct.Size = new System.Drawing.Size(124, 63);
            this.AddNewProduct.TabIndex = 0;
            this.AddNewProduct.Text = "Add New Product";
            this.AddNewProduct.UseVisualStyleBackColor = false;
            this.AddNewProduct.Click += new System.EventHandler(this.AddNewProduct_Click);
            // 
            // MainPagePicture
            // 
            this.MainPagePicture.Image = ((System.Drawing.Image)(resources.GetObject("MainPagePicture.Image")));
            this.MainPagePicture.Location = new System.Drawing.Point(1, 1);
            this.MainPagePicture.Name = "MainPagePicture";
            this.MainPagePicture.Size = new System.Drawing.Size(197, 274);
            this.MainPagePicture.TabIndex = 2;
            this.MainPagePicture.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.ByNameRadioButton);
            this.panel1.Controls.Add(this.ByIDRadioButton);
            this.panel1.Controls.Add(this.SearchProduct);
            this.panel1.Controls.Add(this.SearchElementTextBox);
            this.panel1.Location = new System.Drawing.Point(359, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 97);
            this.panel1.TabIndex = 3;
            // 
            // ByNameRadioButton
            // 
            this.ByNameRadioButton.AutoSize = true;
            this.ByNameRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ByNameRadioButton.Location = new System.Drawing.Point(110, 8);
            this.ByNameRadioButton.Name = "ByNameRadioButton";
            this.ByNameRadioButton.Size = new System.Drawing.Size(98, 24);
            this.ByNameRadioButton.TabIndex = 5;
            this.ByNameRadioButton.TabStop = true;
            this.ByNameRadioButton.Text = "By Name";
            this.ByNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // ByIDRadioButton
            // 
            this.ByIDRadioButton.AutoSize = true;
            this.ByIDRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ByIDRadioButton.Location = new System.Drawing.Point(21, 8);
            this.ByIDRadioButton.Name = "ByIDRadioButton";
            this.ByIDRadioButton.Size = new System.Drawing.Size(71, 24);
            this.ByIDRadioButton.TabIndex = 4;
            this.ByIDRadioButton.TabStop = true;
            this.ByIDRadioButton.Text = "By ID";
            this.ByIDRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchProduct
            // 
            this.SearchProduct.BackColor = System.Drawing.Color.SeaGreen;
            this.SearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchProduct.Location = new System.Drawing.Point(223, 20);
            this.SearchProduct.Name = "SearchProduct";
            this.SearchProduct.Size = new System.Drawing.Size(122, 58);
            this.SearchProduct.TabIndex = 3;
            this.SearchProduct.Text = "Search Product";
            this.SearchProduct.UseVisualStyleBackColor = false;
            this.SearchProduct.Click += new System.EventHandler(this.SearchProduct_Click);
            // 
            // SearchElementTextBox
            // 
            this.SearchElementTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchElementTextBox.Location = new System.Drawing.Point(41, 52);
            this.SearchElementTextBox.Name = "SearchElementTextBox";
            this.SearchElementTextBox.Size = new System.Drawing.Size(144, 26);
            this.SearchElementTextBox.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.DarkRed;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitButton.Location = new System.Drawing.Point(33, 449);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 38);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteButton.Location = new System.Drawing.Point(12, 313);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(147, 53);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete \r\nSelect Product";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateDataGridView
            // 
            this.UpdateDataGridView.BackColor = System.Drawing.Color.Khaki;
            this.UpdateDataGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDataGridView.Location = new System.Drawing.Point(216, 229);
            this.UpdateDataGridView.Name = "UpdateDataGridView";
            this.UpdateDataGridView.Size = new System.Drawing.Size(118, 63);
            this.UpdateDataGridView.TabIndex = 7;
            this.UpdateDataGridView.Text = "Refresh Table";
            this.UpdateDataGridView.UseVisualStyleBackColor = false;
            this.UpdateDataGridView.Click += new System.EventHandler(this.UpdateDataGridView_Click);
            // 
            // DataGridView_Products
            // 
            this.DataGridView_Products.AllowUserToAddRows = false;
            this.DataGridView_Products.AllowUserToDeleteRows = false;
            this.DataGridView_Products.AllowUserToOrderColumns = true;
            this.DataGridView_Products.AutoGenerateColumns = false;
            this.DataGridView_Products.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productUnitDataGridViewTextBoxColumn,
            this.productQuantityDataGridViewTextBoxColumn,
            this.productMoneyDataGridViewTextBoxColumn,
            this.productMoneyUnitDataGridViewTextBoxColumn});
            this.DataGridView_Products.DataSource = this.productCardsTableBindingSource;
            this.DataGridView_Products.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridView_Products.Location = new System.Drawing.Point(170, 314);
            this.DataGridView_Products.Name = "DataGridView_Products";
            this.DataGridView_Products.ReadOnly = true;
            this.DataGridView_Products.RowHeadersWidth = 20;
            this.DataGridView_Products.RowTemplate.ErrorText = "ERROR";
            this.DataGridView_Products.ShowRowErrors = false;
            this.DataGridView_Products.Size = new System.Drawing.Size(550, 184);
            this.DataGridView_Products.TabIndex = 1;
            // 
            // UpdateSelectButton
            // 
            this.UpdateSelectButton.BackColor = System.Drawing.Color.Goldenrod;
            this.UpdateSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateSelectButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdateSelectButton.Location = new System.Drawing.Point(12, 372);
            this.UpdateSelectButton.Name = "UpdateSelectButton";
            this.UpdateSelectButton.Size = new System.Drawing.Size(147, 57);
            this.UpdateSelectButton.TabIndex = 8;
            this.UpdateSelectButton.Text = "Update Select Product";
            this.UpdateSelectButton.UseVisualStyleBackColor = false;
            this.UpdateSelectButton.Click += new System.EventHandler(this.UpdateSelectButton_Click);
            // 
            // stockManagementSystemDatabaseDataSet
            // 
            this.stockManagementSystemDatabaseDataSet.DataSetName = "StockManagementSystemDatabaseDataSet";
            this.stockManagementSystemDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productCardsTableBindingSource
            // 
            this.productCardsTableBindingSource.DataMember = "Product_Cards_Table";
            this.productCardsTableBindingSource.DataSource = this.stockManagementSystemDatabaseDataSet;
            // 
            // product_Cards_TableTableAdapter
            // 
            this.product_Cards_TableTableAdapter.ClearBeforeFill = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Width = 85;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 85;
            // 
            // productUnitDataGridViewTextBoxColumn
            // 
            this.productUnitDataGridViewTextBoxColumn.DataPropertyName = "ProductUnit";
            this.productUnitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.productUnitDataGridViewTextBoxColumn.Name = "productUnitDataGridViewTextBoxColumn";
            this.productUnitDataGridViewTextBoxColumn.ReadOnly = true;
            this.productUnitDataGridViewTextBoxColumn.Width = 85;
            // 
            // productQuantityDataGridViewTextBoxColumn
            // 
            this.productQuantityDataGridViewTextBoxColumn.DataPropertyName = "ProductQuantity";
            this.productQuantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.productQuantityDataGridViewTextBoxColumn.Name = "productQuantityDataGridViewTextBoxColumn";
            this.productQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.productQuantityDataGridViewTextBoxColumn.Width = 85;
            // 
            // productMoneyDataGridViewTextBoxColumn
            // 
            this.productMoneyDataGridViewTextBoxColumn.DataPropertyName = "ProductMoney";
            this.productMoneyDataGridViewTextBoxColumn.HeaderText = "Money";
            this.productMoneyDataGridViewTextBoxColumn.Name = "productMoneyDataGridViewTextBoxColumn";
            this.productMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.productMoneyDataGridViewTextBoxColumn.Width = 85;
            // 
            // productMoneyUnitDataGridViewTextBoxColumn
            // 
            this.productMoneyUnitDataGridViewTextBoxColumn.DataPropertyName = "ProductMoneyUnit";
            this.productMoneyUnitDataGridViewTextBoxColumn.HeaderText = "MoneyUnit";
            this.productMoneyUnitDataGridViewTextBoxColumn.Name = "productMoneyUnitDataGridViewTextBoxColumn";
            this.productMoneyUnitDataGridViewTextBoxColumn.ReadOnly = true;
            this.productMoneyUnitDataGridViewTextBoxColumn.Width = 85;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(725, 510);
            this.Controls.Add(this.UpdateSelectButton);
            this.Controls.Add(this.UpdateDataGridView);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DataGridView_Products);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPagePicture);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.Text = "StockManagementSystem_MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPagePicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCardsTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Button AddNewProduct;
        private System.Windows.Forms.Label ProductUnitQuantity;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label ProductID;
        private System.Windows.Forms.PictureBox MainPagePicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchProduct;
        private System.Windows.Forms.TextBox SearchElementTextBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label ProductMoneyUnit;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateDataGridView;
        private System.Windows.Forms.ComboBox UnitListComboBox;
        private System.Windows.Forms.DataGridView DataGridView_Products;
        private System.Windows.Forms.RadioButton ByNameRadioButton;
        private System.Windows.Forms.RadioButton ByIDRadioButton;
        private System.Windows.Forms.ComboBox MoneyUnitComboBox;
        private System.Windows.Forms.TextBox MoneyTextBox;
        private System.Windows.Forms.Button UpdateThisButton;
        private System.Windows.Forms.Button UpdateSelectButton;
        private StockManagementSystemDatabaseDataSet stockManagementSystemDatabaseDataSet;
        private System.Windows.Forms.BindingSource productCardsTableBindingSource;
        private StockManagementSystemDatabaseDataSetTableAdapters.Product_Cards_TableTableAdapter product_Cards_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productMoneyUnitDataGridViewTextBoxColumn;
        //private StockManagementSystemDatabaseDataSet stockManagementSystemDatabaseDataSet;
    }
}

