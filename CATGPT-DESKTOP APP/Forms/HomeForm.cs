using System;
using System.Drawing;
using System.Windows.Forms;

namespace CATGPT_DESKTOP_APP.Forms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            InputBox.Text = "Enter your text here..";
            InputBox.ForeColor = Color.Silver;
        }
        private void InputBox_Enter(object sender, EventArgs e)
        {
            if (InputBox.Text == "Enter your text here..")
            {
                InputBox.Text = "";
                InputBox.ForeColor = Color.White;
            }
        }
        private void InputBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InputBox.Text))
            {
                InputBox.Text = "Enter your text here..";
                InputBox.ForeColor = Color.Silver;
            }
        }

        private void HomeForm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InputBox.Text))
            {
                InputBox.Text = "Enter your text here..";
                InputBox.ForeColor = Color.Silver;
            }
        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {        
            if (string.IsNullOrWhiteSpace(InputBox.Text))
            {
                InputBox.Text = "Enter your text here..";
                InputBox.ForeColor = Color.Silver;
            }
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
