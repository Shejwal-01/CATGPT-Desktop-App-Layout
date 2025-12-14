using System;

using System.Windows.Forms;


namespace CATGPT_DESKTOP_APP
{
    public partial class Form1 : Form
    {
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void OpenChildForm(System.Windows.Forms.Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panelmain.Controls.Clear();
            this.panelmain.Controls.Add(childForm);

            childForm.BringToFront();
            childForm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.HomeForm());

            
            
        }
        private void buttonHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.HomeForm());
           
            

        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SignForm());
            
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AboutForm());
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null; //to force lose focus of textbox cursor


        }


    }    
}
