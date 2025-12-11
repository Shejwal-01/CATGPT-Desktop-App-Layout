using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            ActivateButton(btnSender);
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
           
            ActivateButton(sender);

        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SignForm(), sender);
            ActivateButton(sender);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AboutForm(), sender);
            ActivateButton(sender);
        }

        
    }    
}
