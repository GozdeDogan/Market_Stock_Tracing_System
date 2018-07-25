namespace StockManagementSystem_with_Form
{
    partial class MovePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovePage));
            this.DataGridView_ByID = new System.Windows.Forms.DataGridView();
            this.moveProductIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moveTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moveQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_byID_DataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ınsertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockManagementSystemDatabaseDataSet = new StockManagementSystem_with_Form.StockManagementSystemDatabaseDataSet();
            this.move_TableTableAdapter = new StockManagementSystem_with_Form.StockManagementSystemDatabaseDataSetTableAdapters.Move_TableTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductTextBox = new System.Windows.Forms.TextBox();
            this.turnbackButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InsertPanel = new System.Windows.Forms.Panel();
            this.MoveDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BackButton = new System.Windows.Forms.Button();
            this.InformationTextBox = new System.Windows.Forms.TextBox();
            this.MoveQuantityLabel = new System.Windows.Forms.Label();
            this.MoveDateLabel = new System.Windows.Forms.Label();
            this.MoveTypeLabel = new System.Windows.Forms.Label();
            this.MoveProductIDLabel = new System.Windows.Forms.Label();
            this.MoveQuantityTextBox = new System.Windows.Forms.TextBox();
            this.MoveTypeTextBox = new System.Windows.Forms.TextBox();
            this.MoveProductIDTextBox = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.GridPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ByID)).BeginInit();
            this.menu_byID_DataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.InsertPanel.SuspendLayout();
            this.GridPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView_ByID
            // 
            this.DataGridView_ByID.AllowUserToAddRows = false;
            this.DataGridView_ByID.AllowUserToDeleteRows = false;
            this.DataGridView_ByID.AllowUserToOrderColumns = true;
            this.DataGridView_ByID.AutoGenerateColumns = false;
            this.DataGridView_ByID.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView_ByID.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DataGridView_ByID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ByID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moveProductIDDataGridViewTextBoxColumn,
            this.moveTypeDataGridViewTextBoxColumn,
            this.moveDateDataGridViewTextBoxColumn,
            this.moveQuantityDataGridViewTextBoxColumn});
            this.DataGridView_ByID.ContextMenuStrip = this.menu_byID_DataGridView;
            this.DataGridView_ByID.DataSource = this.moveTableBindingSource;
            this.DataGridView_ByID.Location = new System.Drawing.Point(4, 11);
            this.DataGridView_ByID.Name = "DataGridView_ByID";
            this.DataGridView_ByID.ReadOnly = true;
            this.DataGridView_ByID.RowHeadersWidth = 20;
            this.DataGridView_ByID.Size = new System.Drawing.Size(447, 223);
            this.DataGridView_ByID.TabIndex = 0;
            // 
            // moveProductIDDataGridViewTextBoxColumn
            // 
            this.moveProductIDDataGridViewTextBoxColumn.DataPropertyName = "MoveProductID";
            this.moveProductIDDataGridViewTextBoxColumn.HeaderText = "MoveProductID";
            this.moveProductIDDataGridViewTextBoxColumn.Name = "moveProductIDDataGridViewTextBoxColumn";
            this.moveProductIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moveTypeDataGridViewTextBoxColumn
            // 
            this.moveTypeDataGridViewTextBoxColumn.DataPropertyName = "MoveType";
            this.moveTypeDataGridViewTextBoxColumn.HeaderText = "MoveType";
            this.moveTypeDataGridViewTextBoxColumn.Name = "moveTypeDataGridViewTextBoxColumn";
            this.moveTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moveDateDataGridViewTextBoxColumn
            // 
            this.moveDateDataGridViewTextBoxColumn.DataPropertyName = "MoveDate";
            this.moveDateDataGridViewTextBoxColumn.HeaderText = "MoveDate";
            this.moveDateDataGridViewTextBoxColumn.Name = "moveDateDataGridViewTextBoxColumn";
            this.moveDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moveQuantityDataGridViewTextBoxColumn
            // 
            this.moveQuantityDataGridViewTextBoxColumn.DataPropertyName = "MoveQuantity";
            this.moveQuantityDataGridViewTextBoxColumn.HeaderText = "MoveQuantity";
            this.moveQuantityDataGridViewTextBoxColumn.Name = "moveQuantityDataGridViewTextBoxColumn";
            this.moveQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // menu_byID_DataGridView
            // 
            this.menu_byID_DataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.ınsertToolStripMenuItem});
            this.menu_byID_DataGridView.Name = "menu_byID_DataGridView";
            this.menu_byID_DataGridView.Size = new System.Drawing.Size(108, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // ınsertToolStripMenuItem
            // 
            this.ınsertToolStripMenuItem.Name = "ınsertToolStripMenuItem";
            this.ınsertToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.ınsertToolStripMenuItem.Text = "Insert";
            this.ınsertToolStripMenuItem.Click += new System.EventHandler(this.ınsertToolStripMenuItem_Click);
            // 
            // moveTableBindingSource
            // 
            this.moveTableBindingSource.DataMember = "Move_Table";
            this.moveTableBindingSource.DataSource = this.stockManagementSystemDatabaseDataSet;
            // 
            // stockManagementSystemDatabaseDataSet
            // 
            this.stockManagementSystemDatabaseDataSet.DataSetName = "StockManagementSystemDatabaseDataSet";
            this.stockManagementSystemDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // move_TableTableAdapter
            // 
            this.move_TableTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // ProductTextBox
            // 
            this.ProductTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductTextBox.Location = new System.Drawing.Point(8, 18);
            this.ProductTextBox.Name = "ProductTextBox";
            this.ProductTextBox.Size = new System.Drawing.Size(459, 26);
            this.ProductTextBox.TabIndex = 2;
            // 
            // turnbackButton
            // 
            this.turnbackButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.turnbackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turnbackButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.turnbackButton.Location = new System.Drawing.Point(234, 301);
            this.turnbackButton.Name = "turnbackButton";
            this.turnbackButton.Size = new System.Drawing.Size(140, 39);
            this.turnbackButton.TabIndex = 3;
            this.turnbackButton.Text = "Turn Back";
            this.turnbackButton.UseVisualStyleBackColor = false;
            this.turnbackButton.Click += new System.EventHandler(this.turnbackButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 297);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 49);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // InsertPanel
            // 
            this.InsertPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.InsertPanel.Controls.Add(this.MoveDateTimePicker);
            this.InsertPanel.Controls.Add(this.BackButton);
            this.InsertPanel.Controls.Add(this.InformationTextBox);
            this.InsertPanel.Controls.Add(this.MoveQuantityLabel);
            this.InsertPanel.Controls.Add(this.MoveDateLabel);
            this.InsertPanel.Controls.Add(this.MoveTypeLabel);
            this.InsertPanel.Controls.Add(this.MoveProductIDLabel);
            this.InsertPanel.Controls.Add(this.MoveQuantityTextBox);
            this.InsertPanel.Controls.Add(this.MoveTypeTextBox);
            this.InsertPanel.Controls.Add(this.MoveProductIDTextBox);
            this.InsertPanel.Controls.Add(this.InsertButton);
            this.InsertPanel.Location = new System.Drawing.Point(69, 47);
            this.InsertPanel.Name = "InsertPanel";
            this.InsertPanel.Size = new System.Drawing.Size(349, 293);
            this.InsertPanel.TabIndex = 5;
            // 
            // MoveDateTimePicker
            // 
            this.MoveDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MoveDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MoveDateTimePicker.Location = new System.Drawing.Point(201, 98);
            this.MoveDateTimePicker.Name = "MoveDateTimePicker";
            this.MoveDateTimePicker.Size = new System.Drawing.Size(127, 26);
            this.MoveDateTimePicker.TabIndex = 12;
            this.MoveDateTimePicker.Value = new System.DateTime(2018, 7, 25, 12, 37, 46, 0);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Teal;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackButton.Location = new System.Drawing.Point(33, 223);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(87, 34);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // InformationTextBox
            // 
            this.InformationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InformationTextBox.Location = new System.Drawing.Point(184, 198);
            this.InformationTextBox.Name = "InformationTextBox";
            this.InformationTextBox.Size = new System.Drawing.Size(153, 26);
            this.InformationTextBox.TabIndex = 10;
            // 
            // MoveQuantityLabel
            // 
            this.MoveQuantityLabel.AutoSize = true;
            this.MoveQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MoveQuantityLabel.Location = new System.Drawing.Point(31, 141);
            this.MoveQuantityLabel.Name = "MoveQuantityLabel";
            this.MoveQuantityLabel.Size = new System.Drawing.Size(118, 20);
            this.MoveQuantityLabel.TabIndex = 9;
            this.MoveQuantityLabel.Text = "MoveQuantity";
            // 
            // MoveDateLabel
            // 
            this.MoveDateLabel.AutoSize = true;
            this.MoveDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MoveDateLabel.Location = new System.Drawing.Point(31, 98);
            this.MoveDateLabel.Name = "MoveDateLabel";
            this.MoveDateLabel.Size = new System.Drawing.Size(90, 20);
            this.MoveDateLabel.TabIndex = 8;
            this.MoveDateLabel.Text = "MoveDate";
            // 
            // MoveTypeLabel
            // 
            this.MoveTypeLabel.AutoSize = true;
            this.MoveTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MoveTypeLabel.Location = new System.Drawing.Point(31, 55);
            this.MoveTypeLabel.Name = "MoveTypeLabel";
            this.MoveTypeLabel.Size = new System.Drawing.Size(89, 20);
            this.MoveTypeLabel.TabIndex = 7;
            this.MoveTypeLabel.Text = "MoveType";
            // 
            // MoveProductIDLabel
            // 
            this.MoveProductIDLabel.AutoSize = true;
            this.MoveProductIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MoveProductIDLabel.Location = new System.Drawing.Point(29, 12);
            this.MoveProductIDLabel.Name = "MoveProductIDLabel";
            this.MoveProductIDLabel.Size = new System.Drawing.Size(132, 20);
            this.MoveProductIDLabel.TabIndex = 6;
            this.MoveProductIDLabel.Text = "MoveProductID";
            // 
            // MoveQuantityTextBox
            // 
            this.MoveQuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MoveQuantityTextBox.Location = new System.Drawing.Point(201, 141);
            this.MoveQuantityTextBox.Name = "MoveQuantityTextBox";
            this.MoveQuantityTextBox.Size = new System.Drawing.Size(127, 26);
            this.MoveQuantityTextBox.TabIndex = 5;
            // 
            // MoveTypeTextBox
            // 
            this.MoveTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MoveTypeTextBox.Location = new System.Drawing.Point(201, 55);
            this.MoveTypeTextBox.Name = "MoveTypeTextBox";
            this.MoveTypeTextBox.Size = new System.Drawing.Size(127, 26);
            this.MoveTypeTextBox.TabIndex = 3;
            // 
            // MoveProductIDTextBox
            // 
            this.MoveProductIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MoveProductIDTextBox.Location = new System.Drawing.Point(201, 12);
            this.MoveProductIDTextBox.Name = "MoveProductIDTextBox";
            this.MoveProductIDTextBox.Size = new System.Drawing.Size(127, 26);
            this.MoveProductIDTextBox.TabIndex = 2;
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.InsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InsertButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InsertButton.Location = new System.Drawing.Point(201, 239);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(118, 39);
            this.InsertButton.TabIndex = 1;
            this.InsertButton.Text = "Insert(Add)";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // GridPanel
            // 
            this.GridPanel.Controls.Add(this.DataGridView_ByID);
            this.GridPanel.Location = new System.Drawing.Point(8, 47);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(459, 244);
            this.GridPanel.TabIndex = 6;
            // 
            // MovePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(469, 343);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.turnbackButton);
            this.Controls.Add(this.GridPanel);
            this.Controls.Add(this.InsertPanel);
            this.Controls.Add(this.ProductTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MovePage";
            this.Text = "MovePage";
            this.Load += new System.EventHandler(this.MovePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ByID)).EndInit();
            this.menu_byID_DataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moveTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.InsertPanel.ResumeLayout(false);
            this.InsertPanel.PerformLayout();
            this.GridPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_ByID;
        private StockManagementSystemDatabaseDataSet stockManagementSystemDatabaseDataSet;
        private System.Windows.Forms.BindingSource moveTableBindingSource;
        private StockManagementSystemDatabaseDataSetTableAdapters.Move_TableTableAdapter move_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn moveProductIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moveTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moveDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moveQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip menu_byID_DataGridView;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductTextBox;
        private System.Windows.Forms.Button turnbackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel InsertPanel;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Label MoveQuantityLabel;
        private System.Windows.Forms.Label MoveDateLabel;
        private System.Windows.Forms.Label MoveTypeLabel;
        private System.Windows.Forms.Label MoveProductIDLabel;
        private System.Windows.Forms.TextBox MoveQuantityTextBox;
        private System.Windows.Forms.TextBox MoveTypeTextBox;
        private System.Windows.Forms.TextBox MoveProductIDTextBox;
        private System.Windows.Forms.ToolStripMenuItem ınsertToolStripMenuItem;
        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.TextBox InformationTextBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DateTimePicker MoveDateTimePicker;
    }
}