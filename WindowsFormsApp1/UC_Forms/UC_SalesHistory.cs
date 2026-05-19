using BeautyStoreApp.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BeautyStoreApp
{
    public partial class UC_SalesHistory : UserControl
    {
        public UC_SalesHistory()
        {
            InitializeComponent();

            
            btnFilter.Click += btnFilter_Click;
            dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;

            
            StyleDataGridView(dgvOrders);
            StyleDataGridView(dgvOrderDetails);
            StyleControls();

            
            dtpFromDate.Value = DateTime.Today.AddDays(-7);
            dtpToDate.Value = DateTime.Today;

            
            LoadOrders();
        }

       
        
       
        private void StyleControls()
        {
            
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.BackColor = Color.HotPink;
            btnFilter.ForeColor = Color.White;
            btnFilter.FlatAppearance.BorderColor = Color.DeepPink;
            btnFilter.FlatAppearance.MouseOverBackColor = Color.DeepPink;

            
            dtpFromDate.Font = new Font("Segoe UI", 10f);
            dtpToDate.Font = new Font("Segoe UI", 10f);
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
            dgv.AllowUserToResizeRows = false;
        }

  
        
       
        private void LoadOrders()
        {
            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            ROW_NUMBER() OVER(ORDER BY o.OrderDate ASC) AS [S/N],
                            o.OrderID AS [Order ID],
                            u.Username AS [Cashier],
                            o.OrderDate AS [Date Time],
                            o.TotalAmount AS [Total ($)]
                        FROM Orders o
                        LEFT JOIN Users u ON o.UserID = u.UserID
                        WHERE o.OrderDate >= @fromDate AND o.OrderDate <= @toDate
                        ORDER BY o.OrderDate DESC"; 

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fromDate", dtpFromDate.Value.Date);
                    cmd.Parameters.AddWithValue("@toDate", dtpToDate.Value.Date.AddDays(1).AddTicks(-1));

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvOrders.DataSource = dt;
                    dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dgvOrders.Columns["Order ID"] != null) dgvOrders.Columns["Order ID"].Visible = false;

                    if (dgvOrders.Columns["S/N"] != null) dgvOrders.Columns["S/N"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    dgvOrders.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

                    if (dgvOrders.Columns["Date Time"] != null) dgvOrders.Columns["Date Time"].DefaultCellStyle.Format = "MMM dd, yyyy - hh:mm tt";
                    if (dgvOrders.Columns["Total ($)"] != null) dgvOrders.Columns["Total ($)"].DefaultCellStyle.Format = "N2";

                    dgvOrders.CurrentCell = null;
                    dgvOrderDetails.DataSource = null; 
                }
                catch (Exception ex) { MessageBox.Show("Error loading orders: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (dtpFromDate.Value > dtpToDate.Value)
            {
                MessageBox.Show("The 'From Date' cannot be later than the 'To Date'.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadOrders();
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                int selectedOrderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["Order ID"].Value);
                using (SqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = @"
                            SELECT 
                                ROW_NUMBER() OVER(ORDER BY p.ProductName ASC) AS [S/N],
                                p.ProductName AS [Product],
                                od.Quantity AS [Qty],
                                od.UnitPrice AS [Price ($)],
                                (od.Quantity * od.UnitPrice) AS [Subtotal ($)]
                            FROM OrderDetails od
                            INNER JOIN Products p ON od.ProductID = p.ProductID
                            WHERE od.OrderID = @orderId";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@orderId", selectedOrderId);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvOrderDetails.DataSource = dt;
                        dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        dgvOrderDetails.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

                        if (dgvOrderDetails.Columns["S/N"] != null) dgvOrderDetails.Columns["S/N"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        if (dgvOrderDetails.Columns["Price ($)"] != null) dgvOrderDetails.Columns["Price ($)"].DefaultCellStyle.Format = "N2";
                        if (dgvOrderDetails.Columns["Subtotal ($)"] != null) dgvOrderDetails.Columns["Subtotal ($)"].DefaultCellStyle.Format = "N2";

                        dgvOrderDetails.CurrentCell = null;
                    }
                    catch (Exception ex) { MessageBox.Show("Error loading details: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }
    }
}