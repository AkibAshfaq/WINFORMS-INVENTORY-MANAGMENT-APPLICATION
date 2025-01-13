namespace AmaZon
{
    partial class Admin
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
            this.submit = new System.Windows.Forms.Button();
            this.productname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.catagoryselector = new System.Windows.Forms.ComboBox();
            this.productid = new System.Windows.Forms.Label();
            this.productidnum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(359, 306);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 0;
            this.submit.Text = "Add ";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // productname
            // 
            this.productname.Location = new System.Drawing.Point(280, 158);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(266, 20);
            this.productname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Catagory";
            // 
            // catagoryselector
            // 
            this.catagoryselector.FormattingEnabled = true;
            this.catagoryselector.Items.AddRange(new object[] {
            "Home Applience",
            "Electronics",
            "Groceries",
            ""});
            this.catagoryselector.Location = new System.Drawing.Point(280, 204);
            this.catagoryselector.Name = "catagoryselector";
            this.catagoryselector.Size = new System.Drawing.Size(266, 21);
            this.catagoryselector.TabIndex = 4;
            // 
            // productid
            // 
            this.productid.AutoSize = true;
            this.productid.Location = new System.Drawing.Point(184, 121);
            this.productid.Name = "productid";
            this.productid.Size = new System.Drawing.Size(58, 13);
            this.productid.TabIndex = 6;
            this.productid.Text = "Product ID";
            // 
            // productidnum
            // 
            this.productidnum.Location = new System.Drawing.Point(280, 118);
            this.productidnum.Name = "productidnum";
            this.productidnum.Size = new System.Drawing.Size(266, 20);
            this.productidnum.TabIndex = 5;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productid);
            this.Controls.Add(this.productidnum);
            this.Controls.Add(this.catagoryselector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productname);
            this.Controls.Add(this.submit);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox productname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox catagoryselector;
        private System.Windows.Forms.Label productid;
        private System.Windows.Forms.TextBox productidnum;
    }
}