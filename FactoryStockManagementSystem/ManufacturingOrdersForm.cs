using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryStockManagementSystem
{
    public partial class ManufacturingOrdersForm : Form
    {
        public ManufacturingOrdersForm()
        {
            InitializeComponent();
        }

        private void ManufacturingOrdersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'factoryStockManagementSystemDataSet3.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter1.Fill(this.factoryStockManagementSystemDataSet3.Orders);
            // TODO: This line of code loads data into the 'factoryStockManagementSystemDataSet2.Orders' table. You can move, or remove it, as needed.


        }

        private void btnListWarehouses_Click(object sender, EventArgs e)
        {
            this.Close();
            WarehousesForm wareHousesForm = new WarehousesForm();
            wareHousesForm.Show();
        }

        private void btnDisplayWarehouseInventory_Click(object sender, EventArgs e)
        {
            this.Close();
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.Show();
        }

        private void btnListProducts_Click(object sender, EventArgs e)
        {
            this.Close();
            ManufacturingForm manufacturingForm = new ManufacturingForm();
            manufacturingForm.Show();
        }
    }
}
