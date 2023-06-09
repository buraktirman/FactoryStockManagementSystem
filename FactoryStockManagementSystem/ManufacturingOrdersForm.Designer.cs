namespace FactoryStockManagementSystem
{
    partial class ManufacturingOrdersForm
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseInventoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.factoryStockManagementSystemDataSet3 = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSet3();
            this.btnDisplayWarehouseInventory = new System.Windows.Forms.Button();
            this.btnListWarehouses = new System.Windows.Forms.Button();
            this.factoryStockManagementSystemDataSet2 = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSet2();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSet2TableAdapters.ProductsTableAdapter();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSet2TableAdapters.OrdersTableAdapter();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter1 = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSet3TableAdapters.OrdersTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ınfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListProducts
            // 
            this.btnListProducts.Location = new System.Drawing.Point(859, 50);
            this.btnListProducts.Name = "btnListProducts";
            this.btnListProducts.Size = new System.Drawing.Size(186, 92);
            this.btnListProducts.TabIndex = 20;
            this.btnListProducts.Text = "&List Products";
            this.btnListProducts.UseVisualStyleBackColor = true;
            this.btnListProducts.Click += new System.EventHandler(this.btnListProducts_Click);
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
            this.warehouseInventoryIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn});
            this.dgvProducts.DataSource = this.ordersBindingSource2;
            this.dgvProducts.Location = new System.Drawing.Point(123, 207);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 28;
            this.dgvProducts.Size = new System.Drawing.Size(1215, 469);
            this.dgvProducts.TabIndex = 19;
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
            // warehouseInventoryIdDataGridViewTextBoxColumn
            // 
            this.warehouseInventoryIdDataGridViewTextBoxColumn.DataPropertyName = "WarehouseInventoryId";
            this.warehouseInventoryIdDataGridViewTextBoxColumn.HeaderText = "WarehouseInventoryId";
            this.warehouseInventoryIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.warehouseInventoryIdDataGridViewTextBoxColumn.Name = "warehouseInventoryIdDataGridViewTextBoxColumn";
            this.warehouseInventoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.warehouseInventoryIdDataGridViewTextBoxColumn.Width = 150;
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
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // ordersBindingSource2
            // 
            this.ordersBindingSource2.DataMember = "Orders";
            this.ordersBindingSource2.DataSource = this.factoryStockManagementSystemDataSet3;
            // 
            // factoryStockManagementSystemDataSet3
            // 
            this.factoryStockManagementSystemDataSet3.DataSetName = "FactoryStockManagementSystemDataSet3";
            this.factoryStockManagementSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDisplayWarehouseInventory
            // 
            this.btnDisplayWarehouseInventory.Location = new System.Drawing.Point(569, 50);
            this.btnDisplayWarehouseInventory.Name = "btnDisplayWarehouseInventory";
            this.btnDisplayWarehouseInventory.Size = new System.Drawing.Size(186, 92);
            this.btnDisplayWarehouseInventory.TabIndex = 18;
            this.btnDisplayWarehouseInventory.Text = "&Display Warehouse Inventory";
            this.btnDisplayWarehouseInventory.UseVisualStyleBackColor = true;
            this.btnDisplayWarehouseInventory.Click += new System.EventHandler(this.btnDisplayWarehouseInventory_Click);
            // 
            // btnListWarehouses
            // 
            this.btnListWarehouses.Location = new System.Drawing.Point(271, 50);
            this.btnListWarehouses.Name = "btnListWarehouses";
            this.btnListWarehouses.Size = new System.Drawing.Size(186, 92);
            this.btnListWarehouses.TabIndex = 17;
            this.btnListWarehouses.Text = "&List Warehouses";
            this.btnListWarehouses.UseVisualStyleBackColor = true;
            this.btnListWarehouses.Click += new System.EventHandler(this.btnListWarehouses_Click);
            // 
            // factoryStockManagementSystemDataSet2
            // 
            this.factoryStockManagementSystemDataSet2.DataSetName = "FactoryStockManagementSystemDataSet2";
            this.factoryStockManagementSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.factoryStockManagementSystemDataSet2;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.factoryStockManagementSystemDataSet2;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.factoryStockManagementSystemDataSet2;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(1402, 33);
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
            // ManufacturingOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 706);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnListProducts);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnDisplayWarehouseInventory);
            this.Controls.Add(this.btnListWarehouses);
            this.Name = "ManufacturingOrdersForm";
            this.Text = "ManufacturingOrdersForm";
            this.Load += new System.EventHandler(this.ManufacturingOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListProducts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnDisplayWarehouseInventory;
        private System.Windows.Forms.Button btnListWarehouses;
        private FactoryStockManagementSystemDataSet2 factoryStockManagementSystemDataSet2;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private FactoryStockManagementSystemDataSet2TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private FactoryStockManagementSystemDataSet2TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private FactoryStockManagementSystemDataSet3 factoryStockManagementSystemDataSet3;
        private System.Windows.Forms.BindingSource ordersBindingSource2;
        private FactoryStockManagementSystemDataSet3TableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseInventoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ınfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factoriesToolStripMenuItem;
    }
}