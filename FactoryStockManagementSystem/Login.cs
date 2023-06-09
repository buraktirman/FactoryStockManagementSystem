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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void llblDoNotHaveAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUpWindow = new SignUp();
            signUpWindow.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomeScreen welcomeScreen = new WelcomeScreen();
            welcomeScreen.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Create a SQL connection using the connection string from the app.config file
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FactoryStockManagementSystem"].ConnectionString))
            {
                try
                {
                    // Open the connection
                    conn.Open();

                    // Create a SQL command to select the user with the given username and password
                    string query = "SELECT * FROM Users WHERE Username=@Username AND Password=@Password;";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    // Execute the command and get the result
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Login successful
                        MessageBox.Show("Login successful!");

                        reader.Read();
                        int userType = Convert.ToInt32(reader["UserType"]);
                        bool isAdmin = Convert.ToBoolean(reader["IsAdmin"]);

                        // Close the reader
                        reader.Close();

                        // TODO: Navigate to the appropriate form based on the worker type and admin status
                        if (userType == 1)
                        {
                            if (isAdmin)
                            {
                                this.Close();
                                AdminForm adminForm = new AdminForm();
                                adminForm.Show();
                            }
                            else
                            {
                                this.Close();
                                ManufacturingForm manufacturingForm = new ManufacturingForm();
                                manufacturingForm.Show();
                            }
                        }
                        else if (userType == 2)
                        {
                            if (isAdmin)
                            {
                                this.Close();
                                AdminForm adminForm = new AdminForm();
                                adminForm.Show();
                            }
                            else
                            {
                                this.Close();
                                CustomerForm customerForm = new CustomerForm();
                                customerForm.Show();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }

                    reader.Close();
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
