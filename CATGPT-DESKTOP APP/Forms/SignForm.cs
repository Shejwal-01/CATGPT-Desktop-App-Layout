using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CATGPT_DESKTOP_APP.Forms
{
    public partial class SignForm : Form
    {
        public SignForm()
        {
            InitializeComponent();
        }

        private void SignForm_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textpswd_TextChanged(object sender, EventArgs e)
        {
            textpswd.PasswordChar = '*';
        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            string username = textuname.Text;
            string password = textpswd.Text;

            string connectionString = "server=localhost;database=catgpt_users;uid=root;pwd=shejwal;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM signin_creds WHERE username=@user AND password=@pass";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                MySqlDataReader reader = cmd.ExecuteReader();

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

        private void textuname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

