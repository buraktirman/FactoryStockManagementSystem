namespace FactoryStockManagementSystem
{
    partial class ManufacturingForm
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
            this.btnListWarehouses = new System.Windows.Forms.Button();
            this.btnDisplayWarehouseInventory = new System.Windows.Forms.Button();
            this.warehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factoryStockManagementSystemDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factoryStockManagementSystemDataSet2 = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSet2();
            this.warehousesTableAdapter = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSet2TableAdapters.WarehousesTableAdapter();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSet2TableAdapters.ProductsTableAdapter();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.lblProductId = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.btnListOrders = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ınfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListWarehouses
            // 
            this.btnListWarehouses.Location = new System.Drawing.Point(485, 21);
            this.btnListWarehouses.Name = "btnListWarehouses";
            this.btnListWarehouses.Size = new System.Drawing.Size(186, 92);
            this.btnListWarehouses.TabIndex = 0;
            this.btnListWarehouses.Text = "&List Warehouses";
            this.btnListWarehouses.UseVisualStyleBackColor = true;
            this.btnListWarehouses.Click += new System.EventHandler(this.btnListWarehouses_Click);
            // 
            // btnDisplayWarehouseInventory
            // 
            this.btnDisplayWarehouseInventory.Location = new System.Drawing.Point(783, 21);
            this.btnDisplayWarehouseInventory.Name = "btnDisplayWarehouseInventory";
            this.btnDisplayWarehouseInventory.Size = new System.Drawing.Size(186, 92);
            this.btnDisplayWarehouseInventory.TabIndex = 2;
            this.btnDisplayWarehouseInventory.Text = "&Display Warehouse Inventory";
            this.btnDisplayWarehouseInventory.UseVisualStyleBackColor = true;
            this.btnDisplayWarehouseInventory.Click += new System.EventHandler(this.btnDisplayWarehouseInventory_Click);
            // 
            // warehousesBindingSource
            // 
            this.warehousesBindingSource.DataMember = "Warehouses";
            this.warehousesBindingSource.DataSource = this.factoryStockManagementSystemDataSet2BindingSource;
            // 
            // factoryStockManagementSystemDataSet2BindingSource
            // 
            this.factoryStockManagementSystemDataSet2BindingSource.DataSource = this.factoryStockManagementSystemDataSet2;
            this.factoryStockManagementSystemDataSet2BindingSource.Position = 0;
            // 
            // factoryStockManagementSystemDataSet2
            // 
            this.factoryStockManagementSystemDataSet2.DataSetName = "FactoryStockManagementSystemDataSet2";
            this.factoryStockManagementSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // warehousesTableAdapter
            // 
            this.warehousesTableAdapter.ClearBeforeFill = true;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ProductName,
            this.ProductDescription,
            this.Price});
            this.dgvProducts.DataSource = this.productsBindingSource;
            this.dgvProducts.Location = new System.Drawing.Point(387, 190);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 28;
            this.dgvProducts.Size = new System.Drawing.Size(1066, 407);
            this.dgvProducts.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.MinimumWidth = 8;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 150;
            // 
            // ProductDescription
            // 
            this.ProductDescription.DataPropertyName = "ProductDescription";
            this.ProductDescription.HeaderText = "ProductDescription";
            this.ProductDescription.MinimumWidth = 8;
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.ReadOnly = true;
            this.ProductDescription.Width = 150;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 150;
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
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(71, 282);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(55, 20);
            this.lblProductName.TabIndex = 5;
            this.lblProductName.Text = "Name:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(78, 460);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 20);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(33, 371);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(93, 20);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(193, 276);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(169, 26);
            this.txtProductName.TabIndex = 8;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(193, 454);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(169, 26);
            this.txtProductPrice.TabIndex = 9;
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(193, 365);
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(169, 26);
            this.txtProductDescription.TabIndex = 10;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(28, 551);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(98, 46);
            this.btnAddProduct.TabIndex = 11;
            this.btnAddProduct.Text = "&Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(147, 551);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(98, 46);
            this.btnUpdateProduct.TabIndex = 12;
            this.btnUpdateProduct.Text = "&Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(264, 551);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(98, 46);
            this.btnDeleteProduct.TabIndex = 13;
            this.btnDeleteProduct.Text = "&Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(71, 217);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(27, 20);
            this.lblProductId.TabIndex = 14;
            this.lblProductId.Text = "Id:";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(193, 214);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(169, 26);
            this.txtProductId.TabIndex = 15;
            // 
            // btnListOrders
            // 
            this.btnListOrders.Location = new System.Drawing.Point(1073, 21);
            this.btnListOrders.Name = "btnListOrders";
            this.btnListOrders.Size = new System.Drawing.Size(186, 92);
            this.btnListOrders.TabIndex = 16;
            this.btnListOrders.Text = "&List Orders";
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
            this.menuStrip1.Size = new System.Drawing.Size(1502, 33);
            this.menuStrip1.TabIndex = 36;
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
            this.factoriesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.factoriesToolStripMenuItem.Text = "Factories";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.toolStripMenuItem1.Text = "Font";
            // 
            // ManufacturingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 700);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnListOrders);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnDisplayWarehouseInventory);
            this.Controls.Add(this.btnListWarehouses);
            this.Name = "ManufacturingForm";
            this.Text = "ManufacturingForm";
            this.Load += new System.EventHandler(this.ManufacturingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListWarehouses;
        private System.Windows.Forms.Button btnDisplayWarehouseInventory;
        private System.Windows.Forms.BindingSource factoryStockManagementSystemDataSet2BindingSource;
        private FactoryStockManagementSystemDataSet2 factoryStockManagementSystemDataSet2;
        private System.Windows.Forms.BindingSource warehousesBindingSource;
        private FactoryStockManagementSystemDataSet2TableAdapters.WarehousesTableAdapter warehousesTableAdapter;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private FactoryStockManagementSystemDataSet2TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Button btnListOrders;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ınfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}