
using System.Data.SqlClient;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MiniProjectE
{
    public partial class Form1 : Form
    {
        private SqlCommand cmd;
        private SqlConnection cn;
        private SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void name_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (name.Text.Length <= 5)
            {
                MessageBox.Show("Username should be at least 5 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                name.SelectAll();
                e.Cancel = true;
            }
        }

        private void mail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (mail.Text != string.Empty)
            {
                if (!IsValidEmail(mail.Text))
                {
                    MessageBox.Show("Email not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mail.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";

            if (string.IsNullOrEmpty(email))
                return false;

            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }

        private void mypassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!(mypassword.Text.Length > 8 && mypassword.Text.Any(char.IsUpper) && mypassword.Text.Any(char.IsDigit)))
            {
                MessageBox.Show("One or more password criteria(s) hasn't been met!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mypassword.SelectAll();
                e.Cancel = true;
            }
        }

        private void mypassword_TextChanged(object sender, EventArgs e)
        {
            length.Show();
            capital.Show();
            number.Show();

            if (mypassword.Text.Length > 8)
                length.ForeColor = Color.Green;
            else
                length.ForeColor = Color.Crimson;

            if (mypassword.Text.Any(char.IsUpper))
                capital.ForeColor = Color.Green;
            else
                capital.ForeColor = Color.Crimson;

            if (mypassword.Text.Any(char.IsDigit))
                number.ForeColor = Color.Green;
            else
                number.ForeColor = Color.Crimson;
        }

        private void dateTimePicker1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int years = DateTime.Now.Year - dateTimePicker1.Value.Year;

            if (dateTimePicker1.Value.AddYears(years) > DateTime.Now) years--;

            if (years < 18)
            {
                MessageBox.Show("Age should be more than 18 years. Please enter a valid Date of Birth!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker1.Focus();
                e.Cancel = true;
            }
        }

        private void phone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!(phone.Text.StartsWith("+359")) || phone.Text.Length < 13)
            {
                MessageBox.Show("Enter a valid Bulgarian phone number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phone.SelectAll();
                e.Cancel = true;
            }
        }

        private void repassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (repassword.Text == string.Empty)
            {
                MessageBox.Show("Cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                repassword.SelectAll();
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (cn = new SqlConnection(@"Data Source=LAB109PC05\SQLEXPRESS; Initial Catalog=userInfo; Integrated Security=True;"))
            {
                cn.Open();

                // Checking if passwords match
                if (!string.IsNullOrEmpty(mypassword.Text))
                {
                    // Checking if the username already exists
                    using (cmd = new SqlCommand("SELECT Username FROM userInfo4 Where Username = @username", cn))
                    {
                        cmd.Parameters.AddWithValue("@username", name.Text);
                        using (dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                MessageBox.Show("Username already exists, please try another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                dr.Close();

                                // Inserting user information into the database

                                using (cmd = new SqlCommand("INSERT INTO userInfo4 VALUES(@Username, @Password, @Email, @Phone)", cn))
                                {
                                    cmd.Parameters.AddWithValue("@username", name.Text);
                                    cmd.Parameters.AddWithValue("@password", mypassword.Text);
                                    cmd.Parameters.AddWithValue("@email", mail.Text);
                                    cmd.Parameters.AddWithValue("@phone", phone.Text);
                                    cmd.ExecuteNonQuery();


                                    MessageBox.Show("Your Account is created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Hide();
                                    Form2 login = new Form2();
                                    login.Show();
                                }
                            }
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Please enter a value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}