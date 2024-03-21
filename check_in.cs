using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Microsoft.IdentityModel.Tokens;

namespace MiniProjectE
{
    public partial class check_in : Form
    {
        public check_in()
        {
            InitializeComponent();
        }

        private void reserve_Click(object sender, EventArgs e)
        {
            //add input validation

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC05\SQLEXPRESS; Initial Catalog=MiniProjectE; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                string insertQuery = "INSERT INTO Orders VALUES (@OrderAmount, @cName, @pNumber, @cBill, @oDate)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, sqlCon);

                // Set parameters based on selected values
                insertCmd.Parameters.AddWithValue("@OrderAmount", numberDishes.Text);
                insertCmd.Parameters.AddWithValue("@cName", clientName.Text);
                insertCmd.Parameters.AddWithValue("@pNumber", phoneNumber.Text);
                insertCmd.Parameters.AddWithValue("@cBill", bill.Text);
                insertCmd.Parameters.AddWithValue("@oDate", orderDate.Text);

                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Order Successful!");
            }

        }

        private void phoneNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (!(phoneNumber.Text.StartsWith("+359")) || phoneNumber.Text.Length < 13)
            {
                MessageBox.Show("Enter a valid Bulgarian phone number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phoneNumber.SelectAll();
                e.Cancel = true;
            }
        }

        private void clientName_Validating(object sender, CancelEventArgs e)
        {
            if (clientName.Text.Length <= 5)
            {
                MessageBox.Show("Username should be at least 5 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clientName.SelectAll();
                e.Cancel = true;
            }
        }

        private void bill_Validating(object sender, CancelEventArgs e)
        {
            if (!(bill.Text.Any(char.IsDigit)))
            {
                MessageBox.Show("Bill should just be a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bill.SelectAll();
                e.Cancel = true;
            }
        }
        private void orderDate_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (orderDate.Text != string.Empty)
            {
                if (!IsValidDate(orderDate.Text))
                {
                    MessageBox.Show("Date not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    orderDate.SelectAll();
                    e.Cancel = true;
                }
            }
        }
        public static bool IsValidDate(string odate)
        {
            string date = @"^\d{1,2}\/\d{1,2}\/\d{2,4}$";

            if (string.IsNullOrEmpty(odate))
                return false;

            Regex regex = new Regex(date);
            return regex.IsMatch(odate);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC05\SQLEXPRESS; Initial Catalog=MiniProjectE; Integrated Security=True;"))
            {
                sqlCon.Open();

                string updateQuery = "UPDATE Orders SET OrderAmount = @OrderAmount, cName = @cName, cBill = @cBill, oDate = @oDate WHERE pNumber = @pNumber";
                SqlCommand updateCmd = new SqlCommand(updateQuery, sqlCon);

                updateCmd.Parameters.AddWithValue("@OrderAmount", numberDishes.Text);
                updateCmd.Parameters.AddWithValue("@cName", clientName.Text);
                updateCmd.Parameters.AddWithValue("@cBill", bill.Text);
                updateCmd.Parameters.AddWithValue("@oDate", orderDate.Text);
                updateCmd.Parameters.AddWithValue("@pNumber", phoneNumber.Text);

                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Order Updated Successfully!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC05\SQLEXPRESS; Initial Catalog=MiniProjectE; Integrated Security=True;"))
                {
                    sqlCon.Open();

                    string deleteQuery = "DELETE FROM Orders WHERE pNumber = @pNumber";
                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, sqlCon);

                    deleteCmd.Parameters.AddWithValue("@pNumber", phoneNumber.Text);

                    deleteCmd.ExecuteNonQuery();

                    MessageBox.Show("Order Deleted Successfully!");
                }
            }
        }
    }
}
