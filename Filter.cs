using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.Data.SqlClient;
using static MiniProjectE.autheticate;

namespace MiniProjectE
{
    public partial class Filter : Form
    {
        private User authenticatedUser;
   
            public Filter(User user)
        {
            InitializeComponent();
            authenticatedUser = user;
        }


        // Event handler for when the room type is selected in the ComboBox
        private void course_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Establish a connection to the database
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC05\SQLEXPRESS; Initial Catalog=MiniProjectE; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // SQL query to select rooms based on the selected room type
                string query = "select * from FullMenu where CourseType = @CourseType";

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@CourseType", course.SelectedItem.ToString());

                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void diet_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Establish a connection to the database
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC05\SQLEXPRESS; Initial Catalog=MiniProjectE; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection
                string query2 = "select * from FullMenu where Diet = @Diet AND CourseType = @CourseType";

                SqlCommand cmd2 = new SqlCommand(query2, sqlCon);
                cmd2.Parameters.AddWithValue("@CourseType", course.SelectedItem.ToString());
                cmd2.Parameters.AddWithValue("@Diet", diet.SelectedItem.ToString());

                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd2))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void allergies_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Establish a connection to the database
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC05\SQLEXPRESS; Initial Catalog=MiniProjectE; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection
                string query3 = "select * from FullMenu where CourseType = @CourseType AND Diet = @Diet AND Allergies = @Allergies";

                SqlCommand cmd3 = new SqlCommand(query3, sqlCon);
                cmd3.Parameters.AddWithValue("@CourseType", course.SelectedItem.ToString());
                cmd3.Parameters.AddWithValue("@Diet", diet.SelectedItem.ToString());
                cmd3.Parameters.AddWithValue("@Allergies", allergies.SelectedItem.ToString());

                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd3))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }
        private void psize_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC05\SQLEXPRESS; Initial Catalog=MiniProjectE; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection
                string query4 = "select * from FullMenu where CourseType = @CourseType AND Diet = @Diet AND Allergies = @Allergies AND PortionSize = @PortionSize";

                SqlCommand cmd4 = new SqlCommand(query4, sqlCon);
                cmd4.Parameters.AddWithValue("@CourseType", course.SelectedItem.ToString());
                cmd4.Parameters.AddWithValue("@Diet", diet.SelectedItem.ToString());
                cmd4.Parameters.AddWithValue("@Allergies", allergies.SelectedItem.ToString());
                cmd4.Parameters.AddWithValue("@PortionSize", psize.SelectedItem.ToString());

                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd4))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }
        private void clear_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            course.SelectedIndex = 0;
            diet.SelectedIndex = 0;
            allergies.SelectedIndex = 0;
        }

        private void checkIn_Click(object sender, EventArgs e)
        {
            using (check_in userInputForm = new check_in())
            {
                // Display the form as a dialog
                userInputForm.ShowDialog();

            }
        }
    }
}