using BeautyStoreApp.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BeautyStoreApp
{
    public partial class UC_Classifications : UserControl
    {
        public UC_Classifications()
        {
            InitializeComponent();

            
            btnAddCategory.Click += btnAddCategory_Click;
            btnEditCategory.Click += btnEditCategory_Click;
            btnRemoveCategory.Click += btnRemoveCategory_Click;
            dgvCategories.SelectionChanged += dgvCategories_SelectionChanged;

            btnAddBrand.Click += btnAddBrand_Click;
            btnEditBrand.Click += btnEditBrand_Click;
            btnRemoveBrand.Click += btnRemoveBrand_Click;
            dgvBrands.SelectionChanged += dgvBrands_SelectionChanged;

            StyleDataGridView(dgvCategories);
            StyleDataGridView(dgvBrands);
            StyleButtons();

            LoadCategories();
            LoadBrands();
        }

        
        
        
        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.Gainsboro;
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.DimGray;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 40;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LavenderBlush;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.RowTemplate.Height = 35;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
        }

        private void StyleButtons()
        {
            Button[] addBtns = { btnAddCategory, btnAddBrand };
            Button[] editBtns = { btnEditCategory, btnEditBrand };
            Button[] removeBtns = { btnRemoveCategory, btnRemoveBrand };

            foreach (Button btn in addBtns)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.HotPink;
                btn.ForeColor = Color.White;
                btn.FlatAppearance.BorderColor = Color.DeepPink;
                btn.FlatAppearance.MouseOverBackColor = Color.DeepPink;
            }

            foreach (Button btn in editBtns)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.LightPink;
                btn.ForeColor = Color.DimGray;
                btn.FlatAppearance.BorderColor = Color.LightPink;
                btn.FlatAppearance.MouseOverBackColor = Color.MistyRose;
            }

            foreach (Button btn in removeBtns)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.PaleVioletRed;
                btn.ForeColor = Color.White;
                btn.FlatAppearance.BorderColor = Color.Crimson;
                btn.FlatAppearance.MouseOverBackColor = Color.Crimson;
            }
        }

       
        
        
        private void LoadCategories()
        {
            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT ROW_NUMBER() OVER(ORDER BY CategoryName) AS [S/N], CategoryID AS [ID], CategoryName AS [Category] FROM Categories", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCategories.DataSource = dt;

                if (dgvCategories.Columns["ID"] != null) dgvCategories.Columns["ID"].Visible = false;
                dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (dgvCategories.Columns["S/N"] != null) dgvCategories.Columns["S/N"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvCategories.CurrentCell = null;
                txtCategory.Clear();
            }
        }

        private void dgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
                txtCategory.Text = dgvCategories.SelectedRows[0].Cells["Category"].Value.ToString();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategory.Text)) { MessageBox.Show("Please enter a category name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Categories (CategoryName) VALUES (@name)", conn);
                    cmd.Parameters.AddWithValue("@name", txtCategory.Text.Trim());
                    cmd.ExecuteNonQuery();
                    LoadCategories();
                }
                catch (Exception ex) { MessageBox.Show("Error adding category.\n" + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0) { MessageBox.Show("Please select a category to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (string.IsNullOrWhiteSpace(txtCategory.Text)) { MessageBox.Show("Category name cannot be empty.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            int id = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells["ID"].Value);

            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Categories SET CategoryName = @name WHERE CategoryID = @id", conn);
                    cmd.Parameters.AddWithValue("@name", txtCategory.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    LoadCategories();
                }
                catch (Exception ex) { MessageBox.Show("Error updating category.\n" + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells["ID"].Value);
            string name = dgvCategories.SelectedRows[0].Cells["Category"].Value.ToString();

            if (MessageBox.Show($"Are you sure you want to permanently delete the '{name}' category?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Categories WHERE CategoryID = @id", conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        LoadCategories();
                    }
                    catch (SqlException ex) when (ex.Number == 547) { MessageBox.Show($"Cannot delete '{name}' because there are products actively assigned to it.", "Dependency Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        
        
        
        private void LoadBrands()
        {
            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT ROW_NUMBER() OVER(ORDER BY BrandName) AS [S/N], BrandID AS [ID], BrandName AS [Brand] FROM Brands", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBrands.DataSource = dt;

                if (dgvBrands.Columns["ID"] != null) dgvBrands.Columns["ID"].Visible = false;
                dgvBrands.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (dgvBrands.Columns["S/N"] != null) dgvBrands.Columns["S/N"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvBrands.CurrentCell = null;
                txtBrand.Clear();
            }
        }

        private void dgvBrands_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBrands.SelectedRows.Count > 0)
                txtBrand.Text = dgvBrands.SelectedRows[0].Cells["Brand"].Value.ToString();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrand.Text)) { MessageBox.Show("Please enter a brand name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Brands (BrandName) VALUES (@name)", conn);
                    cmd.Parameters.AddWithValue("@name", txtBrand.Text.Trim());
                    cmd.ExecuteNonQuery();
                    LoadBrands();
                }
                catch (Exception ex) { MessageBox.Show("Error adding brand.\n" + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btnEditBrand_Click(object sender, EventArgs e)
        {
            if (dgvBrands.SelectedRows.Count == 0) { MessageBox.Show("Please select a brand to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (string.IsNullOrWhiteSpace(txtBrand.Text)) { MessageBox.Show("Brand name cannot be empty.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            int id = Convert.ToInt32(dgvBrands.SelectedRows[0].Cells["ID"].Value);

            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Brands SET BrandName = @name WHERE BrandID = @id", conn);
                    cmd.Parameters.AddWithValue("@name", txtBrand.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    LoadBrands();
                }
                catch (Exception ex) { MessageBox.Show("Error updating brand.\n" + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btnRemoveBrand_Click(object sender, EventArgs e)
        {
            if (dgvBrands.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dgvBrands.SelectedRows[0].Cells["ID"].Value);
            string name = dgvBrands.SelectedRows[0].Cells["Brand"].Value.ToString();

            if (MessageBox.Show($"Are you sure you want to permanently delete the brand '{name}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Brands WHERE BrandID = @id", conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        LoadBrands();
                    }
                    catch (SqlException ex) when (ex.Number == 547) { MessageBox.Show($"Cannot delete '{name}' because there are products actively assigned to it.", "Dependency Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }
    }
}