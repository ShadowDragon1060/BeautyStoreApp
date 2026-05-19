using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using BeautyStoreApp.Data;
using BeautyStoreApp.Utilities;

namespace BeautyStoreApp
{
    public partial class UC_Settings : UserControl
    {
        private string currentUser;
        private bool isSuperAdmin;

        public UC_Settings(string loggedInUsername)
        {
            InitializeComponent();
            currentUser = loggedInUsername.ToLower();
            isSuperAdmin = (currentUser == "kabbo");

            
            btnAddAccount.Click += btnAdd_Click;
            btnEditAccount.Click += btnEdit_Click;
            btnRemoveAccount.Click += btnRemove_Click;
            btnChangePassword.Click += btnChangePassword_Click;
            btnExportInventory.Click += btnExportInventory_Click;
            btnExportSales.Click += btnExportSales_Click;
            dgvUsers.SelectionChanged += dgvUsers_SelectionChanged;

            
            txtOldPassword.UseSystemPasswordChar = true;
            txtNewPassword.UseSystemPasswordChar = true;

            StyleDataGridView();
            StyleControls();
            SetupRoleDropdown();
            LoadUsers();
        }

        
        
     
        private void StyleDataGridView()
        {
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.GridColor = Color.Gainsboro;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.DimGray;
            dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvUsers.ColumnHeadersHeight = 40;
            dgvUsers.DefaultCellStyle.BackColor = Color.White;
            dgvUsers.DefaultCellStyle.SelectionBackColor = Color.LavenderBlush;
            dgvUsers.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvUsers.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvUsers.RowTemplate.Height = 35;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.ReadOnly = true;
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
        }

        private void StyleControls()
        {
            
            Button[] primaryBtns = { btnAddAccount, btnChangePassword, btnExportInventory, btnExportSales };
            foreach (Button btn in primaryBtns)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.HotPink;
                btn.ForeColor = Color.White;
                btn.FlatAppearance.BorderColor = Color.DeepPink;
                btn.FlatAppearance.MouseOverBackColor = Color.DeepPink;
            }

            
            btnEditAccount.FlatStyle = FlatStyle.Flat;
            btnEditAccount.BackColor = Color.LightPink;
            btnEditAccount.ForeColor = Color.DimGray;
            btnEditAccount.FlatAppearance.BorderColor = Color.LightPink;
            btnEditAccount.FlatAppearance.MouseOverBackColor = Color.MistyRose;

            btnRemoveAccount.FlatStyle = FlatStyle.Flat;
            btnRemoveAccount.BackColor = Color.PaleVioletRed;
            btnRemoveAccount.ForeColor = Color.White;
            btnRemoveAccount.FlatAppearance.BorderColor = Color.Crimson;
            btnRemoveAccount.FlatAppearance.MouseOverBackColor = Color.Crimson;
        }

        private void SetupRoleDropdown()
        {
            cmbRole.Items.Clear();
            cmbRole.Items.Add("SalesStaff");
            if (isSuperAdmin) cmbRole.Items.Add("Admin");
            cmbRole.SelectedIndex = 0;
        }

     
        
      
        private void LoadUsers()
        {
            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                string query = isSuperAdmin
                    ? @"SELECT ROW_NUMBER() OVER(ORDER BY Role, Username) AS [S/N], UserID AS [ID], Username, Role 
                        FROM Users WHERE LOWER(Username) != @self"
                    : @"SELECT ROW_NUMBER() OVER(ORDER BY Username) AS [S/N], UserID AS [ID], Username, Role 
                        FROM Users WHERE Role = 'SalesStaff' AND LOWER(Username) != @self";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@self", currentUser);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvUsers.DataSource = dt;
                if (dgvUsers.Columns["ID"] != null) dgvUsers.Columns["ID"].Visible = false;

                dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (dgvUsers.Columns["S/N"] != null) dgvUsers.Columns["S/N"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvUsers.CurrentCell = null;
                txtAccountName.Clear();
                txtPassword.Clear();
            }
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                txtAccountName.Text = dgvUsers.SelectedRows[0].Cells["Username"].Value.ToString();
                string role = dgvUsers.SelectedRows[0].Cells["Role"].Value.ToString();
                if (cmbRole.Items.Contains(role)) cmbRole.SelectedItem = role;
                else cmbRole.SelectedIndex = 0;

                txtPassword.Clear();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string user = txtAccountName.Text.Trim();
            string pass = txtPassword.Text;
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Username, Password, and Role are all required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if (role == "Admin" && !isSuperAdmin)
            {
                MessageBox.Show("You do not have permission to create Admin accounts.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            string hash = HashHelper.HashPassword(pass);

            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE LOWER(Username) = LOWER(@u)", conn);
                    checkCmd.Parameters.AddWithValue("@u", user);
                    if ((int)checkCmd.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("That username already exists. Please choose a different one.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                    }

                    SqlCommand cmd = new SqlCommand("INSERT INTO Users (Username, Password, Role) VALUES (@u, @p, @r)", conn);
                    cmd.Parameters.AddWithValue("@u", user);
                    cmd.Parameters.AddWithValue("@p", hash);
                    cmd.Parameters.AddWithValue("@r", role);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"User '{user}' created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAccountName.Clear();
                    txtPassword.Clear();
                    cmbRole.SelectedIndex = 0;
                    LoadUsers();
                }
                catch (Exception ex) { MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0) { MessageBox.Show("Please select a user from the list to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            int targetId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["ID"].Value);
            string targetUser = dgvUsers.SelectedRows[0].Cells["Username"].Value.ToString();
            string targetRole = dgvUsers.SelectedRows[0].Cells["Role"].Value.ToString();
            string newUsername = txtAccountName.Text.Trim();
            string newRole = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newRole)) { MessageBox.Show("Username and Role cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (targetRole == "Admin" && !isSuperAdmin) { MessageBox.Show("You cannot modify Admin accounts.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (newRole == "Admin" && !isSuperAdmin) { MessageBox.Show("You do not have permission to grant Admin privileges.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (targetUser.ToLower() == "kabbo" && newRole != "Admin") { MessageBox.Show("The master admin role cannot be changed.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE LOWER(Username) = LOWER(@u) AND UserID != @id", conn);
                    checkCmd.Parameters.AddWithValue("@u", newUsername);
                    checkCmd.Parameters.AddWithValue("@id", targetId);
                    if ((int)checkCmd.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("That username is already taken by another account.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                    }

                    SqlCommand cmd;
                    if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                    {
                        string hash = HashHelper.HashPassword(txtPassword.Text);
                        cmd = new SqlCommand("UPDATE Users SET Username=@u, Role=@r, Password=@p WHERE UserID=@id", conn);
                        cmd.Parameters.AddWithValue("@p", hash);
                    }
                    else
                    {
                        cmd = new SqlCommand("UPDATE Users SET Username=@u, Role=@r WHERE UserID=@id", conn);
                    }

                    cmd.Parameters.AddWithValue("@u", newUsername);
                    cmd.Parameters.AddWithValue("@r", newRole);
                    cmd.Parameters.AddWithValue("@id", targetId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"User '{newUsername}' updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Clear();
                    LoadUsers();
                }
                catch (Exception ex) { MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0) { MessageBox.Show("Please select a user from the list to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            int targetId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["ID"].Value);
            string targetUser = dgvUsers.SelectedRows[0].Cells["Username"].Value.ToString();
            string targetRole = dgvUsers.SelectedRows[0].Cells["Role"].Value.ToString();

            if (targetUser.ToLower() == "kabbo") { MessageBox.Show("The master admin account cannot be deleted.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (targetRole == "Admin" && !isSuperAdmin) { MessageBox.Show("You cannot delete Admin accounts.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (MessageBox.Show($"Are you sure you want to permanently delete '{targetUser}'?\nThis cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE UserID=@id", conn);
                        cmd.Parameters.AddWithValue("@id", targetId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"User '{targetUser}' has been removed.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAccountName.Clear();
                        txtPassword.Clear();
                        cmbRole.SelectedIndex = 0;
                        LoadUsers();
                    }
                    catch (SqlException ex) when (ex.Number == 547)
                    {
                        MessageBox.Show($"Cannot delete '{targetUser}' because they have sales records attached.", "Data Integrity Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex) { MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

      
        
        
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string oldPass = txtOldPassword.Text;
            string newPass = txtNewPassword.Text;

            if (string.IsNullOrWhiteSpace(oldPass) || string.IsNullOrWhiteSpace(newPass)) { MessageBox.Show("Please fill in both the current and new password fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (newPass.Length < 6) { MessageBox.Show("New password must be at least 6 characters long.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string hashedOld = HashHelper.HashPassword(oldPass);
            string hashedNew = HashHelper.HashPassword(newPass);

            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand verifyCmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE LOWER(Username) = @u AND Password = @p", conn);
                    verifyCmd.Parameters.AddWithValue("@u", currentUser);
                    verifyCmd.Parameters.AddWithValue("@p", hashedOld);

                    if ((int)verifyCmd.ExecuteScalar() == 0)
                    {
                        MessageBox.Show("The current password you entered is incorrect.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                    }

                    SqlCommand updateCmd = new SqlCommand("UPDATE Users SET Password = @newPass WHERE LOWER(Username) = @u", conn);
                    updateCmd.Parameters.AddWithValue("@newPass", hashedNew);
                    updateCmd.Parameters.AddWithValue("@u", currentUser);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Your password has been changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOldPassword.Clear();
                    txtNewPassword.Clear();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btnExportInventory_Click(object sender, EventArgs e)
        {
            ExportToCsv(@"SELECT p.ProductID, p.ProductName, b.BrandName, c.CategoryName, p.Price, p.StockQuantity FROM Products p LEFT JOIN Categories c ON p.CategoryID = c.CategoryID LEFT JOIN Brands b ON p.BrandID = b.BrandID", "Inventory_Export");
        }

        private void btnExportSales_Click(object sender, EventArgs e)
        {
            ExportToCsv(@"SELECT o.OrderID, u.Username AS Cashier, o.OrderDate, o.TotalAmount FROM Orders o LEFT JOIN Users u ON o.UserID = u.UserID ORDER BY o.OrderDate DESC", "Sales_History_Export");
        }

        private void ExportToCsv(string query, string defaultFileName)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV Files|*.csv", FileName = defaultFileName + "_" + DateTime.Now.ToString("yyyyMMdd") })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;

                using (SqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    try
                    {
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        StringBuilder sb = new StringBuilder();
                        string[] columnNames = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++) columnNames[i] = dt.Columns[i].ColumnName;
                        sb.AppendLine(string.Join(",", columnNames));

                        foreach (DataRow row in dt.Rows)
                        {
                            string[] fields = new string[dt.Columns.Count];
                            for (int i = 0; i < dt.Columns.Count; i++)
                            {
                                string field = row[i].ToString().Replace("\"", "\"\"");
                                fields[i] = $"\"{field}\"";
                            }
                            sb.AppendLine(string.Join(",", fields));
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                        MessageBox.Show("Data exported successfully to:\n" + sfd.FileName, "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex) { MessageBox.Show("Export failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }
    }
}