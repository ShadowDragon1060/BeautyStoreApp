using BeautyStoreApp.Data;
using BeautyStoreApp.Utilities;
using BeautyStoreApp.Models; 
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BeautyStoreApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            
            this.AcceptButton = btnLogin;

            
            this.ActiveControl = textBox1;


            textBox2.UseSystemPasswordChar = true;

            
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderColor = Color.HotPink;
            btnLogin.FlatAppearance.BorderSize = 1;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 220, 230);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 182, 193);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text.Trim();
            string pass = textBox2.Text; 

            
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                
                MessageBox.Show("Please enter both username and password.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string hashedPass = HashHelper.HashPassword(pass);

            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Role FROM Users WHERE Username = @user AND Password = @pass";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@pass", hashedPass);

                    object result = cmd.ExecuteScalar();

                    
                    if (result != null)
                    {
                        string role = result.ToString();

                        this.Hide(); 

                        
                        if (role == "Admin")
                        {
                            Admin loggedInUser = new Admin();
                            loggedInUser.Name = user;

                            AdminDashboard adminForm = new AdminDashboard(loggedInUser.Name);
                            adminForm.Show();
                        }
                        else if (role == "Staff" || role == "SalesStaff")
                        {
                            SalesStaff loggedInUser = new SalesStaff();
                            loggedInUser.Name = user;

                            StaffDashboard staffForm = new StaffDashboard(loggedInUser.Name);
                            staffForm.Show();
                        }
                    }
                    else
                    {
                        
                        
                        textBox2.Clear();
                        textBox2.Focus();
                        MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact your System Administrator (Waseequr Rahman) to reset your password.", "Security Access", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
        }
    }
}