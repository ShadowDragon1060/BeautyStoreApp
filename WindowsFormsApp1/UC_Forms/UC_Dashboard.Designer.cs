namespace BeautyStoreApp
{
    partial class UC_Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 =
                new System.Windows.Forms.DataVisualization.Charting.ChartArea();

            this.panelGreeting = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();

            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.splitTopRow = new System.Windows.Forms.SplitContainer();
            this.splitTopRight = new System.Windows.Forms.SplitContainer();
            this.splitBottomRow = new System.Windows.Forms.SplitContainer();

            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalProducts = new System.Windows.Forms.Label();

            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLowStock = new System.Windows.Forms.Label();

            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();

            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvRecent = new System.Windows.Forms.DataGridView();

            this.panel5 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();

            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.splitTopRow)).BeginInit();
            this.splitTopRow.Panel1.SuspendLayout();
            this.splitTopRow.Panel2.SuspendLayout();
            this.splitTopRow.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.splitTopRight)).BeginInit();
            this.splitTopRight.Panel1.SuspendLayout();
            this.splitTopRight.Panel2.SuspendLayout();
            this.splitTopRight.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.splitBottomRow)).BeginInit();
            this.splitBottomRow.Panel1.SuspendLayout();
            this.splitBottomRow.Panel2.SuspendLayout();
            this.splitBottomRow.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();

            this.panelGreeting.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();

            // panelGreeting
            this.panelGreeting.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGreeting.Height = 70;
            this.panelGreeting.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelGreeting.Padding = new System.Windows.Forms.Padding(14, 10, 0, 0);
            this.panelGreeting.Controls.Add(this.label3);
            this.panelGreeting.Controls.Add(this.lblAdminName);
            this.panelGreeting.Controls.Add(this.label1);
            this.panelGreeting.Name = "panelGreeting";

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Text = "Hello,";
            this.label1.Name = "label1";

            // lblAdminName
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblAdminName.ForeColor = System.Drawing.Color.HotPink;
            this.lblAdminName.Location = new System.Drawing.Point(100, 10);
            this.lblAdminName.Text = "---";
            this.lblAdminName.Name = "lblAdminName";

            // label3
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(16, 46);
            this.label3.Text = "Have a great day!";
            this.label3.Name = "label3";

            // splitMain
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitMain.IsSplitterFixed = false;
            this.splitMain.Panel1MinSize = 50; // CRITICAL FIX: Lowered MinSize
            this.splitMain.Panel2MinSize = 50; // CRITICAL FIX: Lowered MinSize
            this.splitMain.Name = "splitMain";
            this.splitMain.Panel1.Controls.Add(this.splitTopRow);
            this.splitMain.Panel1.Padding = new System.Windows.Forms.Padding(8, 8, 8, 4);
            this.splitMain.Panel2.Controls.Add(this.splitBottomRow);
            this.splitMain.Panel2.Padding = new System.Windows.Forms.Padding(8, 4, 8, 8);

            // splitTopRow
            this.splitTopRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTopRow.IsSplitterFixed = false;
            this.splitTopRow.Panel1MinSize = 50;
            this.splitTopRow.Panel2MinSize = 50;
            this.splitTopRow.Name = "splitTopRow";
            this.splitTopRow.Panel1.Controls.Add(this.panel1);
            this.splitTopRow.Panel2.Controls.Add(this.splitTopRight);

            // splitTopRight
            this.splitTopRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTopRight.IsSplitterFixed = false;
            this.splitTopRight.Panel1MinSize = 50;
            this.splitTopRight.Panel2MinSize = 50;
            this.splitTopRight.Name = "splitTopRight";
            this.splitTopRight.Panel1.Controls.Add(this.panel3);
            this.splitTopRight.Panel2.Controls.Add(this.panel6);

            // splitBottomRow
            this.splitBottomRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitBottomRow.IsSplitterFixed = false;
            this.splitBottomRow.Panel1MinSize = 50;
            this.splitBottomRow.Panel2MinSize = 50;
            this.splitBottomRow.Name = "splitBottomRow";
            this.splitBottomRow.Panel1.Controls.Add(this.panel4);
            this.splitBottomRow.Panel2.Controls.Add(this.panel5);

            // panel1
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Controls.Add(this.lblTotalProducts);
            this.panel1.Controls.Add(this.label4);

            // label4
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Text = "Total Products";
            this.label4.Name = "label4";
            this.label4.AutoSize = false;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblTotalProducts
            this.lblTotalProducts.Font = new System.Drawing.Font("Franklin Gothic Medium", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotalProducts.ForeColor = System.Drawing.Color.HotPink;
            this.lblTotalProducts.Text = "---";
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.AutoSize = false;
            this.lblTotalProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // panel3
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.Padding = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Controls.Add(this.lblLowStock);
            this.panel3.Controls.Add(this.label5);

            // label5
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Text = "Low Stock Items";
            this.label5.Name = "label5";
            this.label5.AutoSize = false;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblLowStock
            this.lblLowStock.Font = new System.Drawing.Font("Franklin Gothic Medium", 22F, System.Drawing.FontStyle.Bold);
            this.lblLowStock.ForeColor = System.Drawing.Color.Crimson;
            this.lblLowStock.Text = "---";
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.AutoSize = false;
            this.lblLowStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // panel6
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.BackColor = System.Drawing.Color.Lavender;
            this.panel6.Padding = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Controls.Add(this.lblRevenue);
            this.panel6.Controls.Add(this.label8);

            // label8
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Text = "Today's Revenue";
            this.label8.Name = "label8";
            this.label8.AutoSize = false;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblRevenue
            this.lblRevenue.Font = new System.Drawing.Font("Franklin Gothic Medium", 22F, System.Drawing.FontStyle.Bold);
            this.lblRevenue.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblRevenue.Text = "---";
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.AutoSize = false;
            this.lblRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // panel4
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel4.Padding = new System.Windows.Forms.Padding(6);
            this.panel4.Name = "panel4";
            this.panel4.Controls.Add(this.dgvRecent);
            this.panel4.Controls.Add(this.label7);

            // label7
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Height = 38;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Text = "  Recent Activity";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Name = "label7";

            // dgvRecent
            this.dgvRecent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecent.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgvRecent.Name = "dgvRecent";
            this.dgvRecent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // panel5
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel5.Padding = new System.Windows.Forms.Padding(6);
            this.panel5.Name = "panel5";
            this.panel5.Controls.Add(this.chart1);

            // chart1
            chartArea1.Name = "ChartArea1";
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.Name = "chart1";

            // UC_Dashboard
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Name = "UC_Dashboard";
            this.Size = new System.Drawing.Size(986, 650);

            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.panelGreeting);

            this.panelGreeting.ResumeLayout(false);
            this.panelGreeting.PerformLayout();

            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);

            this.splitTopRow.Panel1.ResumeLayout(false);
            this.splitTopRow.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTopRow)).EndInit();
            this.splitTopRow.ResumeLayout(false);

            this.splitTopRight.Panel1.ResumeLayout(false);
            this.splitTopRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTopRight)).EndInit();
            this.splitTopRight.ResumeLayout(false);

            this.splitBottomRow.Panel1.ResumeLayout(false);
            this.splitBottomRow.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitBottomRow)).EndInit();
            this.splitBottomRow.ResumeLayout(false);

            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);

            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).EndInit();

            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelGreeting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.SplitContainer splitTopRow;
        private System.Windows.Forms.SplitContainer splitTopRight;
        private System.Windows.Forms.SplitContainer splitBottomRow;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalProducts;

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLowStock;

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRevenue;

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvRecent;

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}