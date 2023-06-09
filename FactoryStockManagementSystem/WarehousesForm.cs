using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryStockManagementSystem
{
    public partial class WarehousesForm : Form
    {
        public WarehousesForm()
        {
            InitializeComponent();
        }

        private void WarehousesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'factoryStockManagementSystemDataSet3.Warehouses' table. You can move, or remove it, as needed.
            this.warehousesTableAdapter1.Fill(this.factoryStockManagementSystemDataSet3.Warehouses);

        }

        private void btnListProducts_Click(object sender, EventArgs e)
        {
            this.Close();
            ManufacturingForm manufacturingForm = new ManufacturingForm();
            manufacturingForm.Show();
        }

        private void btnDisplayWarehouseInventory_Click(object sender, EventArgs e)
        {
            this.Close();
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.Show();
        }

        private void btnListOrders_Click(object sender, EventArgs e)
        {
            this.Close();
            ManufacturingOrdersForm manufacturingOrdersForm = new ManufacturingOrdersForm();
            manufacturingOrdersForm.Show();
        }
    }
}
