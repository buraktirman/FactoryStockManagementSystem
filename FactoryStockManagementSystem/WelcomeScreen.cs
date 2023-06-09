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
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUpWindow = new SignUp();
            signUpWindow.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login loginWindow = new Login();
            loginWindow.Show();
            this.Hide();
        }
    }
}
