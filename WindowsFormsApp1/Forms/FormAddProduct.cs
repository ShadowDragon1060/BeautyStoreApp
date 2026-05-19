using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BeautyStoreApp.Data;

namespace BeautyStoreApp
{
    public partial class FormAddProduct : Form
    {
        private string selectedImagePath = "";
        private bool isEditMode = false;
        private int editingProductId = 0;

        public FormAddProduct()
        {
            InitializeComponent();
            LoadCategories();
            LoadBrands();

            
            picUpload.BackColor = Color.FromArgb(255, 240, 245);
        }

        public FormAddProduct(int productId)
        {
            InitializeComponent();
            LoadCategories();
            LoadBrands();

            picUpload.BackColor = Color.FromArgb(255, 240, 245);

            isEditMode = true;
            editingProductId = productId;
            btnSave.Text = "Update";
            lblTitle.Text = "Edit Product Info"; 
            this.Text = "Petal Prism — Edit Product";

            LoadExistingProductData();
        }

        private void LoadCategories()
        {
            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT CategoryID, CategoryName FROM Categories", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryID";
            }
        }

        private void LoadBrands()
        {
            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT BrandID, BrandName FROM Brands", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbBrand.DataSource = dt;
                cmbBrand.DisplayMember = "BrandName";
                cmbBrand.ValueMember = "BrandID";
            }
        }

        private void LoadExistingProductData()
        {
            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Products WHERE ProductID = @id", conn);
                cmd.Parameters.AddWithValue("@id", editingProductId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtName.Text = reader["ProductName"].ToString();
                        txtPrice.Text = reader["Price"].ToString();
                        txtStock.Text = reader["StockQuantity"].ToString();
                        txtShade.Text = reader["Shade"].ToString();

                        cmbCategory.SelectedValue = reader["CategoryID"];

                        if (reader["BrandID"] != DBNull.Value)
                            cmbBrand.SelectedValue = reader["BrandID"];

                        string imagePath = reader["ImagePath"].ToString();
                        if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                        {
                            using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                            {
                                picUpload.Image = Image.FromStream(fs);
                            }
                        }
                    }
                }
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    using (FileStream fs = new FileStream(selectedImagePath, FileMode.Open, FileAccess.Read))
                    {
                        picUpload.Image = Image.FromStream(fs);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Name, Price, and Stock are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            
            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Please enter a valid stock quantity (0 or higher).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                return;
            }

            
            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        int currentProductId = editingProductId;
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.Transaction = trans;

                        if (isEditMode)
                        {
                            cmd.CommandText = @"UPDATE Products SET ProductName=@name, BrandID=@brandId, Price=@price, 
                                                StockQuantity=@stock, Shade=@shade, CategoryID=@catId 
                                                WHERE ProductID=@id";
                            cmd.Parameters.AddWithValue("@id", currentProductId);
                        }
                        else
                        {
                            
                            cmd.CommandText = @"INSERT INTO Products 
                                               (ProductName, BrandID, Price, StockQuantity, Shade, CategoryID) 
                                               OUTPUT INSERTED.ProductID
                                               VALUES 
                                               (@name, @brandId, @price, @stock, @shade, @catId)";
                        }

                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@brandId", cmbBrand.SelectedValue ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@stock", stock);
                        cmd.Parameters.AddWithValue("@shade", string.IsNullOrWhiteSpace(txtShade.Text) ? (object)DBNull.Value : txtShade.Text.Trim());
                        cmd.Parameters.AddWithValue("@catId", cmbCategory.SelectedValue);

                        if (isEditMode)
                        {
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            currentProductId = (int)cmd.ExecuteScalar();
                        }

                        
                        if (!string.IsNullOrEmpty(selectedImagePath))
                        {
                            string appDirectory = Path.Combine(Application.StartupPath, "Images");
                            if (!Directory.Exists(appDirectory)) Directory.CreateDirectory(appDirectory);

                            string fileExtension = Path.GetExtension(selectedImagePath);
                            string newFileName = Guid.NewGuid().ToString() + fileExtension;
                            string savedImagePath = Path.Combine(appDirectory, newFileName);

                            File.Copy(selectedImagePath, savedImagePath, true);

                            
                            SqlCommand imgCmd = new SqlCommand("UPDATE Products SET ImagePath=@img WHERE ProductID=@id", conn, trans);
                            imgCmd.Parameters.AddWithValue("@img", savedImagePath);
                            imgCmd.Parameters.AddWithValue("@id", currentProductId);
                            imgCmd.ExecuteNonQuery();
                        }

                        trans.Commit();
                        MessageBox.Show(isEditMode ? "Product Updated Successfully!" : "Product Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Error saving to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}