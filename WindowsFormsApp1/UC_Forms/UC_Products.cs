using BeautyStoreApp.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace BeautyStoreApp
{
    public partial class UC_Products : UserControl
    {
        public UC_Products()
        {
            InitializeComponent();

            
            dgvProducts.ReadOnly = true;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;

            
            picProductPreview.BackColor = Color.FromArgb(255, 240, 245);

            StyleDataGridView();
            StyleButtons();
            LoadProductsData();
        }

        
        
      
        private void StyleDataGridView()
        {
            
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProducts.GridColor = Color.Gainsboro;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.DimGray;
            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvProducts.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvProducts.ColumnHeadersHeight = 40;
            dgvProducts.DefaultCellStyle.BackColor = Color.White;
            dgvProducts.DefaultCellStyle.SelectionBackColor = Color.LavenderBlush;
            dgvProducts.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvProducts.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvProducts.RowTemplate.Height = 35;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void StyleButtons()
        {
            
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.BackColor = Color.HotPink;
            btnAdd.ForeColor = Color.White;
            btnAdd.FlatAppearance.BorderColor = Color.DeepPink;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.DeepPink;

            
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.BackColor = Color.LightPink;
            btnEdit.ForeColor = Color.DimGray;
            btnEdit.FlatAppearance.BorderColor = Color.LightPink;
            btnEdit.FlatAppearance.MouseOverBackColor = Color.MistyRose;

            
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.BackColor = Color.PaleVioletRed;
            btnRemove.ForeColor = Color.White;
            btnRemove.FlatAppearance.BorderColor = Color.Crimson;
            btnRemove.FlatAppearance.MouseOverBackColor = Color.Crimson;
        }

        
        
        
        private void LoadProductsData(string searchTerm = "")
        {
            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            ROW_NUMBER() OVER(ORDER BY p.ProductID DESC) AS [S/N],
                            p.ProductID AS [ID], 
                            p.ProductName AS [Product Name], 
                            b.BrandName AS [Brand],
                            c.CategoryName AS [Category], 
                            p.Price AS [Price ($)], 
                            p.StockQuantity AS [Stock Level],
                            p.ImagePath AS [ImagePath]
                        FROM Products p
                        INNER JOIN Categories c ON p.CategoryID = c.CategoryID
                        LEFT JOIN Brands b ON p.BrandID = b.BrandID
                        WHERE p.ProductName LIKE @search OR c.CategoryName LIKE @search";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvProducts.DataSource = dt;

                    
                    if (dgvProducts.Columns["ImagePath"] != null) dgvProducts.Columns["ImagePath"].Visible = false;
                    if (dgvProducts.Columns["ID"] != null) dgvProducts.Columns["ID"].Visible = false;

                    dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dgvProducts.Columns["S/N"] != null) dgvProducts.Columns["S/N"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    if (dgvProducts.Columns["Price ($)"] != null) dgvProducts.Columns["Price ($)"].DefaultCellStyle.Format = "N2";

                    dgvProducts.CurrentCell = null;
                    ClearDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) { LoadProductsData(txtSearch.Text.Trim()); }

        
        
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddProduct addForm = new FormAddProduct();
            if (addForm.ShowDialog(this) == DialogResult.OK) LoadProductsData(txtSearch.Text.Trim());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ID"].Value);
                FormAddProduct editForm = new FormAddProduct(selectedId);
                if (editForm.ShowDialog(this) == DialogResult.OK) LoadProductsData(txtSearch.Text.Trim());
            }
            else { MessageBox.Show("Please select a product to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ID"].Value);
                string productName = dgvProducts.SelectedRows[0].Cells["Product Name"].Value.ToString();

                if (MessageBox.Show($"Are you sure you want to permanently delete '{productName}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new DatabaseConnection().GetConnection())
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE ProductID = @id", conn);
                            cmd.Parameters.AddWithValue("@id", selectedId);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadProductsData(txtSearch.Text.Trim());
                        }
                        catch (SqlException ex) when (ex.Number == 547)
                        {
                            MessageBox.Show("Cannot delete this product because it is linked to existing order records.", "Data Constraint", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else { MessageBox.Show("Please select a product to remove.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

       
        
       
        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProducts.SelectedRows[0];
                lblDetName.Text = row.Cells["Product Name"].Value.ToString();
                lblDetBrand.Text = row.Cells["Brand"].Value?.ToString() ?? "N/A";
                lblDetPrice.Text = "$" + Convert.ToDecimal(row.Cells["Price ($)"].Value).ToString("N2");
                lblDetStock.Text = row.Cells["Stock Level"].Value.ToString() + " units";

                string imagePath = row.Cells["ImagePath"].Value.ToString();

                
                if (picProductPreview.Image != null)
                {
                    picProductPreview.Image.Dispose();
                    picProductPreview.Image = null;
                }

                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    
                    using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        using (Image tempImg = Image.FromStream(fs))
                        {
                            picProductPreview.Image = new Bitmap(tempImg);
                        }
                    }
                }
            }
        }

        private void ClearDetails()
        {
            lblDetName.Text = "---";
            lblDetBrand.Text = "---";
            lblDetPrice.Text = "---";
            lblDetStock.Text = "---";
            if (picProductPreview.Image != null)
            {
                picProductPreview.Image.Dispose();
                picProductPreview.Image = null;
            }
        }
    }
}