namespace AmaZon
{
    partial class HR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HR));
            this.panel28 = new System.Windows.Forms.Panel();
            this.viewcartbutton = new System.Windows.Forms.Button();
            this.menubutton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.home = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.Button();
            this.contactbutton = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.panel28.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel28
            // 
            this.panel28.BackColor = System.Drawing.Color.Black;
            this.panel28.Controls.Add(this.viewcartbutton);
            this.panel28.Controls.Add(this.menubutton);
            this.panel28.ForeColor = System.Drawing.Color.Black;
            this.panel28.Location = new System.Drawing.Point(3, -2);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(795, 52);
            this.panel28.TabIndex = 11;
            // 
            // viewcartbutton
            // 
            this.viewcartbutton.Location = new System.Drawing.Point(729, 9);
            this.viewcartbutton.Name = "viewcartbutton";
            this.viewcartbutton.Size = new System.Drawing.Size(63, 33);
            this.viewcartbutton.TabIndex = 18;
            this.viewcartbutton.Text = "View Cart";
            this.viewcartbutton.UseVisualStyleBackColor = true;
            // 
            // menubutton
            // 
            this.menubutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menubutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menubutton.BackgroundImage")));
            this.menubutton.Location = new System.Drawing.Point(12, 9);
            this.menubutton.Name = "menubutton";
            this.menubutton.Size = new System.Drawing.Size(51, 33);
            this.menubutton.TabIndex = 2;
            this.menubutton.Text = "Menu";
            this.menubutton.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.Controls.Add(this.home);
            this.flowLayoutPanel1.Controls.Add(this.Profile);
            this.flowLayoutPanel1.Controls.Add(this.contactbutton);
            this.flowLayoutPanel1.Controls.Add(this.Logout);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 56);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(201, 396);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Black;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.home.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.home.Location = new System.Drawing.Point(3, 3);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(150, 36);
            this.home.TabIndex = 5;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            // 
            // Profile
            // 
            this.Profile.BackColor = System.Drawing.Color.Black;
            this.Profile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Profile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Profile.Location = new System.Drawing.Point(3, 45);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(150, 31);
            this.Profile.TabIndex = 4;
            this.Profile.Text = "Profile Info";
            this.Profile.UseVisualStyleBackColor = false;
            // 
            // contactbutton
            // 
            this.contactbutton.BackColor = System.Drawing.Color.Black;
            this.contactbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.contactbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.contactbutton.Location = new System.Drawing.Point(3, 82);
            this.contactbutton.Name = "contactbutton";
            this.contactbutton.Size = new System.Drawing.Size(150, 31);
            this.contactbutton.TabIndex = 1;
            this.contactbutton.Text = "Contact us";
            this.contactbutton.UseVisualStyleBackColor = false;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.SystemColors.WindowText;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Logout.Location = new System.Drawing.Point(0, 116);
            this.Logout.Margin = new System.Windows.Forms.Padding(0);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(156, 30);
            this.Logout.TabIndex = 3;
            this.Logout.Text = "Log out";
            this.Logout.UseVisualStyleBackColor = false;
            // 
            // HR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel28);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "HR";
            this.Text = "HR";
            this.panel28.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Button viewcartbutton;
        private System.Windows.Forms.Button menubutton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button Profile;
        private System.Windows.Forms.Button contactbutton;
        private System.Windows.Forms.Button Logout;
    }
}