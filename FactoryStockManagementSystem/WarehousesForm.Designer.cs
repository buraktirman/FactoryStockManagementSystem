namespace FactoryStockManagementSystem
{
    partial class WarehousesForm
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
            this.lblProductId = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehousesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.factoryStockManagementSystemDataSet3 = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSet3();
            this.btnDisplayWarehouseInventory = new System.Windows.Forms.Button();
            this.btnListProducts = new System.Windows.Forms.Button();
            this.btnListOrders = new System.Windows.Forms.Button();
            this.warehousesTableAdapter1 = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSet3TableAdapters.WarehousesTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ınfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSet3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(-73, 248);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(27, 20);
            this.lblProductId.TabIndex = 29;
            this.lblProductId.Text = "Id:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(-116, 582);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(98, 46);
            this.btnAddProduct.TabIndex = 26;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(-111, 402);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(93, 20);
            this.lblDescription.TabIndex = 22;
            this.lblDescription.Text = "Description:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(-66, 491);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 20);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "Price:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(-73, 313);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(55, 20);
            this.lblProductName.TabIndex = 20;
            this.lblProductName.Text = "Name:";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.factoryIdDataGridViewTextBoxColumn,
            this.warehouseLocationDataGridViewTextBoxColumn});
            this.dgvProducts.DataSource = this.warehousesBindingSource2;
            this.dgvProducts.Location = new System.Drawing.Point(12, 221);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 28;
            this.dgvProducts.Size = new System.Drawing.Size(1418, 407);
            this.dgvProducts.TabIndex = 33;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Width = 150;
            // 
            // factoryIdDataGridViewTextBoxColumn
            // 
            this.factoryIdDataGridViewTextBoxColumn.DataPropertyName = "FactoryId";
            this.factoryIdDataGridViewTextBoxColumn.HeaderText = "FactoryId";
            this.factoryIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.factoryIdDataGridViewTextBoxColumn.Name = "factoryIdDataGridViewTextBoxColumn";
            this.factoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.factoryIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // warehouseLocationDataGridViewTextBoxColumn
            // 
            this.warehouseLocationDataGridViewTextBoxColumn.DataPropertyName = "WarehouseLocation";
            this.warehouseLocationDataGridViewTextBoxColumn.HeaderText = "WarehouseLocation";
            this.warehouseLocationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.warehouseLocationDataGridViewTextBoxColumn.Name = "warehouseLocationDataGridViewTextBoxColumn";
            this.warehouseLocationDataGridViewTextBoxColumn.ReadOnly = true;
            this.warehouseLocationDataGridViewTextBoxColumn.Width = 150;
            // 
            // warehousesBindingSource2
            // 
            this.warehousesBindingSource2.DataMember = "Warehouses";
            this.warehousesBindingSource2.DataSource = this.factoryStockManagementSystemDataSet3;
            // 
            // factoryStockManagementSystemDataSet3
            // 
            this.factoryStockManagementSystemDataSet3.DataSetName = "FactoryStockManagementSystemDataSet3";
            this.factoryStockManagementSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDisplayWarehouseInventory
            // 
            this.btnDisplayWarehouseInventory.Location = new System.Drawing.Point(640, 49);
            this.btnDisplayWarehouseInventory.Name = "btnDisplayWarehouseInventory";
            this.btnDisplayWarehouseInventory.Size = new System.Drawing.Size(186, 92);
            this.btnDisplayWarehouseInventory.TabIndex = 32;
            this.btnDisplayWarehouseInventory.Text = "Display Warehouse Inventory";
            this.btnDisplayWarehouseInventory.UseVisualStyleBackColor = true;
            this.btnDisplayWarehouseInventory.Click += new System.EventHandler(this.btnDisplayWarehouseInventory_Click);
            // 
            // btnListProducts
            // 
            this.btnListProducts.Location = new System.Drawing.Point(357, 49);
            this.btnListProducts.Name = "btnListProducts";
            this.btnListProducts.Size = new System.Drawing.Size(186, 92);
            this.btnListProducts.TabIndex = 31;
            this.btnListProducts.Text = "List Products";
            this.btnListProducts.UseVisualStyleBackColor = true;
            this.btnListProducts.Click += new System.EventHandler(this.btnListProducts_Click);
            // 
            // btnListOrders
            // 
            this.btnListOrders.Location = new System.Drawing.Point(934, 49);
            this.btnListOrders.Name = "btnListOrders";
            this.btnListOrders.Size = new System.Drawing.Size(186, 92);
            this.btnListOrders.TabIndex = 34;
            this.btnListOrders.Text = "List Orders";
            this.btnListOrders.UseVisualStyleBackColor = true;
            this.btnListOrders.Click += new System.EventHandler(this.btnListOrders_Click);
            // 
            // warehousesTableAdapter1
            // 
            this.warehousesTableAdapter1.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ınfoToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1434, 33);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ınfoToolStripMenuItem
            // 
            this.ınfoToolStripMenuItem.Name = "ınfoToolStripMenuItem";
            this.ınfoToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.ınfoToolStripMenuItem.Text = "Info";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 34);
            this.toolStripMenuItem1.Text = "Font";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.factoriesToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // factoriesToolStripMenuItem
            // 
            this.factoriesToolStripMenuItem.Name = "factoriesToolStripMenuItem";
            this.factoriesToolStripMenuItem.Size = new System.Drawing.Size(183, 34);
            this.factoriesToolStripMenuItem.Text = "Factories";
            // 
            // WarehousesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 681);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnListOrders);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnDisplayWarehouseInventory);
            this.Controls.Add(this.btnListProducts);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProductName);
            this.Name = "WarehousesForm";
            this.Text = "WarehousesForm";
            this.Load += new System.EventHandler(this.WarehousesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSet3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnDisplayWarehouseInventory;
        private System.Windows.Forms.Button btnListProducts;
        private System.Windows.Forms.BindingSource warehousesBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseLocationDataGridViewTextBoxColumn;
        private FactoryStockManagementSystemDataSet3 factoryStockManagementSystemDataSet3;
        private System.Windows.Forms.Button btnListOrders;
        private FactoryStockManagementSystemDataSet3TableAdapters.WarehousesTableAdapter warehousesTableAdapter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ınfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factoriesToolStripMenuItem;
    }
}