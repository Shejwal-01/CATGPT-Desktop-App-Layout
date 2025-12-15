using System;
using System.Drawing;
using System.Windows.Forms;

namespace CATGPT_DESKTOP_APP.Forms
{
    public partial class HomeForm : Form
    {
        private const string PlaceholderText = "Enter your text here..";
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            SetPlaceholder();
          
        }

        private void InputBox_GotFocus(object sender, EventArgs e)
        {
            if (InputBox.Text == PlaceholderText)
            {
                InputBox.Text = "";
                InputBox.ForeColor = Color.White;
            }
        }

        private void InputBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InputBox.Text))
            {
                InputBox.Text = PlaceholderText;
                InputBox.ForeColor = Color.Silver;
            }
        }

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(InputBox.Text))
            {
                InputBox.Text = PlaceholderText;
                InputBox.ForeColor = Color.Silver;
            }
        }

        private void HomeForm_Click(object sender, EventArgs e)
        {
            SetPlaceholder();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null; //to force lose focus of textbox cursor
           

        }

        
    }
}
