namespace FactoryStockManagementSystem
{
    partial class CustomerForm
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
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.lblInventoryId = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblFactoryId = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseInventoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factoryStockManagementSystemDataSet3 = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSet3();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.ordersTableAdapter = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSet3TableAdapters.OrdersTableAdapter();
            this.cmbFactoryId = new System.Windows.Forms.ComboBox();
            this.factoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factoriesTableAdapter = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSet3TableAdapters.FactoriesTableAdapter();
            this.cmbInventoryId = new System.Windows.Forms.ComboBox();
            this.warehouseInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseInventoryTableAdapter = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSet3TableAdapters.WarehouseInventoryTableAdapter();
            this.cmbProductId = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new FactoryStockManagementSystem.FactoryStockManagementSystemDataSet3TableAdapters.ProductsTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ınfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(156, 170);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(169, 26);
            this.txtOrderId.TabIndex = 27;
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(50, 176);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(27, 20);
            this.lblOrderId.TabIndex = 26;
            this.lblOrderId.Text = "Id:";
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(249, 638);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(98, 46);
            this.btnDeleteOrder.TabIndex = 25;
            this.btnDeleteOrder.Text = "Delete";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(132, 638);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(98, 46);
            this.btnUpdateOrder.TabIndex = 24;
            this.btnUpdateOrder.Text = "Update";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(13, 638);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(98, 46);
            this.btnAddOrder.TabIndex = 23;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // lblInventoryId
            // 
            this.lblInventoryId.AutoSize = true;
            this.lblInventoryId.Location = new System.Drawing.Point(12, 342);
            this.lblInventoryId.Name = "lblInventoryId";
            this.lblInventoryId.Size = new System.Drawing.Size(96, 20);
            this.lblInventoryId.TabIndex = 19;
            this.lblInventoryId.Text = "Inventory Id:";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(19, 416);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(86, 20);
            this.lblProductId.TabIndex = 18;
            this.lblProductId.Text = "Product Id:";
            // 
            // lblFactoryId
            // 
            this.lblFactoryId.AutoSize = true;
            this.lblFactoryId.Location = new System.Drawing.Point(21, 266);
            this.lblFactoryId.Name = "lblFactoryId";
            this.lblFactoryId.Size = new System.Drawing.Size(84, 20);
            this.lblFactoryId.TabIndex = 17;
            this.lblFactoryId.Text = "Factory Id:";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoGenerateColumns = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.factoryIdDataGridViewTextBoxColumn,
            this.warehouseInventoryIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn});
            this.dgvOrders.DataSource = this.ordersBindingSource;
            this.dgvOrders.Location = new System.Drawing.Point(385, 176);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersWidth = 62;
            this.dgvOrders.RowTemplate.Height = 28;
            this.dgvOrders.Size = new System.Drawing.Size(1066, 474);
            this.dgvOrders.TabIndex = 16;
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
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.factoryStockManagementSystemDataSet3;
            // 
            // factoryStockManagementSystemDataSet3
            // 
            this.factoryStockManagementSystemDataSet3.DataSetName = "FactoryStockManagementSystemDataSet3";
            this.factoryStockManagementSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(33, 489);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(72, 20);
            this.lblQuantity.TabIndex = 28;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(13, 553);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(92, 20);
            this.lblOrderDate.TabIndex = 29;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(156, 489);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(169, 26);
            this.txtQuantity.TabIndex = 30;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(156, 553);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(200, 26);
            this.dtpOrderDate.TabIndex = 31;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // cmbFactoryId
            // 
            this.cmbFactoryId.DataSource = this.factoriesBindingSource;
            this.cmbFactoryId.DisplayMember = "FactoryName";
            this.cmbFactoryId.FormattingEnabled = true;
            this.cmbFactoryId.Location = new System.Drawing.Point(156, 258);
            this.cmbFactoryId.Name = "cmbFactoryId";
            this.cmbFactoryId.Size = new System.Drawing.Size(169, 28);
            this.cmbFactoryId.TabIndex = 32;
            this.cmbFactoryId.ValueMember = "Id";
            // 
            // factoriesBindingSource
            // 
            this.factoriesBindingSource.DataMember = "Factories";
            this.factoriesBindingSource.DataSource = this.factoryStockManagementSystemDataSet3;
            // 
            // factoriesTableAdapter
            // 
            this.factoriesTableAdapter.ClearBeforeFill = true;
            // 
            // cmbInventoryId
            // 
            this.cmbInventoryId.DataSource = this.warehouseInventoryBindingSource;
            this.cmbInventoryId.DisplayMember = "Id";
            this.cmbInventoryId.FormattingEnabled = true;
            this.cmbInventoryId.Location = new System.Drawing.Point(156, 339);
            this.cmbInventoryId.Name = "cmbInventoryId";
            this.cmbInventoryId.Size = new System.Drawing.Size(169, 28);
            this.cmbInventoryId.TabIndex = 33;
            this.cmbInventoryId.ValueMember = "Id";
            // 
            // warehouseInventoryBindingSource
            // 
            this.warehouseInventoryBindingSource.DataMember = "WarehouseInventory";
            this.warehouseInventoryBindingSource.DataSource = this.factoryStockManagementSystemDataSet3;
            // 
            // warehouseInventoryTableAdapter
            // 
            this.warehouseInventoryTableAdapter.ClearBeforeFill = true;
            // 
            // cmbProductId
            // 
            this.cmbProductId.DataSource = this.productsBindingSource;
            this.cmbProductId.DisplayMember = "ProductName";
            this.cmbProductId.FormattingEnabled = true;
            this.cmbProductId.Location = new System.Drawing.Point(156, 416);
            this.cmbProductId.Name = "cmbProductId";
            this.cmbProductId.Size = new System.Drawing.Size(169, 28);
            this.cmbProductId.TabIndex = 34;
            this.cmbProductId.ValueMember = "Id";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.factoryStockManagementSystemDataSet3;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(1489, 33);
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
            this.toolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
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
            this.factoriesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.factoriesToolStripMenuItem.Text = "Factories";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 791);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cmbProductId);
            this.Controls.Add(this.cmbInventoryId);
            this.Controls.Add(this.cmbFactoryId);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.lblInventoryId);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.lblFactoryId);
            this.Controls.Add(this.dgvOrders);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryStockManagementSystemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label lblInventoryId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblFactoryId;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private FactoryStockManagementSystemDataSet3 factoryStockManagementSystemDataSet3;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private FactoryStockManagementSystemDataSet3TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseInventoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbFactoryId;
        private System.Windows.Forms.BindingSource factoriesBindingSource;
        private FactoryStockManagementSystemDataSet3TableAdapters.FactoriesTableAdapter factoriesTableAdapter;
        private System.Windows.Forms.ComboBox cmbInventoryId;
        private System.Windows.Forms.BindingSource warehouseInventoryBindingSource;
        private FactoryStockManagementSystemDataSet3TableAdapters.WarehouseInventoryTableAdapter warehouseInventoryTableAdapter;
        private System.Windows.Forms.ComboBox cmbProductId;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private FactoryStockManagementSystemDataSet3TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ınfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factoriesToolStripMenuItem;
    }
}