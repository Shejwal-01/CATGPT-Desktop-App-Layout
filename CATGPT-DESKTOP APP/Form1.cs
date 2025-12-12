using System;

using System.Windows.Forms;


namespace CATGPT_DESKTOP_APP
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Form activeForm;

        //private Form activeForm;

        public Form1()
        {
            InitializeComponent();
            
        }


        private void ActivateButton(object btnSender)
        {

        }

        private void OpenChildForm(System.Windows.Forms.Form childForm, object btnSender)
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
            this.panelmain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.HomeForm(), null);

            
            
        }
        private void buttonHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.HomeForm(), sender);
           
            

        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SignForm(), sender);
            
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AboutForm(), sender);
            
        }

        
    }    
}
