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
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void btnListProducts_Click(object sender, EventArgs e)
        {
            this.Close();
            ManufacturingForm manufacturingForm = new ManufacturingForm();
            manufacturingForm.Show();
        }

        private void btnListWarehouses_Click(object sender, EventArgs e)
        {
            this.Close();
            WarehousesForm wareHousesForm = new WarehousesForm();
            wareHousesForm.Show();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'factoryStockManagementSystemDataSet2.Warehouses' table. You can move, or remove it, as needed.
            this.warehousesTableAdapter.Fill(this.factoryStockManagementSystemDataSet2.Warehouses);
            // TODO: This line of code loads data into the 'factoryStockManagementSystemDataSet2.WarehouseInventory' table. You can move, or remove it, as needed.
            this.warehouseInventoryTableAdapter.Fill(this.factoryStockManagementSystemDataSet2.WarehouseInventory);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.warehouseInventoryTableAdapter.FillBy(this.factoryStockManagementSystemDataSet2.WarehouseInventory);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnListOrders_Click(object sender, EventArgs e)
        {
            this.Close();
            ManufacturingOrdersForm manufacturingOrdersForm = new ManufacturingOrdersForm();
            manufacturingOrdersForm.Show();
        }

        private DataTable GetInventoryData()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FactoryStockManagementSystem"].ConnectionString))
            {
                string query = "SELECT * FROM WarehouseInventory";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        private void btnAddToInventory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInventoryId.Text))
            {
                MessageBox.Show("You cannot specify an ID number while adding a warehouse inventory!");
                return;
            }

            int productId;
            int warehouseId;
            int quantityInStock;
            try
            {
                productId = Convert.ToInt32(txtProductId.Text);
                warehouseId = Convert.ToInt32(txtWarehouseId.Text);
                quantityInStock = Convert.ToInt32(txtQuantityInStock.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FactoryStockManagementSystem"].ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO WarehouseInventory (WarehouseId, ProductId, QuantityInStock) VALUES (@WarehouseId, @ProductId, @Quantity)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@WarehouseId", warehouseId);
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    cmd.Parameters.AddWithValue("@Quantity", quantityInStock);
                    int rowsInserted = cmd.ExecuteNonQuery();

                    if (rowsInserted > 0)
                    {
                        MessageBox.Show("Warehouse inventory added successfully.");
                        dgvInventory.DataSource = GetInventoryData();
                    }
                    else
                    {
                        MessageBox.Show("Warehouse inventory could not be added.");
                    }

                    // Refresh the DataGridView or perform any other necessary updates
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnUpdateInventory_Click(object sender, EventArgs e)
        {
            int inventoryId;
            int productId;
            int warehouseId;
            int quantityInStock;
            try
            {
                inventoryId = Convert.ToInt32(txtInventoryId.Text);
                productId = Convert.ToInt32(txtProductId.Text);
                warehouseId = Convert.ToInt32(txtWarehouseId.Text);
                quantityInStock = Convert.ToInt32(txtQuantityInStock.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FactoryStockManagementSystem"].ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE WarehouseInventory SET ProductId = @ProductId, WarehouseId = @WarehouseId, QuantityInStock = @Quantity WHERE Id = @WarehouseInventoryId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@WarehouseInventoryId", inventoryId);
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    cmd.Parameters.AddWithValue("@WarehouseId", warehouseId);
                    cmd.Parameters.AddWithValue("@Quantity", quantityInStock);
                    int rowsUpdated = cmd.ExecuteNonQuery();

                    if (rowsUpdated > 0)
                    {
                        MessageBox.Show("Warehouse inventory updated successfully.");
                        dgvInventory.DataSource = GetInventoryData();
                    }
                    else
                    {
                        MessageBox.Show("Warehouse inventory could not be updated.");
                    }

                    // Refresh the DataGridView or perform any other necessary updates
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnDeleteInventory_Click(object sender, EventArgs e)
        {
            int inventoryId;
            try
            {
                inventoryId = Convert.ToInt32(txtInventoryId.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FactoryStockManagementSystem"].ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM WarehouseInventory WHERE Id = @WarehouseInventoryId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@WarehouseInventoryId", inventoryId);
                    int rowsDeleted = cmd.ExecuteNonQuery();
                    if (rowsDeleted > 0)
                    {
                        MessageBox.Show("Warehouse inventory deleted successfully.");
                        dgvInventory.DataSource = GetInventoryData();
                    }
                    else
                    {
                        MessageBox.Show("Warehouse inventory could not be deleted.");
                    }
                    // Refresh the DataGridView or perform any other necessary updates
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
