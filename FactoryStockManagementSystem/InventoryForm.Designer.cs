namespace FactoryStockManagementSystem
{
    partial class InventoryForm
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
            this.btnListProducts = new System.Windows.Forms.Button();
            this.btnListWarehouses = new System.Windows.Forms.Button();
            this.txtInventoryId = new System.Windows.Forms.TextBox();
            this.lblInventoryId = new System.Windows.Forms.Label();
            this.btnDeleteFromInventory = new System.Windows.Forms.Button();
            this.btnUpdateInventory = new System.Windows.Forms.Button();
            this.btnAddToInventory = new System.Windows.Forms.Button();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtQuantityInStock = new System.Windows.Forms.TextBox();
            this.txtWarehouseId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblQuantityInStock = new System.Windows.Forms.Label();
            this.lblWarehouseId = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factoryStockManagementSystemDataSet2 = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSet2();
            this.warehouseInventoryTableAdapter = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSet2TableAdapters.WarehouseInventoryTableAdapter();
            this.warehousesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.warehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehousesTableAdapter = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSet2TableAdapters.WarehousesTableAdapter();
            this.btnListOrders = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ınfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListProducts
            // 
            this.btnListProducts.Location = new System.Drawing.Point(540, 37);
            this.btnListProducts.Name = "btnListProducts";
            this.btnListProducts.Size = new System.Drawing.Size(186, 92);
            this.btnListProducts.TabIndex = 32;
            this.btnListProducts.Text = "List Products";
            this.btnListProducts.UseVisualStyleBackColor = true;
            this.btnListProducts.Click += new System.EventHandler(this.btnListProducts_Click);
            // 
            // btnListWarehouses
            // 
            this.btnListWarehouses.Location = new System.Drawing.Point(855, 37);
            this.btnListWarehouses.Name = "btnListWarehouses";
            this.btnListWarehouses.Size = new System.Drawing.Size(186, 92);
            this.btnListWarehouses.TabIndex = 33;
            this.btnListWarehouses.Text = "List Warehouses";
            this.btnListWarehouses.UseVisualStyleBackColor = true;
            this.btnListWarehouses.Click += new System.EventHandler(this.btnListWarehouses_Click);
            // 
            // txtInventoryId
            // 
            this.txtInventoryId.Location = new System.Drawing.Point(218, 259);
            this.txtInventoryId.Name = "txtInventoryId";
            this.txtInventoryId.Size = new System.Drawing.Size(169, 26);
            this.txtInventoryId.TabIndex = 45;
            // 
            // lblInventoryId
            // 
            this.lblInventoryId.AutoSize = true;
            this.lblInventoryId.Location = new System.Drawing.Point(130, 265);
            this.lblInventoryId.Name = "lblInventoryId";
            this.lblInventoryId.Size = new System.Drawing.Size(27, 20);
            this.lblInventoryId.TabIndex = 44;
            this.lblInventoryId.Text = "Id:";
            // 
            // btnDeleteFromInventory
            // 
            this.btnDeleteFromInventory.Location = new System.Drawing.Point(289, 579);
            this.btnDeleteFromInventory.Name = "btnDeleteFromInventory";
            this.btnDeleteFromInventory.Size = new System.Drawing.Size(98, 46);
            this.btnDeleteFromInventory.TabIndex = 43;
            this.btnDeleteFromInventory.Text = "&Delete";
            this.btnDeleteFromInventory.UseVisualStyleBackColor = true;
            this.btnDeleteFromInventory.Click += new System.EventHandler(this.btnDeleteInventory_Click);
            // 
            // btnUpdateInventory
            // 
            this.btnUpdateInventory.Location = new System.Drawing.Point(172, 579);
            this.btnUpdateInventory.Name = "btnUpdateInventory";
            this.btnUpdateInventory.Size = new System.Drawing.Size(98, 46);
            this.btnUpdateInventory.TabIndex = 42;
            this.btnUpdateInventory.Text = "&Update";
            this.btnUpdateInventory.UseVisualStyleBackColor = true;
            this.btnUpdateInventory.Click += new System.EventHandler(this.btnUpdateInventory_Click);
            // 
            // btnAddToInventory
            // 
            this.btnAddToInventory.Location = new System.Drawing.Point(53, 579);
            this.btnAddToInventory.Name = "btnAddToInventory";
            this.btnAddToInventory.Size = new System.Drawing.Size(98, 46);
            this.btnAddToInventory.TabIndex = 41;
            this.btnAddToInventory.Text = "&Add";
            this.btnAddToInventory.UseVisualStyleBackColor = true;
            this.btnAddToInventory.Click += new System.EventHandler(this.btnAddToInventory_Click);
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(218, 407);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(169, 26);
            this.txtProductId.TabIndex = 40;
            // 
            // txtQuantityInStock
            // 
            this.txtQuantityInStock.Location = new System.Drawing.Point(218, 482);
            this.txtQuantityInStock.Name = "txtQuantityInStock";
            this.txtQuantityInStock.Size = new System.Drawing.Size(169, 26);
            this.txtQuantityInStock.TabIndex = 39;
            // 
            // txtWarehouseId
            // 
            this.txtWarehouseId.Location = new System.Drawing.Point(218, 327);
            this.txtWarehouseId.Name = "txtWarehouseId";
            this.txtWarehouseId.Size = new System.Drawing.Size(169, 26);
            this.txtWarehouseId.TabIndex = 38;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(71, 413);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(86, 20);
            this.lblProductId.TabIndex = 37;
            this.lblProductId.Text = "Product Id:";
            // 
            // lblQuantityInStock
            // 
            this.lblQuantityInStock.AutoSize = true;
            this.lblQuantityInStock.Location = new System.Drawing.Point(26, 488);
            this.lblQuantityInStock.Name = "lblQuantityInStock";
            this.lblQuantityInStock.Size = new System.Drawing.Size(131, 20);
            this.lblQuantityInStock.TabIndex = 36;
            this.lblQuantityInStock.Text = "Quantity In Stock";
            // 
            // lblWarehouseId
            // 
            this.lblWarehouseId.AutoSize = true;
            this.lblWarehouseId.Location = new System.Drawing.Point(44, 330);
            this.lblWarehouseId.Name = "lblWarehouseId";
            this.lblWarehouseId.Size = new System.Drawing.Size(113, 20);
            this.lblWarehouseId.TabIndex = 35;
            this.lblWarehouseId.Text = "Warehouse Id:";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AutoGenerateColumns = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.warehouseIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.quantityInStockDataGridViewTextBoxColumn});
            this.dgvInventory.DataSource = this.warehouseInventoryBindingSource;
            this.dgvInventory.Location = new System.Drawing.Point(412, 218);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersWidth = 62;
            this.dgvInventory.RowTemplate.Height = 28;
            this.dgvInventory.Size = new System.Drawing.Size(1066, 407);
            this.dgvInventory.TabIndex = 34;
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
            // warehouseIdDataGridViewTextBoxColumn
            // 
            this.warehouseIdDataGridViewTextBoxColumn.DataPropertyName = "WarehouseId";
            this.warehouseIdDataGridViewTextBoxColumn.HeaderText = "WarehouseId";
            this.warehouseIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.warehouseIdDataGridViewTextBoxColumn.Name = "warehouseIdDataGridViewTextBoxColumn";
            this.warehouseIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.warehouseIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityInStockDataGridViewTextBoxColumn
            // 
            this.quantityInStockDataGridViewTextBoxColumn.DataPropertyName = "QuantityInStock";
            this.quantityInStockDataGridViewTextBoxColumn.HeaderText = "QuantityInStock";
            this.quantityInStockDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityInStockDataGridViewTextBoxColumn.Name = "quantityInStockDataGridViewTextBoxColumn";
            this.quantityInStockDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityInStockDataGridViewTextBoxColumn.Width = 150;
            // 
            // warehouseInventoryBindingSource
            // 
            this.warehouseInventoryBindingSource.DataMember = "WarehouseInventory";
            this.warehouseInventoryBindingSource.DataSource = this.factoryStockManagementSystemDataSet2;
            // 
            // factoryStockManagementSystemDataSet2
            // 
            this.factoryStockManagementSystemDataSet2.DataSetName = "FactoryStockManagementSystemDataSet2";
            this.factoryStockManagementSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // warehouseInventoryTableAdapter
            // 
            this.warehouseInventoryTableAdapter.ClearBeforeFill = true;
            // 
            // warehousesBindingSource1
            // 
            this.warehousesBindingSource1.DataMember = "Warehouses";
            this.warehousesBindingSource1.DataSource = this.factoryStockManagementSystemDataSet2;
            // 
            // warehousesBindingSource
            // 
            this.warehousesBindingSource.DataMember = "Warehouses";
            this.warehousesBindingSource.DataSource = this.factoryStockManagementSystemDataSet2;
            // 
            // warehousesTableAdapter
            // 
            this.warehousesTableAdapter.ClearBeforeFill = true;
            // 
            // btnListOrders
            // 
            this.btnListOrders.Location = new System.Drawing.Point(1152, 37);
            this.btnListOrders.Name = "btnListOrders";
            this.btnListOrders.Size = new System.Drawing.Size(186, 92);
            this.btnListOrders.TabIndex = 46;
            this.btnListOrders.Text = "List Orders";
            this.btnListOrders.UseVisualStyleBackColor = true;
            this.btnListOrders.Click += new System.EventHandler(this.btnListOrders_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1523, 33);
            this.menuStrip1.TabIndex = 47;
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
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 686);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnListOrders);
            this.Controls.Add(this.txtInventoryId);
            this.Controls.Add(this.lblInventoryId);
            this.Controls.Add(this.btnDeleteFromInventory);
            this.Controls.Add(this.btnUpdateInventory);
            this.Controls.Add(this.btnAddToInventory);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.txtQuantityInStock);
            this.Controls.Add(this.txtWarehouseId);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.lblQuantityInStock);
            this.Controls.Add(this.lblWarehouseId);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.btnListWarehouses);
            this.Controls.Add(this.btnListProducts);
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListProducts;
        private System.Windows.Forms.Button btnListWarehouses;
        private System.Windows.Forms.TextBox txtInventoryId;
        private System.Windows.Forms.Label lblInventoryId;
        private System.Windows.Forms.Button btnDeleteFromInventory;
        private System.Windows.Forms.Button btnUpdateInventory;
        private System.Windows.Forms.Button btnAddToInventory;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtQuantityInStock;
        private System.Windows.Forms.TextBox txtWarehouseId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblQuantityInStock;
        private System.Windows.Forms.Label lblWarehouseId;
        private System.Windows.Forms.DataGridView dgvInventory;
        private FactoryStockManagementSystemDataSet2 factoryStockManagementSystemDataSet2;
        private System.Windows.Forms.BindingSource warehouseInventoryBindingSource;
        private FactoryStockManagementSystemDataSet2TableAdapters.WarehouseInventoryTableAdapter warehouseInventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource warehousesBindingSource;
        private FactoryStockManagementSystemDataSet2TableAdapters.WarehousesTableAdapter warehousesTableAdapter;
        private System.Windows.Forms.BindingSource warehousesBindingSource1;
        private System.Windows.Forms.Button btnListOrders;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ınfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factoriesToolStripMenuItem;
    }
}