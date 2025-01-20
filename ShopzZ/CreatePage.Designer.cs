namespace AmaZon
{
    partial class CreatePage
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
            this.title = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.createaccount = new System.Windows.Forms.Button();
            this.Showpass = new System.Windows.Forms.CheckBox();
            this.email = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.createpassword = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.retypepassword = new System.Windows.Forms.TextBox();
            this.retypepasswordlabel = new System.Windows.Forms.Label();
            this.genderlabel = new System.Windows.Forms.Label();
            this.backtologin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(185, 47);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(461, 55);
            this.title.TabIndex = 17;
            this.title.Text = "Create New account";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(298, 107);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(35, 13);
            this.namelabel.TabIndex = 16;
            this.namelabel.Text = "Name";
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Location = new System.Drawing.Point(298, 146);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(32, 13);
            this.emaillabel.TabIndex = 15;
            this.emaillabel.Text = "Email";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(301, 123);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(202, 20);
            this.name.TabIndex = 14;
            // 
            // createaccount
            // 
            this.createaccount.Location = new System.Drawing.Point(301, 337);
            this.createaccount.Name = "createaccount";
            this.createaccount.Size = new System.Drawing.Size(202, 23);
            this.createaccount.TabIndex = 13;
            this.createaccount.Text = "Create new account";
            this.createaccount.UseVisualStyleBackColor = true;
            this.createaccount.Click += new System.EventHandler(this.createaccount_Click);
            // 
            // Showpass
            // 
            this.Showpass.AutoSize = true;
            this.Showpass.Location = new System.Drawing.Point(301, 314);
            this.Showpass.Name = "Showpass";
            this.Showpass.Size = new System.Drawing.Size(102, 17);
            this.Showpass.TabIndex = 11;
            this.Showpass.Text = "Show Password";
            this.Showpass.UseVisualStyleBackColor = true;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(301, 162);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(202, 20);
            this.email.TabIndex = 10;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(298, 232);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(53, 13);
            this.passwordlabel.TabIndex = 19;
            this.passwordlabel.Text = "Password";
            // 
            // createpassword
            // 
            this.createpassword.Location = new System.Drawing.Point(301, 248);
            this.createpassword.Name = "createpassword";
            this.createpassword.Size = new System.Drawing.Size(202, 20);
            this.createpassword.TabIndex = 18;
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(301, 205);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(202, 21);
            this.gender.TabIndex = 20;
            // 
            // retypepassword
            // 
            this.retypepassword.Location = new System.Drawing.Point(301, 288);
            this.retypepassword.Name = "retypepassword";
            this.retypepassword.Size = new System.Drawing.Size(202, 20);
            this.retypepassword.TabIndex = 21;
            // 
            // retypepasswordlabel
            // 
            this.retypepasswordlabel.AutoSize = true;
            this.retypepasswordlabel.Location = new System.Drawing.Point(298, 271);
            this.retypepasswordlabel.Name = "retypepasswordlabel";
            this.retypepasswordlabel.Size = new System.Drawing.Size(93, 13);
            this.retypepasswordlabel.TabIndex = 22;
            this.retypepasswordlabel.Text = "Re-type Password";
            // 
            // genderlabel
            // 
            this.genderlabel.AutoSize = true;
            this.genderlabel.Location = new System.Drawing.Point(298, 189);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(42, 13);
            this.genderlabel.TabIndex = 23;
            this.genderlabel.Text = "Gender";
            // 
            // backtologin
            // 
            this.backtologin.Location = new System.Drawing.Point(12, 12);
            this.backtologin.Name = "backtologin";
            this.backtologin.Size = new System.Drawing.Size(75, 23);
            this.backtologin.TabIndex = 24;
            this.backtologin.Text = "Back";
            this.backtologin.UseVisualStyleBackColor = true;
            this.backtologin.Click += new System.EventHandler(this.backtologin_Click);
            // 
            // CreatePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backtologin);
            this.Controls.Add(this.genderlabel);
            this.Controls.Add(this.retypepasswordlabel);
            this.Controls.Add(this.retypepassword);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.createpassword);
            this.Controls.Add(this.title);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.createaccount);
            this.Controls.Add(this.Showpass);
            this.Controls.Add(this.email);
            this.Name = "CreatePage";
            this.Text = "AmaZon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button createaccount;
        private System.Windows.Forms.CheckBox Showpass;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox createpassword;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.TextBox retypepassword;
        private System.Windows.Forms.Label retypepasswordlabel;
        private System.Windows.Forms.Label genderlabel;
        private System.Windows.Forms.Button backtologin;
    }
}