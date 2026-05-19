using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BeautyStoreApp.Data;

namespace BeautyStoreApp
{
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard(string username)
        {
            InitializeComponent();

            
            this.Load += UC_Dashboard_Load;

            if (!string.IsNullOrEmpty(username))
                lblAdminName.Text = char.ToUpper(username[0]) + username.Substring(1).ToLower();

            StyleDataGridView(dgvRecent);
            LoadMetrics();
            LoadRecentActivity();
            LoadPieChart();

            CenterLabelsInPanel(panel1, label4, lblTotalProducts);
            CenterLabelsInPanel(panel3, label5, lblLowStock);
            CenterLabelsInPanel(panel6, label8, lblRevenue);
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            
            SafeSetSplitter(splitMain, 0.35);       
            SafeSetSplitter(splitTopRow, 0.33);     
            SafeSetSplitter(splitTopRight, 0.50);   
            SafeSetSplitter(splitBottomRow, 0.60);  
        }

        
        private void SafeSetSplitter(SplitContainer split, double percentage)
        {
            try
            {
                int totalSize = split.Orientation == Orientation.Horizontal ? split.Height : split.Width;
                if (totalSize == 0) return;

                int targetDistance = (int)(totalSize * percentage);

                int minVal = split.Panel1MinSize;
                int maxVal = totalSize - split.Panel2MinSize;

                if (maxVal < minVal) return; 

                if (targetDistance < minVal) targetDistance = minVal;
                if (targetDistance > maxVal) targetDistance = maxVal;

                split.SplitterDistance = targetDistance;
            }
            catch { }
        }

        private void CenterLabelsInPanel(Panel panel, Label titleLabel, Label valueLabel)
        {
            titleLabel.AutoSize = false;
            valueLabel.AutoSize = false;
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            valueLabel.TextAlign = ContentAlignment.MiddleCenter;
            titleLabel.Height = 35;
            valueLabel.Height = 35;

            Action reposition = () =>
            {
                titleLabel.Width = panel.Width - 20;
                valueLabel.Width = panel.Width - 20;
                titleLabel.Location = new Point(10, panel.Height / 2 - 45);
                valueLabel.Location = new Point(10, panel.Height / 2);
            };

            reposition();
            panel.Resize += (s, e) => reposition();
        }

        private void LoadMetrics()
        {
            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                try
                {
                    conn.Open();

                    SqlCommand cmdProducts = new SqlCommand("SELECT COUNT(*) FROM Products", conn);
                    lblTotalProducts.Text = cmdProducts.ExecuteScalar().ToString();

                    SqlCommand cmdStock = new SqlCommand("SELECT COUNT(*) FROM Products WHERE StockQuantity < 50", conn);
                    int lowStockCount = (int)cmdStock.ExecuteScalar();
                    lblLowStock.Text = lowStockCount.ToString();
                    lblLowStock.ForeColor = lowStockCount > 0 ? Color.Crimson : Color.DimGray;

                    string revQuery = "SELECT ISNULL(SUM(TotalAmount), 0) FROM Orders WHERE CAST(OrderDate AS DATE) = CAST(GETDATE() AS DATE)";
                    SqlCommand cmdRev = new SqlCommand(revQuery, conn);
                    decimal todayRevenue = Convert.ToDecimal(cmdRev.ExecuteScalar());
                    lblRevenue.Text = "$" + todayRevenue.ToString("N2");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading metrics: " + ex.Message);
                }
            }
        }

        private void LoadRecentActivity()
        {
            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT TOP 5 
                            o.OrderID       AS [Order #],
                            u.Username      AS [Cashier],
                            o.OrderDate     AS [Date],
                            o.TotalAmount   AS [Amount ($)]
                        FROM Orders o
                        LEFT JOIN Users u ON o.UserID = u.UserID
                        ORDER BY o.OrderDate DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvRecent.DataSource = dt;
                    dgvRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dgvRecent.Columns["Date"] != null)
                        dgvRecent.Columns["Date"].DefaultCellStyle.Format = "MMM dd, hh:mm tt";
                    if (dgvRecent.Columns["Amount ($)"] != null)
                        dgvRecent.Columns["Amount ($)"].DefaultCellStyle.Format = "N2";

                    dgvRecent.CurrentCell = null;
                }
                catch {  }
            }
        }

        private void LoadPieChart()
        {
            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT c.CategoryName, COUNT(p.ProductID) AS ProductCount
                        FROM Products p
                        INNER JOIN Categories c ON p.CategoryID = c.CategoryID
                        GROUP BY c.CategoryName";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    chart1.Series.Clear();
                    chart1.Titles.Clear();
                    chart1.Legends.Clear();

                    chart1.ChartAreas[0].BackColor = Color.Transparent;
                    chart1.BackColor = Color.Transparent;

                    var title = chart1.Titles.Add("Products by Category");
                    title.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                    title.ForeColor = Color.DimGray;
                    title.Docking = Docking.Top;

                    Legend legend = new Legend("MainLegend");
                    legend.Font = new Font("Segoe UI", 8);
                    legend.BackColor = Color.Transparent;
                    legend.Docking = Docking.Bottom;
                    chart1.Legends.Add(legend);

                    Series pieSeries = new Series("Categories");
                    pieSeries.ChartType = SeriesChartType.Pie;
                    pieSeries.Legend = "MainLegend";
                    pieSeries.IsValueShownAsLabel = true;
                    pieSeries.LabelFormat = "{0}";
                    pieSeries.CustomProperties = "PieLabelStyle=Outside, PieLineColor=DimGray";
                    pieSeries["PieStartAngle"] = "270";

                    Color[] pieColors = new Color[]
                    {
                        Color.FromArgb(255, 105, 148), 
                        Color.FromArgb(255, 182, 193), 
                        Color.FromArgb(219, 112, 147), 
                        Color.FromArgb(255, 20,  147), 
                        Color.FromArgb(199, 21,  133), 
                        Color.FromArgb(255, 228, 225), 
                    };

                    int colorIndex = 0;
                    while (reader.Read())
                    {
                        string catName = reader["CategoryName"].ToString();
                        int count = Convert.ToInt32(reader["ProductCount"]);
                        int pointIndex = pieSeries.Points.AddXY(catName, count);
                        pieSeries.Points[pointIndex].Color = pieColors[colorIndex % pieColors.Length];
                        pieSeries.Points[pointIndex].LegendText = catName;
                        colorIndex++;
                    }

                    chart1.Series.Add(pieSeries);
                }
                catch { }
            }
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.LavenderBlush;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.LightPink;
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.HotPink;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.HotPink;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
            dgv.ColumnHeadersHeight = 36;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.PaleVioletRed;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgv.DefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
            dgv.RowTemplate.Height = 32;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 240, 245);
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}