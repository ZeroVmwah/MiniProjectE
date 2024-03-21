
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static MiniProjectE.autheticate;
using User = MiniProjectE.autheticate.User;

namespace MiniProjectE
{
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
        }
        private void name_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (name.Text.Length <= 5)
            {
                MessageBox.Show("Username should be at least 5 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                name.Focus();
                e.Cancel = true;
            }
        }

        // Validation for password complexity
        private void loginpassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!(loginpassword.Text.Length > 8 && loginpassword.Text.Any(char.IsUpper) && loginpassword.Text.Any(char.IsLower) && loginpassword.Text.Any(char.IsDigit)))
            {
                MessageBox.Show("One or more password criteria(s) hasn't been met", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginpassword.SelectAll();
                e.Cancel = true;
            }
        }
        private void Si_Click(object sender, EventArgs e)
        {
            string user = name.Text;
            string pass = loginpassword.Text;

            // Validate input before attempting authentication
            if (!string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(pass))
            {
                User authenticatedUser = DatabaseManager.AuthenticateUser(user, pass);

                if (authenticatedUser != null)
                {
                    // Display the username on homepage
                    Filter menu = new Filter(authenticatedUser);
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
        }
    }
}
