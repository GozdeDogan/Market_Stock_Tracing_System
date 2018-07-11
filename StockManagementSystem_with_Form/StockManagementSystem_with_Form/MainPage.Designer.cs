namespace StockManagementSystem_with_Form
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.UnitListComboBox = new System.Windows.Forms.ComboBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.ProductQuantity = new System.Windows.Forms.Label();
            this.ProductUnit = new System.Windows.Forms.Label();
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
            this.productCardTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockManagementSystemDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockManagementSystemDatabaseDataSet = new StockManagementSystem_with_Form.StockManagementSystemDatabaseDataSet();
            this.product_Card_TableTableAdapter = new StockManagementSystem_with_Form.StockManagementSystemDatabaseDataSetTableAdapters.Product_Card_TableTableAdapter();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateDataGridView = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.productQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView_ListElement = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPagePicture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCardTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ListElement)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.UpdateButton);
            this.panel2.Controls.Add(this.UnitListComboBox);
            this.panel2.Controls.Add(this.QuantityTextBox);
            this.panel2.Controls.Add(this.ProductQuantity);
            this.panel2.Controls.Add(this.ProductUnit);
            this.panel2.Controls.Add(this.ProductName);
            this.panel2.Controls.Add(this.ProductID);
            this.panel2.Controls.Add(this.NameTextBox);
            this.panel2.Controls.Add(this.IDTextBox);
            this.panel2.Controls.Add(this.AddNewProduct);
            this.panel2.Location = new System.Drawing.Point(246, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 226);
            this.panel2.TabIndex = 1;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(12, 173);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(185, 42);
            this.UpdateButton.TabIndex = 11;
            this.UpdateButton.Text = "Update This Product";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // UnitListComboBox
            // 
            this.UnitListComboBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.UnitListComboBox.Size = new System.Drawing.Size(148, 27);
            this.UnitListComboBox.TabIndex = 10;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTextBox.Location = new System.Drawing.Point(203, 140);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(148, 26);
            this.QuantityTextBox.TabIndex = 9;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.AutoSize = true;
            this.ProductQuantity.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductQuantity.Location = new System.Drawing.Point(27, 147);
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.Size = new System.Drawing.Size(146, 19);
            this.ProductQuantity.TabIndex = 8;
            this.ProductQuantity.Text = "Product Quantity";
            // 
            // ProductUnit
            // 
            this.ProductUnit.AutoSize = true;
            this.ProductUnit.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductUnit.Location = new System.Drawing.Point(27, 104);
            this.ProductUnit.Name = "ProductUnit";
            this.ProductUnit.Size = new System.Drawing.Size(108, 19);
            this.ProductUnit.TabIndex = 7;
            this.ProductUnit.Text = "Product Unit";
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.Location = new System.Drawing.Point(27, 63);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(122, 19);
            this.ProductName.TabIndex = 6;
            this.ProductName.Text = "Product Name";
            // 
            // ProductID
            // 
            this.ProductID.AutoSize = true;
            this.ProductID.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductID.Location = new System.Drawing.Point(27, 20);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(94, 19);
            this.ProductID.TabIndex = 5;
            this.ProductID.Text = "Product ID";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(203, 56);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(148, 26);
            this.NameTextBox.TabIndex = 2;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.Location = new System.Drawing.Point(203, 13);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(148, 26);
            this.IDTextBox.TabIndex = 1;
            // 
            // AddNewProduct
            // 
            this.AddNewProduct.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewProduct.Location = new System.Drawing.Point(203, 172);
            this.AddNewProduct.Name = "AddNewProduct";
            this.AddNewProduct.Size = new System.Drawing.Size(169, 43);
            this.AddNewProduct.TabIndex = 0;
            this.AddNewProduct.Text = "Add New Product";
            this.AddNewProduct.UseVisualStyleBackColor = true;
            this.AddNewProduct.Click += new System.EventHandler(this.AddNewProduct_Click);
            // 
            // MainPagePicture
            // 
            this.MainPagePicture.Image = ((System.Drawing.Image)(resources.GetObject("MainPagePicture.Image")));
            this.MainPagePicture.Location = new System.Drawing.Point(1, 1);
            this.MainPagePicture.Name = "MainPagePicture";
            this.MainPagePicture.Size = new System.Drawing.Size(230, 321);
            this.MainPagePicture.TabIndex = 2;
            this.MainPagePicture.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.ByNameRadioButton);
            this.panel1.Controls.Add(this.ByIDRadioButton);
            this.panel1.Controls.Add(this.SearchProduct);
            this.panel1.Controls.Add(this.SearchElementTextBox);
            this.panel1.Location = new System.Drawing.Point(246, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 89);
            this.panel1.TabIndex = 3;
            // 
            // ByNameRadioButton
            // 
            this.ByNameRadioButton.AutoSize = true;
            this.ByNameRadioButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ByNameRadioButton.Location = new System.Drawing.Point(136, 8);
            this.ByNameRadioButton.Name = "ByNameRadioButton";
            this.ByNameRadioButton.Size = new System.Drawing.Size(99, 23);
            this.ByNameRadioButton.TabIndex = 5;
            this.ByNameRadioButton.TabStop = true;
            this.ByNameRadioButton.Text = "By Name";
            this.ByNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // ByIDRadioButton
            // 
            this.ByIDRadioButton.AutoSize = true;
            this.ByIDRadioButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ByIDRadioButton.Location = new System.Drawing.Point(31, 8);
            this.ByIDRadioButton.Name = "ByIDRadioButton";
            this.ByIDRadioButton.Size = new System.Drawing.Size(71, 23);
            this.ByIDRadioButton.TabIndex = 4;
            this.ByIDRadioButton.TabStop = true;
            this.ByIDRadioButton.Text = "By ID";
            this.ByIDRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchProduct
            // 
            this.SearchProduct.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProduct.Location = new System.Drawing.Point(203, 37);
            this.SearchProduct.Name = "SearchProduct";
            this.SearchProduct.Size = new System.Drawing.Size(171, 42);
            this.SearchProduct.TabIndex = 3;
            this.SearchProduct.Text = "Search Product";
            this.SearchProduct.UseVisualStyleBackColor = true;
            this.SearchProduct.Click += new System.EventHandler(this.SearchProduct_Click);
            // 
            // SearchElementTextBox
            // 
            this.SearchElementTextBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchElementTextBox.Location = new System.Drawing.Point(12, 46);
            this.SearchElementTextBox.Name = "SearchElementTextBox";
            this.SearchElementTextBox.Size = new System.Drawing.Size(171, 26);
            this.SearchElementTextBox.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(31, 453);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 38);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // productCardTableBindingSource
            // 
            this.productCardTableBindingSource.DataMember = "Product_Card_Table";
            this.productCardTableBindingSource.DataSource = this.stockManagementSystemDatabaseDataSetBindingSource;
            // 
            // stockManagementSystemDatabaseDataSetBindingSource
            // 
            this.stockManagementSystemDatabaseDataSetBindingSource.DataSource = this.stockManagementSystemDatabaseDataSet;
            this.stockManagementSystemDatabaseDataSetBindingSource.Position = 0;
            // 
            // stockManagementSystemDatabaseDataSet
            // 
            this.stockManagementSystemDatabaseDataSet.DataSetName = "StockManagementSystemDatabaseDataSet";
            this.stockManagementSystemDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product_Card_TableTableAdapter
            // 
            this.product_Card_TableTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(12, 345);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(147, 53);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete \r\nSelect Product";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateDataGridView
            // 
            this.UpdateDataGridView.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDataGridView.Location = new System.Drawing.Point(12, 409);
            this.UpdateDataGridView.Name = "UpdateDataGridView";
            this.UpdateDataGridView.Size = new System.Drawing.Size(147, 34);
            this.UpdateDataGridView.TabIndex = 7;
            this.UpdateDataGridView.Text = "Refresh Table";
            this.UpdateDataGridView.UseVisualStyleBackColor = true;
            this.UpdateDataGridView.Click += new System.EventHandler(this.UpdateDataGridView_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // productQuantityDataGridViewTextBoxColumn
            // 
            this.productQuantityDataGridViewTextBoxColumn.DataPropertyName = "ProductQuantity";
            this.productQuantityDataGridViewTextBoxColumn.HeaderText = "ProductQuantity";
            this.productQuantityDataGridViewTextBoxColumn.Name = "productQuantityDataGridViewTextBoxColumn";
            this.productQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productUnitDataGridViewTextBoxColumn
            // 
            this.productUnitDataGridViewTextBoxColumn.DataPropertyName = "ProductUnit";
            this.productUnitDataGridViewTextBoxColumn.HeaderText = "ProductUnit";
            this.productUnitDataGridViewTextBoxColumn.Name = "productUnitDataGridViewTextBoxColumn";
            this.productUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DataGridView_ListElement
            // 
            this.DataGridView_ListElement.AllowUserToAddRows = false;
            this.DataGridView_ListElement.AllowUserToDeleteRows = false;
            this.DataGridView_ListElement.AllowUserToOrderColumns = true;
            this.DataGridView_ListElement.AutoGenerateColumns = false;
            this.DataGridView_ListElement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ListElement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productUnitDataGridViewTextBoxColumn,
            this.productQuantityDataGridViewTextBoxColumn});
            this.DataGridView_ListElement.DataSource = this.productCardTableBindingSource;
            this.DataGridView_ListElement.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridView_ListElement.Location = new System.Drawing.Point(175, 328);
            this.DataGridView_ListElement.Name = "DataGridView_ListElement";
            this.DataGridView_ListElement.ReadOnly = true;
            this.DataGridView_ListElement.RowTemplate.ErrorText = "ERROR";
            this.DataGridView_ListElement.ShowRowErrors = false;
            this.DataGridView_ListElement.Size = new System.Drawing.Size(457, 163);
            this.DataGridView_ListElement.TabIndex = 5;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(640, 495);
            this.Controls.Add(this.UpdateDataGridView);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DataGridView_ListElement);
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
            ((System.ComponentModel.ISupportInitialize)(this.productCardTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ListElement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Button AddNewProduct;
        private System.Windows.Forms.Label ProductUnit;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label ProductID;
        private System.Windows.Forms.PictureBox MainPagePicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchProduct;
        private System.Windows.Forms.TextBox SearchElementTextBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.BindingSource stockManagementSystemDatabaseDataSetBindingSource;
        private StockManagementSystemDatabaseDataSet stockManagementSystemDatabaseDataSet;
        private System.Windows.Forms.BindingSource productCardTableBindingSource;
        private StockManagementSystemDatabaseDataSetTableAdapters.Product_Card_TableTableAdapter product_Card_TableTableAdapter;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label ProductQuantity;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateDataGridView;
        private System.Windows.Forms.ComboBox UnitListComboBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView DataGridView_ListElement;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.RadioButton ByNameRadioButton;
        private System.Windows.Forms.RadioButton ByIDRadioButton;
    }
}

