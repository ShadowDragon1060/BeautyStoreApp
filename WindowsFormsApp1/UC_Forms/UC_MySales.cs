using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using BeautyStoreApp.Data;

namespace BeautyStoreApp
{
    public partial class UC_MySales : UserControl
    {
        private string loggedInStaff;

        public UC_MySales(string staffName)
        {
            InitializeComponent();
            loggedInStaff = staffName;

            
            if (!string.IsNullOrEmpty(loggedInStaff))
            {
                lblStaffName.Text = char.ToUpper(loggedInStaff[0]) + loggedInStaff.Substring(1).ToLower();
            }

           
            dgvMyOrders.SelectionChanged += dgvMyOrders_SelectionChanged;

            
            this.VisibleChanged += UC_MySales_VisibleChanged;

            
            StyleDataGridView(dgvMyOrders);
            StyleDataGridView(dgvMyDetails);

            
            LoadMyOrders();
        }

       
        
        
        private void UC_MySales_VisibleChanged(object sender, EventArgs e)
        {
            
            if (this.Visible)
            {
                LoadMyOrders();
            }
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

        

        
        private void LoadMyOrders()
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
                            o.OrderDate AS [Date Time],
                            o.TotalAmount AS [Total ($)]
                        FROM Orders o
                        INNER JOIN Users u ON o.UserID = u.UserID
                        WHERE u.Username = @username
                        ORDER BY o.OrderDate DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", loggedInStaff);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvMyOrders.DataSource = dt;
                    dgvMyOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dgvMyOrders.Columns["Order ID"] != null) dgvMyOrders.Columns["Order ID"].Visible = false;
                    if (dgvMyOrders.Columns["S/N"] != null) dgvMyOrders.Columns["S/N"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    dgvMyOrders.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

                    if (dgvMyOrders.Columns["Date Time"] != null)
                        dgvMyOrders.Columns["Date Time"].DefaultCellStyle.Format = "MMM dd, yyyy - hh:mm tt";
                    if (dgvMyOrders.Columns["Total ($)"] != null)
                        dgvMyOrders.Columns["Total ($)"].DefaultCellStyle.Format = "N2";

                    
                    dgvMyOrders.CurrentCell = null;
                    dgvMyDetails.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading your sales history: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
         
      
        private void dgvMyOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMyOrders.SelectedRows.Count > 0)
            {
                int selectedOrderId = Convert.ToInt32(dgvMyOrders.SelectedRows[0].Cells["Order ID"].Value);

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
                                od.UnitPrice AS [Unit Price ($)],
                                (od.Quantity * od.UnitPrice) AS [Subtotal ($)]
                            FROM OrderDetails od
                            INNER JOIN Products p ON od.ProductID = p.ProductID
                            WHERE od.OrderID = @orderId";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@orderId", selectedOrderId);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvMyDetails.DataSource = dt;
                        dgvMyDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        dgvMyDetails.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

                        if (dgvMyDetails.Columns["S/N"] != null) dgvMyDetails.Columns["S/N"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        if (dgvMyDetails.Columns["Unit Price ($)"] != null) dgvMyDetails.Columns["Unit Price ($)"].DefaultCellStyle.Format = "N2";
                        if (dgvMyDetails.Columns["Subtotal ($)"] != null) dgvMyDetails.Columns["Subtotal ($)"].DefaultCellStyle.Format = "N2";

                        dgvMyDetails.CurrentCell = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading order details: " + ex.Message, "Database Error");
                    }
                }
            }
        }
    }
}