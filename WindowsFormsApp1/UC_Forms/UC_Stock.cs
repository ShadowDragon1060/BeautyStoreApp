using BeautyStoreApp.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BeautyStoreApp
{
    public partial class UC_Stock : UserControl
    {
        public UC_Stock()
        {
            InitializeComponent();

            dgvLowStock.ReadOnly = true;
            dgvLowStock.AllowUserToAddRows = false;
            dgvLowStock.AllowUserToDeleteRows = false;

            
            picProductPreview.BackColor = Color.FromArgb(255, 240, 245);

            StyleDataGridView();
            StyleButtons();
            LoadLowStockData();

            
            dgvLowStock.RowPrePaint += dgvLowStock_RowPrePaint;
        }

        
        
     
        private void StyleDataGridView()
        {
            dgvLowStock.BackgroundColor = Color.White;
            dgvLowStock.BorderStyle = BorderStyle.None;
            dgvLowStock.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLowStock.GridColor = Color.Gainsboro;
            dgvLowStock.RowHeadersVisible = false;
            dgvLowStock.EnableHeadersVisualStyles = false;
            dgvLowStock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvLowStock.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvLowStock.ColumnHeadersDefaultCellStyle.ForeColor = Color.DimGray;
            dgvLowStock.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvLowStock.ColumnHeadersHeight = 40;
            dgvLowStock.DefaultCellStyle.BackColor = Color.White;
            dgvLowStock.DefaultCellStyle.SelectionBackColor = Color.LavenderBlush;
            dgvLowStock.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvLowStock.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvLowStock.RowTemplate.Height = 35;
            dgvLowStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void StyleButtons()
        {
            
            btnRestock.FlatStyle = FlatStyle.Flat;
            btnRestock.BackColor = Color.HotPink;
            btnRestock.ForeColor = Color.White;
            btnRestock.FlatAppearance.BorderColor = Color.DeepPink;
            btnRestock.FlatAppearance.MouseOverBackColor = Color.DeepPink;

            
            Button[] quickBtns = { btnQuick10, btnQuick50, btnQuick100 };
            foreach (Button btn in quickBtns)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.LavenderBlush;
                btn.ForeColor = Color.DimGray;
                btn.FlatAppearance.BorderColor = Color.LightPink;
                btn.FlatAppearance.MouseOverBackColor = Color.MistyRose;
            }
        }

        private void dgvLowStock_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0) return;

            
            if (!dgvLowStock.Rows[e.RowIndex].Selected && dgvLowStock.Rows[e.RowIndex].Cells["Current Stock"].Value != null)
            {
                int stock = Convert.ToInt32(dgvLowStock.Rows[e.RowIndex].Cells["Current Stock"].Value);
                if (stock == 0) dgvLowStock.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 200, 200); 
                else if (stock <= 15) dgvLowStock.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 205); 
                else if (stock <= 30) dgvLowStock.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 205); 
                else dgvLowStock.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
            else if (dgvLowStock.Rows[e.RowIndex].Selected)
            {
                
                dgvLowStock.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LavenderBlush;
            }
        }

      
        
        
        private void LoadLowStockData(string searchTerm = "")
        {
            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            ROW_NUMBER() OVER(ORDER BY p.StockQuantity ASC) AS [S/N],
                            p.ProductID AS [ID], 
                            p.ProductName AS [Product Name], 
                            b.BrandName AS [Brand],
                            p.StockQuantity AS [Current Stock],
                            p.ImagePath AS [ImagePath]
                        FROM Products p
                        LEFT JOIN Brands b ON p.BrandID = b.BrandID
                        WHERE p.StockQuantity < 50 AND p.ProductName LIKE @search";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvLowStock.DataSource = dt;

                    
                    if (dgvLowStock.Columns["ImagePath"] != null) dgvLowStock.Columns["ImagePath"].Visible = false;
                    if (dgvLowStock.Columns["ID"] != null) dgvLowStock.Columns["ID"].Visible = false;

                    dgvLowStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dgvLowStock.Columns["S/N"] != null) dgvLowStock.Columns["S/N"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    dgvLowStock.CurrentCell = null;
                    ClearDetails();


                    int totalLowStock = dt.Rows.Count;
                    int criticalStock = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        if (Convert.ToInt32(row["Current Stock"]) == 0) criticalStock++;
                    }

                    lblTotalLowStock.Text = totalLowStock.ToString();
                    lblCriticalStock.Text = criticalStock.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) { LoadLowStockData(txtSearch.Text.Trim()); }

        
        
        
        private void dgvLowStock_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLowStock.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvLowStock.SelectedRows[0];
                lblSelectedItem.Text = row.Cells["Product Name"].Value.ToString();
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
            lblSelectedItem.Text = "---";
            numRestock.Value = 0;
            if (picProductPreview.Image != null)
            {
                picProductPreview.Image.Dispose();
                picProductPreview.Image = null;
            }
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            if (dgvLowStock.SelectedRows.Count == 0) { MessageBox.Show("Please select an item to restock.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            int amountToAdd = (int)numRestock.Value;
            if (amountToAdd <= 0) { MessageBox.Show("Please enter a positive amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            int selectedId = Convert.ToInt32(dgvLowStock.SelectedRows[0].Cells["ID"].Value);

            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Products SET StockQuantity = StockQuantity + @add WHERE ProductID = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@add", amountToAdd);
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"Successfully added {amountToAdd} units to stock.", "Restock Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLowStockData(txtSearch.Text.Trim()); 
                }
                catch (Exception ex) { MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        
        private void btnQuick10_Click(object sender, EventArgs e) { numRestock.Value = 10; btnRestock.PerformClick(); }
        private void btnQuick50_Click(object sender, EventArgs e) { numRestock.Value = 50; btnRestock.PerformClick(); }
        private void btnQuick100_Click(object sender, EventArgs e) { numRestock.Value = 100; btnRestock.PerformClick(); }
    }
}