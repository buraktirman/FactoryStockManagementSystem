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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstname.Text) || string.IsNullOrEmpty(txtLastname.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtUserType.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(rtxtAddress.Text))
            {
                MessageBox.Show("Please fill all the required fields.");

            }
            string connectionString = ConfigurationManager.ConnectionStrings["FactoryStockManagementSystem"].ConnectionString;

            int factoryId;
            int userType; 
            string isAdmin;
            string firstName;
            string lastName;
            string username;
            string password;
            string title;
            string phone;
            string address;

            try
            {
                factoryId = Convert.ToInt32(txtFactoryId.Text);
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

            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {


                string query = "INSERT INTO Users (FactoryId, FirstName, LastName, Username, Password, Title, Phone, Address, UserType, IsAdmin) " +
                           "VALUES (@FactoryId, @FirstName, @LastName, @Username, @Password, @Title, @Phone, @Address, @UserType, @IsAdmin)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@FactoryId", factoryId);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@UserType", userType);
                command.Parameters.AddWithValue("@IsAdmin", isAdmin);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Registration successful!");
                    this.Close();
                    WelcomeScreen welcomeScreen = new WelcomeScreen();
                    welcomeScreen.Show();
                }
                else
                {
                    MessageBox.Show("Registration failed! Try again!");
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomeScreen welcomeScreen = new WelcomeScreen();
            welcomeScreen.Show();
        }


    }
}
