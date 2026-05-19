using System;
using System.Drawing;
using System.Windows.Forms;

namespace BeautyStoreApp
{
    public partial class StaffDashboard : Form
    {
        private string currentStaffName;
        private bool isLoggingOut = false; 

        
        private UC_OrderProcessing _ucOrderProcessing;
        private UC_MySales _ucMySales;

        public StaffDashboard(string staffName)
        {
            InitializeComponent();
            currentStaffName = staffName;

            
            Label lblLoggedIn = new Label();
            lblLoggedIn.Text = "Logged in as: " + char.ToUpper(currentStaffName[0]) + currentStaffName.Substring(1).ToLower();
            lblLoggedIn.Font = new Font("Segoe UI", 9f, FontStyle.Italic);
            lblLoggedIn.ForeColor = Color.WhiteSmoke;
            lblLoggedIn.AutoSize = false;
            lblLoggedIn.Dock = DockStyle.Bottom;
            lblLoggedIn.Height = 25;
            lblLoggedIn.TextAlign = ContentAlignment.MiddleCenter;
            panel2.Controls.Add(lblLoggedIn);

            
            UpdateHeader("NEW ORDER PROCESSING");
            _ucOrderProcessing = new UC_OrderProcessing(currentStaffName);
            LoadUserControl(_ucOrderProcessing);
            HighlightButton(btnOrderProcessing);
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

            
            btnOrderProcessing.BackColor = defaultBackColor;
            btnOrderProcessing.ForeColor = defaultForeColor;
            btnSales.BackColor = defaultBackColor;
            btnSales.ForeColor = defaultForeColor;

            
            activeBtn.BackColor = Color.HotPink;
            activeBtn.ForeColor = Color.White;
        }

        
        private void btnOrderProcessing_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            UpdateHeader("NEW ORDER PROCESSING");

            
            _ucOrderProcessing = _ucOrderProcessing ?? new UC_OrderProcessing(currentStaffName);
            LoadUserControl(_ucOrderProcessing);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
            UpdateHeader("MY SALES HISTORY");

            
            _ucMySales = _ucMySales ?? new UC_MySales(currentStaffName);
            LoadUserControl(_ucMySales);
        }

        
        private void btnLogout_Click(object sender, EventArgs e)
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