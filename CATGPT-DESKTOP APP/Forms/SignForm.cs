using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CATGPT_DESKTOP_APP.Forms
{
    public partial class SignForm : Form
    {
        public SignForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string username = textuname.Text;
            string password = textpswd.Text;

            string connectionString = "server=localhost;database=catgpt_users;uid=root;pwd=shejwal;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT id FROM signin_creds WHERE username=@user AND password=@pass";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Login Successful!");

                        HomeForm hf = new HomeForm();
                        hf.TopLevel = false;
                        hf.FormBorderStyle = FormBorderStyle.None;
                        hf.Dock = DockStyle.Fill;

                        panel1.Controls.Clear();
                        panel1.Controls.Add(hf);

                        hf.Show();

                    }
                    else
                    {
                        MessageBox.Show("Invalid User ID or Password!");
                    }
                }

                    
            }
        }
    }
}

