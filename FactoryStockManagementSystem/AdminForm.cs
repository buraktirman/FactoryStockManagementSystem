using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FactoryStockManagementSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'factoryStockManagementSystemDataSet3.Factories' table. You can move, or remove it, as needed.
            this.factoriesTableAdapter.Fill(this.factoryStockManagementSystemDataSet3.Factories);
            // TODO: This line of code loads data into the 'factoryStockManagementSystemDataSet3.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.factoryStockManagementSystemDataSet3.Users);

        }

        private DataTable GetUsersData()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FactoryStockManagementSystem"].ConnectionString))
            {
                string query = "SELECT * FROM Users";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        private void btnManufacturingOperations_Click(object sender, EventArgs e)
        {
            this.Close();
            ManufacturingForm manufacturingForm = new ManufacturingForm();
            manufacturingForm.Show();
        }

        private void btnCustomerOperations_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtUserId.Text))
            {
                MessageBox.Show("You cannot specify an ID number while adding an order!");
                return;
            }

            int factoryId, userType;
            string firstName, lastName, username, password, title, phone, address, isAdmin;

            try
            {
                factoryId = (int)cmbFactoryId.SelectedValue;
                userType = Convert.ToInt32(txtUserType.Text);
                isAdmin = cbIsAdmin.SelectedItem.ToString();
                firstName = txtFirstname.Text;
                lastName = txtLastname.Text;
                username = txtUsername.Text;
                password = txtPassword.Text;
                title = txtTitle.Text;
                phone = txtPhone.Text;
                address = rtxtAddress.Text;
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
                    string query = "INSERT INTO Users (FactoryId, FirstName, LastName, Username, Password, Title, Phone, Address, UserType, IsAdmin) " +
                                   "VALUES (@FactoryId, @FirstName, @LastName, @Username, @Password, @Title, @Phone, @Address, @UserType, @IsAdmin)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FactoryId", factoryId);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@UserType", userType);
                    cmd.Parameters.AddWithValue("@IsAdmin", isAdmin);
                    int rowsInserted = cmd.ExecuteNonQuery();

                    if (rowsInserted > 0)
                    {
                        MessageBox.Show("User added successfully.");
                        dgvUsers.DataSource = GetUsersData();
                    }
                    else
                    {
                        MessageBox.Show("User could not be added.");
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

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUserId.Text))
            {
                MessageBox.Show("You must specify an ID number while updating a user!");
                return;
            }

            int userId, factoryId, userType;
            string firstName, lastName, username, password, title, phone, address, isAdmin;

            try
            {
                userId = Convert.ToInt32(txtUserId.Text);
                factoryId = (int)cmbFactoryId.SelectedValue;
                userType = Convert.ToInt32(txtUserType.Text);
                isAdmin = cbIsAdmin.SelectedItem.ToString();
                firstName = txtFirstname.Text;
                lastName = txtLastname.Text;
                username = txtUsername.Text;
                password = txtPassword.Text;
                title = txtTitle.Text;
                phone = txtPhone.Text;
                address = rtxtAddress.Text;
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
                    string query = "UPDATE Users SET FactoryId = @FactoryId, FirstName = @FirstName, LastName = @LastName, " +
                                   "Username = @Username, Password = @Password, Title = @Title, Phone = @Phone, " +
                                   "Address = @Address, UserType = @UserType, IsAdmin = @IsAdmin WHERE Id = @UserId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FactoryId", factoryId);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@UserType", userType);
                    cmd.Parameters.AddWithValue("@IsAdmin", isAdmin);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    int rowsUpdated = cmd.ExecuteNonQuery();

                    if (rowsUpdated > 0)
                    {
                        MessageBox.Show("User updated successfully.");
                        dgvUsers.DataSource = GetUsersData();
                    }
                    else
                    {
                        MessageBox.Show("User could not be updated.");
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

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUserId.Text))
            {
                MessageBox.Show("You must specify an ID number while deleting a user!");
                return;
            }

            int userId;

            try
            {
                userId = Convert.ToInt32(txtUserId.Text);
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
                    string query = "DELETE FROM Users WHERE Id = @UserId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    int rowsDeleted = cmd.ExecuteNonQuery();

                    if (rowsDeleted > 0)
                    {
                        MessageBox.Show("User deleted successfully.");
                        dgvUsers.DataSource = GetUsersData();
                    }
                    else
                    {
                        MessageBox.Show("User could not be deleted.");
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
