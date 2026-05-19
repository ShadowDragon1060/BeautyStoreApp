using BeautyStoreApp.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace BeautyStoreApp
{
    

    public partial class UC_OrderProcessing : UserControl
    {
        private string cashierName;
        private DataTable cartTable;

        private int currentSelectedId = 0;
        private string currentSelectedName = "";
        private decimal currentSelectedPrice = 0;
        private int currentAvailableStock = 0;

        public UC_OrderProcessing(string staffName)
        {
            InitializeComponent();
            cashierName = staffName;

            
            txtSearch.TextChanged += txtSearch_TextChanged;
            lstSearchResults.Click += lstSearchResults_Click;
            btnAddProduct.Click += btnAddProduct_Click;
            btnNewOrder.Click += btnNewOrder_Click;
            btnPrint.Click += btnPrint_Click;
            dgvCart.CellContentClick += dgvCart_CellContentClick;

            
            this.Controls.Add(lstSearchResults);
            lstSearchResults.BringToFront();

            StyleCartGrid();
            StyleButtons();
            InitializeCart();
            GenerateNextOrderNumber();
        }

       
        
       
        private void StyleCartGrid()
        {
            dgvCart.BackgroundColor = Color.White;
            dgvCart.BorderStyle = BorderStyle.None;
            dgvCart.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCart.GridColor = Color.Gainsboro;
            dgvCart.RowHeadersVisible = false;
            dgvCart.EnableHeadersVisualStyles = false;
            dgvCart.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvCart.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvCart.ColumnHeadersDefaultCellStyle.ForeColor = Color.DimGray;
            dgvCart.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvCart.ColumnHeadersHeight = 40;
            dgvCart.DefaultCellStyle.BackColor = Color.White;
            dgvCart.DefaultCellStyle.SelectionBackColor = Color.LavenderBlush;
            dgvCart.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvCart.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvCart.RowTemplate.Height = 35;

            dgvCart.AllowUserToAddRows = false;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvCart.CellValueChanged += DgvCart_CellValueChanged;
            dgvCart.DataError += DgvCart_DataError;
        }

        private void StyleButtons()
        {
            
            Button[] primaryBtns = { btnAddProduct, btnNewOrder };
            foreach (Button btn in primaryBtns)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.HotPink;
                btn.ForeColor = Color.White;
                btn.FlatAppearance.BorderColor = Color.DeepPink;
                btn.FlatAppearance.MouseOverBackColor = Color.DeepPink;
            }

            
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.BackColor = Color.LightPink;
            btnPrint.ForeColor = Color.DimGray;
            btnPrint.FlatAppearance.BorderColor = Color.LightPink;
            btnPrint.FlatAppearance.MouseOverBackColor = Color.MistyRose;
        }

        private void InitializeCart()
        {
            cartTable = new DataTable();
            cartTable.Columns.Add("ProductID", typeof(int));
            cartTable.Columns.Add("Product", typeof(string));
            cartTable.Columns.Add("Unit Price", typeof(decimal));
            cartTable.Columns.Add("Qty", typeof(int));
            cartTable.Columns.Add("Subtotal", typeof(decimal));
            cartTable.Columns.Add("MaxStock", typeof(int));

            dgvCart.DataSource = cartTable;
            dgvCart.Columns["ProductID"].Visible = false;
            dgvCart.Columns["MaxStock"].Visible = false;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvCart.Columns["Unit Price"] != null) dgvCart.Columns["Unit Price"].DefaultCellStyle.Format = "N2";
            if (dgvCart.Columns["Subtotal"] != null) dgvCart.Columns["Subtotal"].DefaultCellStyle.Format = "N2";

            foreach (DataGridViewColumn col in dgvCart.Columns)
            {
                col.ReadOnly = (col.Name != "Qty");
            }

            DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn();
            btnRemove.HeaderText = "Action";
            btnRemove.Name = "btnRemove";
            btnRemove.Text = "✖";
            btnRemove.UseColumnTextForButtonValue = true;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.DefaultCellStyle.BackColor = Color.Crimson;
            btnRemove.DefaultCellStyle.ForeColor = Color.White;
            btnRemove.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvCart.Columns.Add(btnRemove);
        }

        
        
        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(search))
            {
                lstSearchResults.Visible = false;
                return;
            }

            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                try
                {
                    string query = "SELECT ProductID, ProductName, Price, StockQuantity FROM Products WHERE StockQuantity > 0 AND ProductName LIKE @s";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@s", "%" + search + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        List<ProductSearchResult> list = new List<ProductSearchResult>();
                        foreach (DataRow row in dt.Rows)
                        {
                            string itemData = $"{row["ProductID"]}|{row["ProductName"]}|{row["Price"]}|{row["StockQuantity"]}";
                            list.Add(new ProductSearchResult
                            {
                                DisplayText = $"{row["ProductName"]} (${Convert.ToDecimal(row["Price"]):N2}) - Stock: {row["StockQuantity"]}",
                                HiddenData = itemData
                            });
                        }

                        lstSearchResults.DataSource = list;
                        lstSearchResults.DisplayMember = "DisplayText";
                        lstSearchResults.ValueMember = "HiddenData";

                        
                        lstSearchResults.Location = new Point(flowLayoutPanelSearch.Left, flowLayoutPanelSearch.Bottom + 5);
                        lstSearchResults.Width = flowLayoutPanelSearch.Width;
                        lstSearchResults.Height = 150;

                        lstSearchResults.Visible = true;
                        lstSearchResults.BringToFront();
                    }
                    else
                    {
                        lstSearchResults.Visible = false;
                    }
                }
                catch (Exception ex) { MessageBox.Show("Search Error: " + ex.Message); }
            }
        }

        private void lstSearchResults_Click(object sender, EventArgs e)
        {
            if (lstSearchResults.SelectedItem == null) return;

            ProductSearchResult selectedItem = (ProductSearchResult)lstSearchResults.SelectedItem;
            string[] data = selectedItem.HiddenData.Split('|');

            currentSelectedId = Convert.ToInt32(data[0]);
            currentSelectedName = data[1];
            currentSelectedPrice = Convert.ToDecimal(data[2]);
            currentAvailableStock = Convert.ToInt32(data[3]);

            lblSelectedItem.Text = currentSelectedName;

            txtSearch.Clear();
            lstSearchResults.Visible = false;
            btnAddProduct.Focus();
        }

        
        
        
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (currentSelectedId == 0)
            {
                MessageBox.Show("Please search and select a product first.", "Select Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool found = false;
            foreach (DataRow row in cartTable.Rows)
            {
                if (Convert.ToInt32(row["ProductID"]) == currentSelectedId)
                {
                    int currentQty = Convert.ToInt32(row["Qty"]);
                    if (currentQty + 1 > currentAvailableStock)
                    {
                        MessageBox.Show($"Cannot add more. Only {currentAvailableStock} left in stock!", "Stock Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    row["Qty"] = currentQty + 1;
                    row["Subtotal"] = (currentQty + 1) * currentSelectedPrice;
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                cartTable.Rows.Add(currentSelectedId, currentSelectedName, currentSelectedPrice, 1, currentSelectedPrice, currentAvailableStock);
            }

            UpdateTotals();
            currentSelectedId = 0;
            lblSelectedItem.Text = "---";
        }

        private void DgvCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCart.Columns[e.ColumnIndex].Name == "Qty")
            {
                int newQty = Convert.ToInt32(dgvCart.Rows[e.RowIndex].Cells["Qty"].Value);
                int maxStock = Convert.ToInt32(dgvCart.Rows[e.RowIndex].Cells["MaxStock"].Value);
                decimal price = Convert.ToDecimal(dgvCart.Rows[e.RowIndex].Cells["Unit Price"].Value);

                if (newQty > maxStock)
                {
                    MessageBox.Show($"Only {maxStock} available in stock. Quantity reset to maximum.", "Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    newQty = maxStock;
                    dgvCart.Rows[e.RowIndex].Cells["Qty"].Value = maxStock;
                }
                else if (newQty <= 0)
                {
                    newQty = 1;
                    dgvCart.Rows[e.RowIndex].Cells["Qty"].Value = 1;
                }

                dgvCart.Rows[e.RowIndex].Cells["Subtotal"].Value = newQty * price;
                UpdateTotals();
            }
        }

        private void DgvCart_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Please enter a valid number for quantity.", "Invalid Input");
            e.Cancel = true;
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCart.Columns[e.ColumnIndex].Name == "btnRemove")
            {
                cartTable.Rows.RemoveAt(e.RowIndex);
                UpdateTotals();
            }
        }

        private void UpdateTotals()
        {
            decimal totalAmount = 0;
            int totalItems = 0;

            foreach (DataRow row in cartTable.Rows)
            {
                totalItems += Convert.ToDecimal(row["Qty"]) > 0 ? Convert.ToInt32(row["Qty"]) : 0;
                totalAmount += Convert.ToDecimal(row["Subtotal"]);
            }

            lblTotalItems.Text = totalItems.ToString();
            lblTotalPrice.Text = $"${totalAmount:N2}";
        }

        
        
        
        private void GenerateNextOrderNumber()
        {
            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ISNULL(IDENT_CURRENT('Orders'), 0) + 1", conn);
                    int nextId = Convert.ToInt32(cmd.ExecuteScalar());
                    lblOrderNumber.Text = $"ORD-{DateTime.Now:yyyyMMdd}-{nextId:D4}";
                }
                catch { lblOrderNumber.Text = "ORD-PENDING"; }
            }
        }

        private int SaveOrderToDatabase()
        {
            decimal totalAmount = 0;
            foreach (DataRow row in cartTable.Rows) totalAmount += Convert.ToDecimal(row["Subtotal"]);

            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                SqlCommand getUserIdCmd = new SqlCommand("SELECT UserID FROM Users WHERE Username = @u", conn);
                getUserIdCmd.Parameters.AddWithValue("@u", cashierName);
                object userObj = getUserIdCmd.ExecuteScalar();
                if (userObj == null) { MessageBox.Show("Cashier not found in DB."); return -1; }
                int userId = Convert.ToInt32(userObj);

                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand orderCmd = new SqlCommand("INSERT INTO Orders (UserID, OrderDate, TotalAmount) OUTPUT INSERTED.OrderID VALUES (@uId, GETDATE(), @total)", conn, trans);
                        orderCmd.Parameters.AddWithValue("@uId", userId);
                        orderCmd.Parameters.AddWithValue("@total", totalAmount);
                        int newOrderId = (int)orderCmd.ExecuteScalar();

                        foreach (DataRow row in cartTable.Rows)
                        {
                            int pId = Convert.ToInt32(row["ProductID"]);
                            int qty = Convert.ToInt32(row["Qty"]);
                            decimal price = Convert.ToDecimal(row["Unit Price"]);

                            SqlCommand detailCmd = new SqlCommand("INSERT INTO OrderDetails (OrderID, ProductID, Quantity, UnitPrice) VALUES (@oId, @pId, @qty, @price)", conn, trans);
                            detailCmd.Parameters.AddWithValue("@oId", newOrderId);
                            detailCmd.Parameters.AddWithValue("@pId", pId);
                            detailCmd.Parameters.AddWithValue("@qty", qty);
                            detailCmd.Parameters.AddWithValue("@price", price);
                            detailCmd.ExecuteNonQuery();

                            SqlCommand stockCmd = new SqlCommand("UPDATE Products SET StockQuantity = StockQuantity - @qty WHERE ProductID = @pId", conn, trans);
                            stockCmd.Parameters.AddWithValue("@qty", qty);
                            stockCmd.Parameters.AddWithValue("@pId", pId);
                            stockCmd.ExecuteNonQuery();
                        }

                        trans.Commit();
                        return newOrderId;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Transaction Failed.\nError: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }
                }
            }
        }

        private void ClearCartAndReset()
        {
            cartTable.Clear();
            UpdateTotals();
            GenerateNextOrderNumber();
            lblSelectedItem.Text = "---";
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            if (cartTable.Rows.Count == 0) { MessageBox.Show("Cannot process an empty order."); return; }

            int savedOrderId = SaveOrderToDatabase();
            if (savedOrderId != -1)
            {
                MessageBox.Show($"Transaction Complete!\nOrder Saved: ORD-{DateTime.Now:yyyyMMdd}-{savedOrderId:D4}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearCartAndReset();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cartTable.Rows.Count == 0) { MessageBox.Show("No items to print."); return; }

            int savedOrderId = SaveOrderToDatabase();
            if (savedOrderId == -1) return;

            PrintDocument pd = new PrintDocument();
            DataTable receiptData = cartTable.Copy();
            string finalTotal = lblTotalPrice.Text;
            string finalOrderNum = $"ORD-{DateTime.Now:yyyyMMdd}-{savedOrderId:D4}";

            pd.PrintPage += (s, ev) => PrintReceiptPage(ev, receiptData, finalOrderNum, finalTotal);

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = pd;
            preview.Width = 600;
            preview.Height = 800;
            preview.ShowDialog();

            ClearCartAndReset();
        }

        private void PrintReceiptPage(PrintPageEventArgs e, DataTable receiptItems, string orderNum, string total)
        {
            Graphics g = e.Graphics;
            Font headerFont = new Font("Courier New", 18, FontStyle.Bold);
            Font bodyFont = new Font("Courier New", 12);
            Font boldBodyFont = new Font("Courier New", 12, FontStyle.Bold);
            Brush brush = Brushes.Black;

            int startX = 50;
            int startY = 50;
            int offset = 40;

            g.DrawString("PETAL PRISM BEAUTY STORE", headerFont, brush, startX, startY);
            g.DrawString("----------------------------------", bodyFont, brush, startX, startY + offset);
            g.DrawString($"Order ID : {orderNum}", bodyFont, brush, startX, startY + (offset * 2));
            g.DrawString($"Cashier  : {cashierName}", bodyFont, brush, startX, startY + (offset * 2) + 20);
            g.DrawString($"Date     : {DateTime.Now:MM/dd/yyyy hh:mm tt}", bodyFont, brush, startX, startY + (offset * 2) + 40);
            g.DrawString("----------------------------------", bodyFont, brush, startX, startY + (offset * 3) + 20);

            int itemY = startY + (offset * 4) + 20;

            foreach (DataRow row in receiptItems.Rows)
            {
                string qty = row["Qty"].ToString();
                string product = row["Product"].ToString();
                if (product.Length > 20) product = product.Substring(0, 20) + "...";
                string subtotal = $"${Convert.ToDecimal(row["Subtotal"]):N2}";

                g.DrawString($"{qty}x {product}", bodyFont, brush, startX, itemY);
                g.DrawString(subtotal, bodyFont, brush, startX + 300, itemY);
                itemY += 25;
            }

            g.DrawString("----------------------------------", bodyFont, brush, startX, itemY + 10);
            g.DrawString("TOTAL AMOUNT:", boldBodyFont, brush, startX, itemY + 40);
            g.DrawString(total, boldBodyFont, brush, startX + 300, itemY + 40);

            g.DrawString("Thank you for shopping with us!", bodyFont, brush, startX, itemY + 100);
        }
    }
    public class ProductSearchResult
    {
        public string DisplayText { get; set; }
        public string HiddenData { get; set; }
    }
}