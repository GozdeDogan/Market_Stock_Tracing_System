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
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockManagementSystemDatabaseDataSet = new StockManagementSystem_with_Form.StockManagementSystemDatabaseDataSet();
            this.move_TableTableAdapter = new StockManagementSystem_with_Form.StockManagementSystemDatabaseDataSetTableAdapters.Move_TableTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductTextBox = new System.Windows.Forms.TextBox();
            this.turnbackButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ByID)).BeginInit();
            this.menu_byID_DataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_ByID
            // 
            this.DataGridView_ByID.AutoGenerateColumns = false;
            this.DataGridView_ByID.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DataGridView_ByID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ByID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moveProductIDDataGridViewTextBoxColumn,
            this.moveTypeDataGridViewTextBoxColumn,
            this.moveDateDataGridViewTextBoxColumn,
            this.moveQuantityDataGridViewTextBoxColumn});
            this.DataGridView_ByID.ContextMenuStrip = this.menu_byID_DataGridView;
            this.DataGridView_ByID.DataSource = this.moveTableBindingSource;
            this.DataGridView_ByID.Location = new System.Drawing.Point(12, 44);
            this.DataGridView_ByID.Name = "DataGridView_ByID";
            this.DataGridView_ByID.Size = new System.Drawing.Size(451, 223);
            this.DataGridView_ByID.TabIndex = 0;
            // 
            // moveProductIDDataGridViewTextBoxColumn
            // 
            this.moveProductIDDataGridViewTextBoxColumn.DataPropertyName = "MoveProductID";
            this.moveProductIDDataGridViewTextBoxColumn.HeaderText = "MoveProductID";
            this.moveProductIDDataGridViewTextBoxColumn.Name = "moveProductIDDataGridViewTextBoxColumn";
            // 
            // moveTypeDataGridViewTextBoxColumn
            // 
            this.moveTypeDataGridViewTextBoxColumn.DataPropertyName = "MoveType";
            this.moveTypeDataGridViewTextBoxColumn.HeaderText = "MoveType";
            this.moveTypeDataGridViewTextBoxColumn.Name = "moveTypeDataGridViewTextBoxColumn";
            // 
            // moveDateDataGridViewTextBoxColumn
            // 
            this.moveDateDataGridViewTextBoxColumn.DataPropertyName = "MoveDate";
            this.moveDateDataGridViewTextBoxColumn.HeaderText = "MoveDate";
            this.moveDateDataGridViewTextBoxColumn.Name = "moveDateDataGridViewTextBoxColumn";
            // 
            // moveQuantityDataGridViewTextBoxColumn
            // 
            this.moveQuantityDataGridViewTextBoxColumn.DataPropertyName = "MoveQuantity";
            this.moveQuantityDataGridViewTextBoxColumn.HeaderText = "MoveQuantity";
            this.moveQuantityDataGridViewTextBoxColumn.Name = "moveQuantityDataGridViewTextBoxColumn";
            // 
            // menu_byID_DataGridView
            // 
            this.menu_byID_DataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.menu_byID_DataGridView.Name = "menu_byID_DataGridView";
            this.menu_byID_DataGridView.Size = new System.Drawing.Size(113, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
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
            this.ProductTextBox.Location = new System.Drawing.Point(12, 12);
            this.ProductTextBox.Name = "ProductTextBox";
            this.ProductTextBox.Size = new System.Drawing.Size(451, 26);
            this.ProductTextBox.TabIndex = 2;
            // 
            // turnbackButton
            // 
            this.turnbackButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.turnbackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turnbackButton.Location = new System.Drawing.Point(203, 278);
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
            this.pictureBox1.Location = new System.Drawing.Point(125, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 48);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MovePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(472, 329);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.turnbackButton);
            this.Controls.Add(this.ProductTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView_ByID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MovePage";
            this.Text = "MovePage";
            this.Load += new System.EventHandler(this.MovePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ByID)).EndInit();
            this.menu_byID_DataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moveTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductTextBox;
        private System.Windows.Forms.Button turnbackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}