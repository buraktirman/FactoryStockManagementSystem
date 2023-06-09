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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'factoryStockManagementSystemDataSet3.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.factoryStockManagementSystemDataSet3.Products);
            // TODO: This line of code loads data into the 'factoryStockManagementSystemDataSet3.WarehouseInventory' table. You can move, or remove it, as needed.
            this.warehouseInventoryTableAdapter.Fill(this.factoryStockManagementSystemDataSet3.WarehouseInventory);
            // TODO: This line of code loads data into the 'factoryStockManagementSystemDataSet3.Factories' table. You can move, or remove it, as needed.
            this.factoriesTableAdapter.Fill(this.factoryStockManagementSystemDataSet3.Factories);
            // TODO: This line of code loads data into the 'factoryStockManagementSystemDataSet3.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.factoryStockManagementSystemDataSet3.Orders);

        }

        private DataTable GetOrdersData()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FactoryStockManagementSystem"].ConnectionString))
            {
                string query = "SELECT * FROM Orders";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOrderId.Text))
            {
                MessageBox.Show("You cannot specify an ID number while adding an order!");
                return;
            }

            //int orderId;
            int quantity;
            int factoryId;
            int warehouseInventoryId;
            int productId;
            DateTime orderDate;
            try
            {
                //orderId = Convert.ToInt32(txtOrderId.Text);
                quantity = Convert.ToInt32(txtQuantity.Text);
                factoryId = (int)cmbFactoryId.SelectedValue;
                warehouseInventoryId = (int)cmbInventoryId.SelectedValue;
                productId = (int)cmbProductId.SelectedValue;
                orderDate = dtpOrderDate.Value;
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

                    // Check if there is enough quantity in the WarehouseInventory
                    string checkQuantityQuery = "SELECT QuantityInStock FROM WarehouseInventory WHERE Id = @WarehouseInventoryId";
                    SqlCommand checkQuantityCmd = new SqlCommand(checkQuantityQuery, conn);
                    checkQuantityCmd.Parameters.AddWithValue("@WarehouseInventoryId", warehouseInventoryId);
                    int quantityInStock = (int)checkQuantityCmd.ExecuteScalar();

                    if (quantity > quantityInStock)
                    {
                        MessageBox.Show("Insufficient quantity in stock. Cannot place the order.");
                        return;
                    }

                    // Add the order
                    string addOrderQuery = "INSERT INTO Orders (FactoryId, WarehouseInventoryId, ProductId, Quantity, OrderDate) VALUES (@FactoryId, @WarehouseInventoryId, @ProductId, @Quantity, @OrderDate)";
                    SqlCommand addOrderCmd = new SqlCommand(addOrderQuery, conn);
                    addOrderCmd.Parameters.AddWithValue("@FactoryId", factoryId);
                    addOrderCmd.Parameters.AddWithValue("@WarehouseInventoryId", warehouseInventoryId);
                    addOrderCmd.Parameters.AddWithValue("@ProductId", productId);
                    addOrderCmd.Parameters.AddWithValue("@Quantity", quantity);
                    addOrderCmd.Parameters.AddWithValue("@OrderDate", orderDate);
                    int rowsInserted = addOrderCmd.ExecuteNonQuery();

                    if (rowsInserted > 0)
                    {
                        MessageBox.Show("Order added successfully.");
                        DecreaseQuantityInStock();
                        dgvOrders.DataSource = GetOrdersData();
                    }
                    else
                    {
                        MessageBox.Show("Order could not be added.");
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

        private void DecreaseQuantityInStock()
        {

            int quantityToDecrease;
            int warehouseInventoryId;
            int productId;
            try
            {
                //orderId = Convert.ToInt32(txtOrderId.Text);
                quantityToDecrease = Convert.ToInt32(txtQuantity.Text);
                warehouseInventoryId = (int)cmbInventoryId.SelectedValue;
                productId = (int)cmbProductId.SelectedValue;
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
                    string query = "UPDATE WarehouseInventory SET QuantityInStock = QuantityInStock - @QuantityToDecrease " +
                                   "WHERE Id = @WarehouseInventoryId AND ProductId = @ProductId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@QuantityToDecrease", quantityToDecrease);
                    cmd.Parameters.AddWithValue("@WarehouseInventoryId", warehouseInventoryId);
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    cmd.ExecuteNonQuery();
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

        //private void IncreaseQuantityInStock()
        //{

        //    int quantityToIncrease;
        //    int warehouseInventoryId;
        //    int productId;
        //    try
        //    {
        //        //orderId = Convert.ToInt32(txtOrderId.Text);
        //        quantityToIncrease = Convert.ToInt32(txtQuantity.Text);
        //        warehouseInventoryId = (int)cmbInventoryId.SelectedValue;
        //        productId = (int)cmbProductId.SelectedValue;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return;
        //    }
        //    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FactoryStockManagementSystem"].ConnectionString))
        //    {
        //        try
        //        {
        //            conn.Open();
        //            string query = "UPDATE WarehouseInventory SET QuantityInStock = QuantityInStock + @QuantityToDecrease " +
        //                           "WHERE Id = @WarehouseInventoryId AND ProductId = @ProductId";
        //            SqlCommand cmd = new SqlCommand(query, conn);
        //            cmd.Parameters.AddWithValue("@QuantityToDecrease", quantityToIncrease);
        //            cmd.Parameters.AddWithValue("@WarehouseInventoryId", warehouseInventoryId);
        //            cmd.Parameters.AddWithValue("@ProductId", productId);
        //            cmd.ExecuteNonQuery();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error: " + ex.Message);
        //        }
        //        finally
        //        {
        //            conn.Close();
        //        }
        //    }
        //}

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            int orderId;
            int quantity;
            int factoryId;
            int warehouseInventoryId;
            int productId;
            DateTime orderDate;
            try
            {
                orderId = Convert.ToInt32(txtOrderId.Text);
                quantity = Convert.ToInt32(txtQuantity.Text);
                factoryId = (int)cmbFactoryId.SelectedValue;
                warehouseInventoryId = (int)cmbInventoryId.SelectedValue;
                productId = (int)cmbProductId.SelectedValue;
                orderDate = dtpOrderDate.Value;
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
                    string query = "UPDATE Orders SET FactoryId = @FactoryId, WarehouseInventoryId = @WarehouseInventoryId, ProductId = @ProductId, Quantity = @Quantity, OrderDate = @OrderDate WHERE Id = @OrderId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FactoryId", factoryId);
                    cmd.Parameters.AddWithValue("@WarehouseInventoryId", warehouseInventoryId);
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@OrderDate", orderDate);
                    cmd.Parameters.AddWithValue("@OrderId", orderId);
                    int rowsUpdated = cmd.ExecuteNonQuery();

                    if (rowsUpdated > 0)
                    {
                        MessageBox.Show("Order updated successfully.");
                        DecreaseQuantityInStock();
                        dgvOrders.DataSource = GetOrdersData();
                    }
                    else
                    {
                        MessageBox.Show("Order could not be updated.");
                    }

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

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            int orderId;

            try
            {
                orderId = Convert.ToInt32(txtOrderId.Text);
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
                    string query = "DELETE FROM Orders WHERE Id = @OrderId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@OrderId", orderId);
                    int rowsDeleted = cmd.ExecuteNonQuery();

                    if (rowsDeleted > 0)
                    {
                        MessageBox.Show("Order deleted successfully.");
                        dgvOrders.DataSource = GetOrdersData();
                    }
                    else
                    {
                        MessageBox.Show("Order could not be deleted.");
                    }

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

