namespace AmaZon
{
    partial class Productpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productpage));
            this.ProductPhoto = new System.Windows.Forms.PictureBox();
            this.addtocart = new System.Windows.Forms.Button();
            this.buyitem = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.productname = new System.Windows.Forms.Label();
            this.description1 = new System.Windows.Forms.Label();
            this.description2 = new System.Windows.Forms.Label();
            this.description3 = new System.Windows.Forms.Label();
            this.description4 = new System.Windows.Forms.Label();
            this.backtoHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductPhoto
            // 
            this.ProductPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProductPhoto.BackgroundImage")));
            this.ProductPhoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("ProductPhoto.InitialImage")));
            this.ProductPhoto.Location = new System.Drawing.Point(12, 82);
            this.ProductPhoto.Name = "ProductPhoto";
            this.ProductPhoto.Size = new System.Drawing.Size(378, 341);
            this.ProductPhoto.TabIndex = 0;
            this.ProductPhoto.TabStop = false;
            // 
            // addtocart
            // 
            this.addtocart.Location = new System.Drawing.Point(406, 347);
            this.addtocart.Name = "addtocart";
            this.addtocart.Size = new System.Drawing.Size(382, 35);
            this.addtocart.TabIndex = 1;
            this.addtocart.Text = "Add to cart";
            this.addtocart.UseVisualStyleBackColor = true;
            this.addtocart.Click += new System.EventHandler(this.addtocart_Click);
            // 
            // buyitem
            // 
            this.buyitem.Location = new System.Drawing.Point(406, 388);
            this.buyitem.Name = "buyitem";
            this.buyitem.Size = new System.Drawing.Size(382, 35);
            this.buyitem.TabIndex = 2;
            this.buyitem.Text = "Buy item";
            this.buyitem.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(406, 301);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // productname
            // 
            this.productname.AutoSize = true;
            this.productname.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productname.Location = new System.Drawing.Point(396, 82);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(332, 55);
            this.productname.TabIndex = 4;
            this.productname.Text = "Product Name";
            // 
            // description1
            // 
            this.description1.AutoSize = true;
            this.description1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description1.Location = new System.Drawing.Point(403, 156);
            this.description1.Name = "description1";
            this.description1.Size = new System.Drawing.Size(99, 20);
            this.description1.TabIndex = 5;
            this.description1.Text = "description 1";
            // 
            // description2
            // 
            this.description2.AutoSize = true;
            this.description2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description2.Location = new System.Drawing.Point(403, 192);
            this.description2.Name = "description2";
            this.description2.Size = new System.Drawing.Size(99, 20);
            this.description2.TabIndex = 6;
            this.description2.Text = "description 2";
            // 
            // description3
            // 
            this.description3.AutoSize = true;
            this.description3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description3.Location = new System.Drawing.Point(403, 226);
            this.description3.Name = "description3";
            this.description3.Size = new System.Drawing.Size(99, 20);
            this.description3.TabIndex = 7;
            this.description3.Text = "description 3";
            // 
            // description4
            // 
            this.description4.AutoSize = true;
            this.description4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description4.Location = new System.Drawing.Point(403, 259);
            this.description4.Name = "description4";
            this.description4.Size = new System.Drawing.Size(99, 20);
            this.description4.TabIndex = 8;
            this.description4.Text = "description 4";
            // 
            // backtoHome
            // 
            this.backtoHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backtoHome.Location = new System.Drawing.Point(713, 12);
            this.backtoHome.Name = "backtoHome";
            this.backtoHome.Size = new System.Drawing.Size(75, 23);
            this.backtoHome.TabIndex = 9;
            this.backtoHome.Text = "Back";
            this.backtoHome.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.backtoHome);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 10;
            // 
            // Productpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.description4);
            this.Controls.Add(this.description3);
            this.Controls.Add(this.description2);
            this.Controls.Add(this.description1);
            this.Controls.Add(this.productname);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buyitem);
            this.Controls.Add(this.addtocart);
            this.Controls.Add(this.ProductPhoto);
            this.Name = "Productpage";
            this.Text = "Productpage";
            ((System.ComponentModel.ISupportInitialize)(this.ProductPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ProductPhoto;
        private System.Windows.Forms.Button addtocart;
        private System.Windows.Forms.Button buyitem;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label productname;
        private System.Windows.Forms.Label description1;
        private System.Windows.Forms.Label description2;
        private System.Windows.Forms.Label description3;
        private System.Windows.Forms.Label description4;
        private System.Windows.Forms.Button backtoHome;
        private System.Windows.Forms.Panel panel1;
    }
}