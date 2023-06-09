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
    public partial class ManufacturingForm : Form
    {
        public ManufacturingForm()
        {
            InitializeComponent();
        }

        private void ManufacturingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'factoryStockManagementSystemDataSet2.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.factoryStockManagementSystemDataSet2.Products);
            // TODO: This line of code loads data into the 'factoryStockManagementSystemDataSet2.Warehouses' table. You can move, or remove it, as needed.
            this.warehousesTableAdapter.Fill(this.factoryStockManagementSystemDataSet2.Warehouses);

        }

        private DataTable GetProductData()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FactoryStockManagementSystem"].ConnectionString))
            {
                string query = "SELECT * FROM Products";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        private void btnListWarehouses_Click(object sender, EventArgs e)
        {
            this.Close();
            WarehousesForm wareHousesForm = new WarehousesForm();
            wareHousesForm.Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductId.Text))
            {
                MessageBox.Show("You cannot specify an ID number while adding a product!");
                return;
            }

            string productName = txtProductName.Text;
            string productDesc = txtProductDescription.Text;
            decimal price = Convert.ToDecimal(txtProductPrice.Text);

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FactoryStockManagementSystem"].ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Products (ProductName, ProductDescription, Price) VALUES (@ProductName, @ProductDesc, @Price)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@ProductDesc", productDesc);
                    cmd.Parameters.AddWithValue("@Price", price);
                    int rowsInserted = cmd.ExecuteNonQuery();

                    if (rowsInserted > 0)
                    {
                        MessageBox.Show("Product added successfully.");
                        dgvProducts.DataSource = GetProductData();
                    }
                    else
                    {
                        MessageBox.Show("Product could not be added.");
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

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            int productId;
            decimal price;
            try
            {
                productId = Convert.ToInt32(txtProductId.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            string productName = txtProductName.Text;
            string productDesc = txtProductDescription.Text;
            try
            {
                price = Convert.ToDecimal(txtProductPrice.Text);
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
                    string query = "UPDATE Products SET ProductName=@ProductName, ProductDescription=@ProductDesc, Price=@Price WHERE Id=@ProductId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@ProductDesc", productDesc);
                    cmd.Parameters.AddWithValue("@Price", price);
                    int rowsUpdated = cmd.ExecuteNonQuery();

                    if (rowsUpdated > 0)
                    {
                        MessageBox.Show("Product updated successfully.");
                        dgvProducts.DataSource = GetProductData();
                    }
                    else
                    {
                        MessageBox.Show("Product could not be updated.");
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

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(txtProductId.Text);

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FactoryStockManagementSystem"].ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Products WHERE Id=@ProductId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    int rowsDeleted = cmd.ExecuteNonQuery();

                    if (rowsDeleted > 0)
                    {
                        MessageBox.Show("Product deleted successfully.");
                        dgvProducts.DataSource = GetProductData();
                    }
                    else
                    {
                        MessageBox.Show("Product could not be deleted.");
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

