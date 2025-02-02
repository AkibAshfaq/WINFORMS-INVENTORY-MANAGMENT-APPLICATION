namespace AmaZon
{
    partial class LogPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogPage));
            this.password = new System.Windows.Forms.TextBox();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.ShopzZtitle = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.adminbutton = new System.Windows.Forms.Button();
            this.errortag = new System.Windows.Forms.Label();
            this.createaccount = new System.Windows.Forms.LinkLabel();
            this.tag = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // password
            // 
            resources.ApplyResources(this.password, "password");
            this.password.ForeColor = System.Drawing.Color.LightGray;
            this.password.Name = "password";
            this.password.Tag = "";
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // showpass
            // 
            resources.ApplyResources(this.showpass, "showpass");
            this.showpass.Name = "showpass";
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // mail
            // 
            resources.ApplyResources(this.mail, "mail");
            this.mail.ForeColor = System.Drawing.Color.LightGray;
            this.mail.Name = "mail";
            this.mail.Enter += new System.EventHandler(this.mail_Enter);
            this.mail.Leave += new System.EventHandler(this.mail_Leave);
            // 
            // ShopzZtitle
            // 
            resources.ApplyResources(this.ShopzZtitle, "ShopzZtitle");
            this.ShopzZtitle.Name = "ShopzZtitle";
            // 
            // login
            // 
            resources.ApplyResources(this.login, "login");
            this.login.Name = "login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // adminbutton
            // 
            resources.ApplyResources(this.adminbutton, "adminbutton");
            this.adminbutton.Name = "adminbutton";
            this.adminbutton.UseVisualStyleBackColor = true;
            this.adminbutton.Click += new System.EventHandler(this.adminbutton_Click);
            // 
            // errortag
            // 
            resources.ApplyResources(this.errortag, "errortag");
            this.errortag.ForeColor = System.Drawing.Color.IndianRed;
            this.errortag.Name = "errortag";
            // 
            // createaccount
            // 
            resources.ApplyResources(this.createaccount, "createaccount");
            this.createaccount.ForeColor = System.Drawing.Color.Black;
            this.createaccount.Name = "createaccount";
            this.createaccount.TabStop = true;
            this.createaccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createaccount_LinkClicked);
            // 
            // tag
            // 
            resources.ApplyResources(this.tag, "tag");
            this.tag.ForeColor = System.Drawing.Color.Black;
            this.tag.Name = "tag";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.ShopzZtitle);
            this.panel1.Controls.Add(this.tag);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.createaccount);
            this.panel1.Controls.Add(this.showpass);
            this.panel1.Controls.Add(this.errortag);
            this.panel1.Controls.Add(this.mail);
            this.panel1.Controls.Add(this.login);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // LogPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adminbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LogPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label ShopzZtitle;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button adminbutton;
        private System.Windows.Forms.Label errortag;
        private System.Windows.Forms.LinkLabel createaccount;
        private System.Windows.Forms.Label tag;
        private System.Windows.Forms.Panel panel1;
    }
}

