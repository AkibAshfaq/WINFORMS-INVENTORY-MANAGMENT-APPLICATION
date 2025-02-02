using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AmaZon
{


    public partial class HomePage : Form
    {

        public static BindingList<ItemModel> Items { get; set; } = new BindingList<ItemModel>();
        public int CheckoutAmount = 0;
        public HomePage()
        {
            InitializeComponent();
            homepagepanel.Visible = true;
            homeappliencespage.Visible = false;
            electronicspage.Visible = false;
            furniturepage.Visible = false;
            groceriespage.Visible = false;
            userinfo.Visible = false;
            contactpanel.Visible = false;
            viewcartpanel.Visible = false;
            paymentpanel.Visible = false;
            

            ProductShow();
            data.DataSource = Items;
            data.Font = new Font("Centure" , 16);
            data.AutoSize = true;
            data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            data.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            data.CellValueChanged += Data_CellValueChanged;
            data.UserDeletingRow += Data_UserDeletingRow;
            totalammount.Text = CheckoutAmount.ToString();
        }


        public int userid;
        //Array for adding item
        public string itemarray;


        SqlConnection connection;
        public void DBconnection()
        {
            connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\CODE Files\\VS 2022\\ShopzZ\\DB\\DemoDB.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=false");
            connection.Open();
        }


        // Sidebar Animation
        public bool panalsize = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (!panalsize)
            {
                dropdownpanel.Height += 210;
                panalsize = true;
            }
            else
            {
                dropdownpanel.Height -= 210;
                panalsize = false;
            }
        }

        public bool sidebar = false;
        private void button5_Click(object sender, EventArgs e)
        {
            if (!sidebar)
            {
                flowLayoutPanel1.Width += 137;
                sidebar = true;
            }
            else
            {
                flowLayoutPanel1.Width -= 137;
                sidebar = false;
            }
        }

        private void HomeApplience_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = false;
            homeappliencespage.Visible = true;
            electronicspage.Visible = false;
            furniturepage.Visible = false;
            groceriespage.Visible = false;
            userinfo.Visible = false;
            contactpanel.Visible = false;
            viewcartpanel.Visible = false;
            paymentpanel.Visible = false;
        }

        private void Electronics_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = false;
            homeappliencespage.Visible = false;
            electronicspage.Visible = true;
            furniturepage.Visible = false;
            groceriespage.Visible = false;
            userinfo.Visible = false;
            contactpanel.Visible = false;
            viewcartpanel.Visible = false;
            paymentpanel.Visible = false;
        }

        private void groceries_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = false;
            homeappliencespage.Visible = false;
            electronicspage.Visible = false;
            furniturepage.Visible = false;
            groceriespage.Visible = true;
            userinfo.Visible = false;
            contactpanel.Visible = false;
            viewcartpanel.Visible = false;
            paymentpanel.Visible = false;
        }

        private void furniture_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = false;
            homeappliencespage.Visible = false;
            electronicspage.Visible = false;
            furniturepage.Visible = true;
            groceriespage.Visible = false;
            userinfo.Visible = false;
            contactpanel.Visible = false;
            viewcartpanel.Visible = false;
            paymentpanel.Visible = false;
        }



        private void home_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = true;
            homeappliencespage.Visible = false;
            electronicspage.Visible = false;
            furniturepage.Visible = false;
            groceriespage.Visible = false;
            userinfo.Visible = false;
            contactpanel.Visible = false;
            viewcartpanel.Visible = false;
            paymentpanel.Visible = false;
        }

        // Password Validity
        public bool IsPasswordStrong(string password)
        {
            if (password.Length < 8)
                return false;

            bool hasUpper = false, hasLower = false, hasDigit = false, hasSpecial = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                else if (char.IsLower(c)) hasLower = true;
                else if (char.IsDigit(c)) hasDigit = true;
                else if ("!@#$%^&*".Contains(c)) hasSpecial = true;

                if (hasUpper && hasLower && hasDigit && hasSpecial)
                    return true;
            }
            return false;
        }

        // Email Validity
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            return true;
        }

        // profile info show panel

        public string userpass;
        private void Profile_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = false;
            homeappliencespage.Visible = false;
            electronicspage.Visible = false;
            furniturepage.Visible = false;
            groceriespage.Visible = false;
            userinfo.Visible = true;
            contactpanel.Visible = false;
            viewcartpanel.Visible = false;
            paymentpanel.Visible = false;

            try
            {

                DBconnection();
                SqlCommand profileinformation = new SqlCommand("select * from usertable where UID_number = @num", connection);
                profileinformation.Parameters.AddWithValue("@num", userid);
                SqlDataReader reader = profileinformation.ExecuteReader();
                while (reader.Read())
                {
                    namebox.Text = Convert.ToString(reader.GetValue(2));
                    mailbox.Text = Convert.ToString(reader.GetValue(3));
                    genderbox.Text = Convert.ToString(reader.GetValue(4));
                    adressbox.Text = Convert.ToString(reader.GetValue(6) + " " + reader.GetValue(5));
                    countrybox.Text = Convert.ToString(reader.GetValue(5));
                    statebox.Text = Convert.ToString(reader.GetValue(6));
                    userpass = Convert.ToString(reader.GetValue(7));

                }
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in Profile Click");
            }
        }

        private void contactbutton_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = false;
            homeappliencespage.Visible = false;
            electronicspage.Visible = false;
            furniturepage.Visible = false;
            groceriespage.Visible = false;
            userinfo.Visible = false;
            contactpanel.Visible = true;
            viewcartpanel.Visible = false;
            paymentpanel.Visible = false;
        }

        private void viewcartbutton_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = false;
            homeappliencespage.Visible = false;
            electronicspage.Visible = false;
            furniturepage.Visible = false;
            groceriespage.Visible = false;
            userinfo.Visible = false;
            contactpanel.Visible = false;
            viewcartpanel.Visible = true;
            paymentpanel.Visible = false;

            
        }

        private void save_Click(object sender, EventArgs e)
        {
            string name = namebox.Text.ToString();
            string mail = mailbox.Text.ToString().Trim();
            string newpass = newpassbox.Text.ToString();
            string confirmpass = confirmpassbox.Text.ToString();
            string currpass = currentpassbox.Text.ToString();
            string gender = genderbox.Text.ToString();
            string country = countrybox.Text.ToString();
            string city = statebox.Text.ToString();

            if (string.Equals(currpass, userpass))
            {

                if (IsValidEmail(mail))
                {
                    if (string.IsNullOrEmpty(newpass) && string.IsNullOrEmpty(confirmpass))
                    {
                        try
                        {
                            DBconnection();
                            SqlCommand saveUser = new SqlCommand("update usertable set user_name = @name , user_mail = @mail, user_gender = @gender, user_adress_country = @country, user_adress_city = @city WHERE UID_number = @userId", connection);
                            saveUser.Parameters.AddWithValue("@name", name);
                            saveUser.Parameters.AddWithValue("@mail", mail);
                            saveUser.Parameters.AddWithValue("@gender", gender);
                            saveUser.Parameters.AddWithValue("@country", country);
                            saveUser.Parameters.AddWithValue("@city", city);
                            saveUser.Parameters.AddWithValue("@userId", userid);
                            saveUser.ExecuteNonQuery();
                            connection.Close();

                            MessageBox.Show("UPDATED");

                            newpassbox.Text = "";
                            confirmpassbox.Text = "";
                            currentpassbox.Text = "";
                        }
                        catch (Exception ex) 
                        {
                            MessageBox.Show("Error In Saving Data");
                        }
                    }
                    else
                    {
                        if (string.Equals(newpass, confirmpass))
                        {
                            if(IsPasswordStrong(newpass))
                            {
                                try
                                {
                                    DBconnection();
                                    SqlCommand saveUser = new SqlCommand("update usertable set user_name = @name , user_mail = @mail, user_gender = @gender, user_pass = @pass, user_adress_country = @country, user_adress_city = @city WHERE UID_number = @userId", connection);
                                    saveUser.Parameters.AddWithValue("@name", name);
                                    saveUser.Parameters.AddWithValue("@mail", mail);
                                    saveUser.Parameters.AddWithValue("@gender", gender);
                                    saveUser.Parameters.AddWithValue("@pass", newpass);
                                    saveUser.Parameters.AddWithValue("@country", country);
                                    saveUser.Parameters.AddWithValue("@city", city);
                                    saveUser.Parameters.AddWithValue("@userId", userid);
                                    saveUser.ExecuteNonQuery();
                                    connection.Close();

                                    MessageBox.Show("UPDATED");


                                    newpassbox.Text = "";
                                    confirmpassbox.Text = "";
                                    currentpassbox.Text = "";
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error In Saving Data");
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("Current password not strong");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Current password doesn't match");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Mail");
                }
            }
            else
            { 
                MessageBox.Show("Invalid Pass"); 
            } 
        }


        private void checkoutbutton_Click(object sender, EventArgs e)
        {
            if(true)  // logic for no item
            {
                homepagepanel.Visible = false;
                homeappliencespage.Visible = false;
                electronicspage.Visible = false;
                furniturepage.Visible = false;
                groceriespage.Visible = false;
                userinfo.Visible = false;
                contactpanel.Visible = false;
                viewcartpanel.Visible = false;
            
                paymentpanel.Visible = true;

                cardpaypanel.Visible = false;
                proceedtopaywithcard.Visible = false;

                cashondelivarypanel.Visible = false;
                proceedtoCOD.Visible = false;
                
            }
        }

        

        private void mastercardbutton_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = false;
            homeappliencespage.Visible = false;
            electronicspage.Visible = false;
            furniturepage.Visible = false;
            groceriespage.Visible = false;
            userinfo.Visible = false;
            contactpanel.Visible = false;
            viewcartpanel.Visible = false;
            paymentpanel.Visible = true;

            cardpaypanel.Visible = true;
            proceedtopaywithcard.Visible = true;

            cashondelivarypanel.Visible = false;
            proceedtoCOD.Visible = false;

            string name = nameoncardbox.Text.ToString();
            string date = expirydatebox.Text.ToString();
            string code = securitycodebox.Text.ToString();
            string card = cardnumbox.Text.ToString().Trim();

            

            //Retriving card info If Available
            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(date) && string.IsNullOrEmpty(code) && string.IsNullOrEmpty(card))
            {
                try
                {
                    DBconnection();
                    SqlCommand hasinfo = new SqlCommand("SELECT * FROM CARDTABLE WHERE CARD_UID = @USERID", connection);
                    hasinfo.Parameters.AddWithValue("@USERID", userid);
                    SqlDataReader read1 = hasinfo.ExecuteReader();
                    while (read1.Read())
                    {
                        cardnumbox.Text = Convert.ToString(read1.GetValue(0));
                        nameoncardbox.Text = Convert.ToString(read1.GetValue(1));
                        expirydatebox.Text = Convert.ToString(read1.GetValue(2));
                        securitycodebox.Text = Convert.ToString(read1.GetValue(3));
                    }
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Error in Retriving data from ");
                }
            }
        }

        private void cashbutton_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = false;
            homeappliencespage.Visible = false;
            electronicspage.Visible = false;
            furniturepage.Visible = false;
            groceriespage.Visible = false;
            userinfo.Visible = false;
            contactpanel.Visible = false;
            viewcartpanel.Visible = false;
            
            paymentpanel.Visible = true;

            cardpaypanel.Visible = false;
            proceedtopaywithcard.Visible = false;

            cashondelivarypanel.Visible = true;
            proceedtoCOD.Visible = true;
        }

        private void backfromviewcart_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = true;
            homeappliencespage.Visible = false;
            electronicspage.Visible = false;
            furniturepage.Visible = false;
            groceriespage.Visible = false;
            userinfo.Visible = false;
            contactpanel.Visible = false;
            viewcartpanel.Visible = false;
            paymentpanel.Visible = false;
        }

        private void backtocart_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = false;
            homeappliencespage.Visible = false;
            electronicspage.Visible = false;
            furniturepage.Visible = false;
            groceriespage.Visible = false;
            userinfo.Visible = false;
            contactpanel.Visible = false;
            viewcartpanel.Visible = true;

            paymentpanel.Visible = false;

            cardpaypanel.Visible = false;
            proceedtopaywithcard.Visible = false;

            cashondelivarypanel.Visible = false;
            proceedtoCOD.Visible = false;
        }


        // Product credentials on small box
        public void productadd(string productname, string productdes1, string productdes2, int productprice, int productstock, string catagory, string image)
        {
            
            // Product box add
            Panel productpanel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(237, 322),
                Margin = new Padding(10)
            };

            // Product Image

            PictureBox productImage = new PictureBox
            {
                Size = new Size(205, 189),
                Location = new Point(14, 12),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            if (!string.IsNullOrEmpty(image) && System.IO.File.Exists(image))
            {
                productImage.Image = Image.FromFile(image);
            }

            productpanel.Controls.Add(productImage);

            Label productPrice = new Label
            {
                Text = Convert.ToString(productprice),
                Location = new Point(81, 206),
                AutoSize = true,
                Font = new Font("centaur", 16)
            };

            productpanel.Controls.Add(productPrice);

            Button showDetailsButton = new Button
            {
                Text = "View",
                Location = new Point(32, 230),
                Size = new Size(163, 37),
                BackColor = SystemColors.HighlightText,
                Font = new Font("centaur", 16)
            };

            showDetailsButton.Click += (s, args) =>
            {
                productpageshow(productname, productdes1, productdes2, productprice, productstock, catagory, image);
            };

            productpanel.Controls.Add(showDetailsButton);

            Button addtocart = new Button
            {
                Text = "Add to cart",
                Location = new Point(32, 270),
                Size = new Size(163, 37),
                BackColor = SystemColors.HighlightText,
                Font = new Font("centaur", 16)
            };

            addtocart.Click += (s, args) =>
            {
                ItemModel model = new ItemModel
                {
                    Item = productname,
                    Quantity = Convert.ToDecimal(1),
                    Price = Convert.ToDecimal(productprice),
                    TotalPrice = Convert.ToDecimal(productprice)
                };

                Items.Add(model);
                CheckoutAmount += Convert.ToInt32(model.TotalPrice);
                totalammount.Text = CheckoutAmount.ToString();
                MessageBox.Show("Cart Updated");
            };

            productpanel.Controls.Add(addtocart);


            // Adding to the pages 
            if(catagory == "Groceries")
                groceriespage.Controls.Add(productpanel);
            
            if(catagory == "Furniture")
                furniturepage.Controls.Add (productpanel);
            
            if(catagory == "Home Applience")
                homeappliencespage.Controls.Add(productpanel);
            
            if(catagory == "Electronics")
                electronicspage.Controls.Add(productpanel);

        }


        // Product Info Pop up Panel
        public void productpageshow(string productname, string productdes1, string productdes2, int productprice, int productstock, string catagory, string image)
        {
            Panel productpanel = new Panel
            {
                Location = new Point(200, 120),
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(856, 519),
                Margin = new Padding(10)

            };

            this.Controls.Add(productpanel);
            productpanel.BringToFront();

            PictureBox productImage = new PictureBox
            {
                Size = new Size(468, 423),
                Location = new Point(24, 67),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            if (!string.IsNullOrEmpty(image) && System.IO.File.Exists(image))
            {
                    productImage.Image = Image.FromFile(image);
            }

            productpanel.Controls.Add(productImage);

            Label producrtName = new Label
            {
                Text = productname,
                Location = new Point(498, 67),
                AutoSize = true,
                Font = new Font("centaur", 58)
            };
            productpanel.Controls.Add(producrtName);

            Label descripton1 = new Label
            {
                Text = productdes1,
                Location = new Point(498, 150),
                AutoSize = true,
                Font = new Font("centaur", 16)
            };

            productpanel.Controls.Add(descripton1);

            Label descripton2 = new Label
            {
                Text = productdes2,
                Location = new Point(498, 200),
                AutoSize = true,
                Font = new Font("centaur", 16)
            };

            productpanel.Controls.Add(descripton2);

            Label productPrice = new Label
            {
                Text = Convert.ToString(productprice),
                Location = new Point(498, 250),
                AutoSize = true,
                Font = new Font("centaur", 16)
            };
            productpanel.Controls.Add(productPrice);

            if (productstock != 0)
            {

                Label productStock1 = new Label
                {
                    Text = "In Stock " + Convert.ToString(productstock),
                    Location = new Point(498, 300),
                    AutoSize = true,
                    Font = new Font("centaur", 16)
                };

                productpanel.Controls.Add(productStock1);
            }
            else
            {
                Label productStock2 = new Label
                {
                    Text = "Out of stock",
                    Location = new Point(498, 300),
                    AutoSize = true,
                    Font = new Font("centaur", 16)
                };

                productpanel.Controls.Add(productStock2);
            }

            NumericUpDown ammount = new NumericUpDown
            {
                Location = new Point(498, 350),
                Size = new Size(60, 20),
                Font = new Font("centaur", 16),
                Minimum = 1
            };

            productpanel.Controls.Add(ammount);

            Button back = new Button
            {
                Text = "Back",
                Location = new Point(24, 23),
                Size = new Size(75, 23),
                BackColor = SystemColors.HighlightText,
                Font = new Font("centaur", 16)
            };

            back.Click += (s, args) =>
            {
                productpanel.Dispose();
            };
            productpanel.Controls.Add(back);


            Button buy = new Button
            {
                Text = "Buy",
                Location = new Point(498, 394),
                Size = new Size(347, 46),
                BackColor = SystemColors.HighlightText,
                Font = new Font("centaur", 16)
            };

            buy.Click += (s, args) =>
            {
                int qty = Convert.ToInt32(ammount.Text);
                ItemModel model = new ItemModel
                {
                    Item = productname,
                    Quantity = Convert.ToDecimal(qty),
                    Price = Convert.ToDecimal(productprice),
                    TotalPrice = Convert.ToDecimal(productprice * qty)

                };

                Items.Add(model);
                CheckoutAmount += Convert.ToInt32(model.TotalPrice);
                totalammount.Text = CheckoutAmount.ToString();

                // Opening the cart panel
                homepagepanel.Visible = false;
                homeappliencespage.Visible = false;
                electronicspage.Visible = false;
                furniturepage.Visible = false;
                groceriespage.Visible = false;
                userinfo.Visible = false;
                contactpanel.Visible = false;
                viewcartpanel.Visible = true;
                paymentpanel.Visible = false;
                
                productpanel.Dispose();
            };
            productpanel.Controls.Add(buy);

            Button addtocart = new Button
            {
                Text = "Add to cart",
                Location = new Point(498, 446),
                Size = new Size(347, 44),
                BackColor = SystemColors.HighlightText,
                Font = new Font("centaur", 16)
            };
            
            addtocart.Click += (s, args) =>
            {
                
                int qty = Convert.ToInt32(ammount.Text);
                if(qty > 0)
                {
                    ItemModel model = new ItemModel
                    {
                        Item = productname,
                        Quantity = Convert.ToDecimal(qty),
                        Price = Convert.ToDecimal(productprice),
                        TotalPrice = Convert.ToDecimal(productprice * qty)
                    };

                    Items.Add(model);
                    CheckoutAmount += Convert.ToInt32(model.TotalPrice);
                    totalammount.Text = CheckoutAmount.ToString();
                    MessageBox.Show("Cart Updated");
                }
                else
                {
                    
                }
            };

            productpanel.Controls.Add(addtocart);


        }

        // For Add to cart grid values change
        private void Data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == data.Columns["Quantity"].Index && e.RowIndex >= 0)
            {
                var item = Items[e.RowIndex];
                item.TotalPrice = item.Price * item.Quantity;

                // Update CheckoutAmount
                RecalculateCheckoutAmount();
                totalammount.Text = CheckoutAmount.ToString();
            }
        }

        private void Data_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var item = e.Row.DataBoundItem as ItemModel;
            if (item != null)
            {
                CheckoutAmount -= Convert.ToInt32(item.TotalPrice);
                MessageBox.Show($"Item '{item.Item}' removed. New Total: {CheckoutAmount}");
            }
        }


        private void RecalculateCheckoutAmount()
        {
            CheckoutAmount = Items.Sum(item => Convert.ToInt32(item.TotalPrice)); 
        }

        public void ProductShow()
        {
            try
            {
                DBconnection();
                SqlCommand profileinformation = new SqlCommand("SELECT * FROM PRODUCTTABLE", connection);

                SqlDataReader reader = profileinformation.ExecuteReader();

                while (reader.Read())
                {
                    string productname = Convert.ToString(reader.GetValue(1));
                    string productdes1 = Convert.ToString(reader.GetValue(2));
                    string productdes2 = Convert.ToString(reader.GetValue(3));
                    int product_price = Convert.ToInt32(reader.GetValue(4));
                    int productstock = Convert.ToInt32(reader.GetValue(5));
                    string catagory = Convert.ToString(reader.GetValue(6));
                    string image = Convert.ToString(reader.GetValue(7));

                    productadd(productname, productdes1, productdes2, product_price, productstock, catagory, image);
                }
            }
            catch
            {
                MessageBox.Show("Error in Product ");
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogPage logPage = new LogPage();
            logPage.Visible = true;
        }

        // Luhn Algorithom for card validation
            //Starting from the rightmost digit, double the value of every second digit.
            //If doubling a number results in a two-digit number(greater than 9), add the digits of the product to get a single-digit number.
            //Sum all the digits.
            //If the total modulo 10 is equal to 0, the number is valid according to the Luhn formula; otherwise, it is not valid       
        public static bool IsValidCard(string cardNumber)
        {
            // False for no input
            if (string.IsNullOrWhiteSpace(cardNumber))
                return false;
            
            int sum = 0;
            bool isSecond = false;

            for (int i = cardNumber.Length - 1; i >= 0; i--)
            {
                // false if not digit
                if (!char.IsDigit(cardNumber[i]))
                    return false; 

                int digit = cardNumber[i] - '0';

                if (isSecond)
                {
                    digit *= 2;
                    if (digit > 9)
                        digit -= 9;
                }

                sum += digit;
                isSecond = !isSecond;
            }
            return (sum % 10 == 0);
        }

        // Grobal Variable for Order Table
        public string orders = "";

        private void proceedtopay_Click(object sender, EventArgs e)
        {
            string name = nameoncardbox.Text.ToString();
            string date = expirydatebox.Text.ToString();
            string code = securitycodebox.Text.ToString();
            string card = cardnumbox.Text.ToString().Trim();

            if (IsValidCard(card))
            {
                // Checking If it needs to be saved
                if (savecardnumber.Checked == true)
                {
                    try
                    {
                        DBconnection();
                        SqlCommand savecard = new SqlCommand("INSERT INTO CARDTABLE(CARD_NUMBER, CARD_USERNAME, CARD_EXPIRYDATE, SECURITY_CODE, CARD_UID) " +
                                                             "VALUES(@NUM, @NAME, @DATE, @CODE, @UID)", connection);
                        savecard.Parameters.AddWithValue("@NUM", card);
                        savecard.Parameters.AddWithValue("@NAME", name);
                        savecard.Parameters.AddWithValue("@DATE", date);
                        savecard.Parameters.AddWithValue("@CODE", code);
                        savecard.Parameters.AddWithValue("@UID", userid);

                        savecard.ExecuteReader();
                        connection.Close();
                        orders = ""; // Resetting the Cart Info
                        Items.Clear(); // cart cleared
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error at saving data");
                    }
                }



                string location = shippingadresscard.Text;
                string pay = "CARD";
                try
                {
                    DBconnection();
                    SqlCommand orderconfirm = new SqlCommand("INSERT INTO ORDERTABLE(ORDERS, SHIPPING_LOCATION, PAYMENT_TYPE, PAYMENT_AMMOUNT, UID)" +
                                                                " VALUES (@ODR, @LOC, @PTYPE, @PAMMOUNT, @ID)  ", connection);
                    orderconfirm.Parameters.AddWithValue("@ODR", orders);
                    orderconfirm.Parameters.AddWithValue("@LOC", location);
                    orderconfirm.Parameters.AddWithValue("@PTYPE", pay);
                    orderconfirm.Parameters.AddWithValue("@PAMMOUNT", CheckoutAmount);
                    orderconfirm.Parameters.AddWithValue("@ID", userid);
                    orderconfirm.ExecuteReader();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error at saving the order");
                }

                // Removing the quantity from the DB
                foreach (var i in Items)
                {
                    try
                    {
                        DBconnection();
                        SqlCommand productinfo = new SqlCommand("UPDATE PRODUCTTABLE SET PRODUCT_STOCK = PRODUCT_STOCK - @QTY WHERE PRODUCT_NAME = @NAME", connection);
                        productinfo.Parameters.AddWithValue("@QTY", i.Quantity);
                        productinfo.Parameters.AddWithValue("@NAME", i.Item);
                        SqlDataReader reader = productinfo.ExecuteReader();
                        orders += Convert.ToString(i.Quantity + " X " + i.Item + " \n ");
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error at saving the orders list");
                    }
                }

                MessageBox.Show("Order Confirmed");
            }
        }

        private void proceedtoCOD_Click(object sender, EventArgs e)
        {
            string location = shippingadressbox.Text;
            string pay = "COD";
            try
            {
                DBconnection();
                SqlCommand orderconfirm = new SqlCommand("INSERT INTO ORDERTABLE(ORDERS, SHIPPING_LOCATION, PAYMENT_TYPE, PAYMENT_AMMOUNT, UID)" +
                                                            " (@ODR, @LOC, @PTYPE, @PAMMOUNT, @ID)  ", connection);
                orderconfirm.Parameters.AddWithValue("@ODR", orders);
                orderconfirm.Parameters.AddWithValue("@LOC", location);
                orderconfirm.Parameters.AddWithValue("@PTYPE", pay);
                orderconfirm.Parameters.AddWithValue("@PAMMOUNT", CheckoutAmount);
                orderconfirm.Parameters.AddWithValue("@ID", userid);
                orderconfirm.ExecuteReader();
                connection.Close();

                MessageBox.Show("Order Confirmed");
                orders = ""; // Resetting the Cart Info
                Items.Clear(); // cart cleared
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at COD");
            }
        }
    }
}
