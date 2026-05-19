using System;
using System.Drawing;
using System.Windows.Forms;

namespace BeautyStoreApp
{
    public partial class AdminDashboard : Form
    {
        private string loggedInAdmin;
        private bool isLoggingOut = false; 

        
        private UC_Dashboard _ucDashboard;
        private UC_Products _ucProducts;
        private UC_Stock _ucStock;
        private UC_Classifications _ucClassifications;
        private UC_SalesHistory _ucSalesHistory;
        private UC_Settings _ucSettings;

        public AdminDashboard(string username)
        {
            InitializeComponent();
            loggedInAdmin = username;

            
            Label lblLoggedIn = new Label();
            lblLoggedIn.Text = "Logged in as: " + char.ToUpper(loggedInAdmin[0]) + loggedInAdmin.Substring(1).ToLower();
            lblLoggedIn.Font = new Font("Segoe UI", 9f, FontStyle.Italic);
            lblLoggedIn.ForeColor = Color.WhiteSmoke;
            lblLoggedIn.AutoSize = false;
            lblLoggedIn.Dock = DockStyle.Bottom;
            lblLoggedIn.Height = 25;
            lblLoggedIn.TextAlign = ContentAlignment.MiddleCenter;
            panel2.Controls.Add(lblLoggedIn);

            
            UpdateHeader("OVERVIEW DASHBOARD");
            _ucDashboard = new UC_Dashboard(loggedInAdmin);
            LoadUserControl(_ucDashboard);
            HighlightButton(button1);
        }

        
        private void UpdateHeader(string title)
        {
            label2.Text = title;
        }

        
        private void LoadUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Clear();
            pnlMainContent.Controls.Add(uc);
            uc.BringToFront();
        }

        
        private void HighlightButton(Button activeBtn)
        {
            Color defaultBackColor = Color.Pink;
            Color defaultForeColor = Color.DimGray;

            
            Button[] navButtons = { button1, button2, button3, button4, button7, button8 };
            foreach (Button btn in navButtons)
            {
                btn.BackColor = defaultBackColor;
                btn.ForeColor = defaultForeColor;
            }

            
            activeBtn.BackColor = Color.HotPink;
            activeBtn.ForeColor = Color.White;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            UpdateHeader("OVERVIEW DASHBOARD");
            _ucDashboard = _ucDashboard ?? new UC_Dashboard(loggedInAdmin);
            LoadUserControl(_ucDashboard);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            UpdateHeader("PRODUCT INVENTORY");
            _ucProducts = _ucProducts ?? new UC_Products();
            LoadUserControl(_ucProducts);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            UpdateHeader("STOCK MANAGEMENT");
            _ucStock = _ucStock ?? new UC_Stock();
            LoadUserControl(_ucStock);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            UpdateHeader("BRANDS && CATEGORIES");
            _ucClassifications = _ucClassifications ?? new UC_Classifications();
            LoadUserControl(_ucClassifications);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            UpdateHeader("SALES HISTORY");
            _ucSalesHistory = _ucSalesHistory ?? new UC_SalesHistory();
            LoadUserControl(_ucSalesHistory);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            UpdateHeader("SYSTEM SETTINGS");
            _ucSettings = _ucSettings ?? new UC_Settings(loggedInAdmin);
            LoadUserControl(_ucSettings);
        }

        
        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                isLoggingOut = true;

                
                Form originalLoginForm = Application.OpenForms["Form1"];
                if (originalLoginForm != null)
                {
                    originalLoginForm.Show();

                    
                    TextBox txtPass = (TextBox)originalLoginForm.Controls.Find("textBox2", true)[0];
                    if (txtPass != null) txtPass.Clear();
                }

                this.Close(); 
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            
            
            if (!isLoggingOut)
            {
                Application.Exit();
            }
        }
    }
}