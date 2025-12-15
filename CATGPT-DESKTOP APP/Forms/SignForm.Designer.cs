namespace CATGPT_DESKTOP_APP.Forms
{
    partial class SignForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.signinbtn = new System.Windows.Forms.Button();
            this.textpswd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textuname = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labeluname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.signinbtn);
            this.panel1.Controls.Add(this.textpswd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textuname);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.labeluname);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // signinbtn
            // 
            this.signinbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signinbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.signinbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.signinbtn.FlatAppearance.BorderSize = 2;
            this.signinbtn.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinbtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.signinbtn.Location = new System.Drawing.Point(485, 367);
            this.signinbtn.Name = "signinbtn";
            this.signinbtn.Size = new System.Drawing.Size(131, 45);
            this.signinbtn.TabIndex = 9;
            this.signinbtn.Text = "Sign-in";
            this.signinbtn.UseVisualStyleBackColor = false;
            this.signinbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // textpswd
            // 
            this.textpswd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textpswd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textpswd.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpswd.ForeColor = System.Drawing.SystemColors.Menu;
            this.textpswd.Location = new System.Drawing.Point(485, 319);
            this.textpswd.Multiline = true;
            this.textpswd.Name = "textpswd";
            this.textpswd.PasswordChar = '*';
            this.textpswd.Size = new System.Drawing.Size(131, 30);
            this.textpswd.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(348, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "password : ";
            // 
            // textuname
            // 
            this.textuname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textuname.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textuname.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textuname.ForeColor = System.Drawing.SystemColors.Menu;
            this.textuname.Location = new System.Drawing.Point(485, 260);
            this.textuname.Multiline = true;
            this.textuname.Name = "textuname";
            this.textuname.Size = new System.Drawing.Size(131, 30);
            this.textuname.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(421, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 164);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // labeluname
            // 
            this.labeluname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeluname.BackColor = System.Drawing.SystemColors.Control;
            this.labeluname.Font = new System.Drawing.Font("Sitka Banner", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluname.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labeluname.Location = new System.Drawing.Point(348, 254);
            this.labeluname.Name = "labeluname";
            this.labeluname.Size = new System.Drawing.Size(131, 36);
            this.labeluname.TabIndex = 1;
            this.labeluname.Text = "username : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignForm";
            this.Text = "SignForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labeluname;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textuname;
        private System.Windows.Forms.TextBox textpswd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signinbtn;
    }
}