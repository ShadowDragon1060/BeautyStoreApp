namespace BeautyStoreApp
{
    partial class UC_Stock
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Stock));
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblCriticalStock = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalLowStock = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanelSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.dgvLowStock = new System.Windows.Forms.DataGridView();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.btnQuick100 = new System.Windows.Forms.Button();
            this.btnQuick50 = new System.Windows.Forms.Button();
            this.btnQuick10 = new System.Windows.Forms.Button();
            this.picProductPreview = new System.Windows.Forms.PictureBox();
            this.numRestock = new System.Windows.Forms.NumericUpDown();
            this.lblSelectedItem = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRestock = new System.Windows.Forms.Button();
            this.panelDetailHeader = new System.Windows.Forms.Panel();
            this.lblDetailTitle = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.flowLayoutPanelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).BeginInit();
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProductPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRestock)).BeginInit();
            this.panelDetailHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelTop.Controls.Add(this.lblCriticalStock);
            this.panelTop.Controls.Add(this.label8);
            this.panelTop.Controls.Add(this.lblTotalLowStock);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Controls.Add(this.flowLayoutPanelSearch);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(986, 75);
            this.panelTop.TabIndex = 7;
            // 
            // lblCriticalStock
            // 
            this.lblCriticalStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCriticalStock.AutoSize = true;
            this.lblCriticalStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCriticalStock.ForeColor = System.Drawing.Color.Crimson;
            this.lblCriticalStock.Location = new System.Drawing.Point(920, 24);
            this.lblCriticalStock.Name = "lblCriticalStock";
            this.lblCriticalStock.Size = new System.Drawing.Size(36, 28);
            this.lblCriticalStock.TabIndex = 16;
            this.lblCriticalStock.Text = "---";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(845, 28); // Shifted Y to match baseline
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Critical:";
            // 
            // lblTotalLowStock
            // 
            this.lblTotalLowStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalLowStock.AutoSize = true;
            this.lblTotalLowStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalLowStock.ForeColor = System.Drawing.Color.HotPink;
            this.lblTotalLowStock.Location = new System.Drawing.Point(795, 24);
            this.lblTotalLowStock.Name = "lblTotalLowStock";
            this.lblTotalLowStock.Size = new System.Drawing.Size(36, 28);
            this.lblTotalLowStock.TabIndex = 14;
            this.lblTotalLowStock.Text = "---";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(705, 28); // Shifted Y to match baseline
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total low:";
            // 
            // flowLayoutPanelSearch
            // 
            this.flowLayoutPanelSearch.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelSearch.Controls.Add(this.pictureBox2);
            this.flowLayoutPanelSearch.Controls.Add(this.txtSearch);
            this.flowLayoutPanelSearch.Location = new System.Drawing.Point(290, 18);
            this.flowLayoutPanelSearch.Name = "flowLayoutPanelSearch";
            this.flowLayoutPanelSearch.Size = new System.Drawing.Size(310, 40);
            this.flowLayoutPanelSearch.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(42, 6);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 6, 0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(255, 25);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOW STOCK ALERTS";
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitMain.IsSplitterFixed = true;
            this.splitMain.Location = new System.Drawing.Point(0, 75);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.dgvLowStock);
            this.splitMain.Panel1.Padding = new System.Windows.Forms.Padding(15, 10, 5, 15);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.panelDetails);
            this.splitMain.Panel2.Padding = new System.Windows.Forms.Padding(5, 10, 15, 15);
            this.splitMain.Size = new System.Drawing.Size(986, 509);
            this.splitMain.SplitterDistance = 650;
            this.splitMain.TabIndex = 10;
            // 
            // dgvLowStock
            // 
            this.dgvLowStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLowStock.Location = new System.Drawing.Point(15, 10);
            this.dgvLowStock.Name = "dgvLowStock";
            this.dgvLowStock.Size = new System.Drawing.Size(630, 484);
            this.dgvLowStock.TabIndex = 8;
            this.dgvLowStock.SelectionChanged += new System.EventHandler(this.dgvLowStock_SelectionChanged);
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.White;
            this.panelDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetails.Controls.Add(this.btnQuick100);
            this.panelDetails.Controls.Add(this.btnQuick50);
            this.panelDetails.Controls.Add(this.btnQuick10);
            this.panelDetails.Controls.Add(this.picProductPreview);
            this.panelDetails.Controls.Add(this.numRestock);
            this.panelDetails.Controls.Add(this.lblSelectedItem);
            this.panelDetails.Controls.Add(this.label4);
            this.panelDetails.Controls.Add(this.btnRestock);
            this.panelDetails.Controls.Add(this.panelDetailHeader);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(5, 10);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(312, 484);
            this.panelDetails.TabIndex = 9;
            // 
            // btnQuick100
            // 
            this.btnQuick100.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuick100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuick100.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnQuick100.Location = new System.Drawing.Point(196, 360);
            this.btnQuick100.Name = "btnQuick100";
            this.btnQuick100.Size = new System.Drawing.Size(60, 30);
            this.btnQuick100.TabIndex = 18;
            this.btnQuick100.Text = "+100";
            this.btnQuick100.UseVisualStyleBackColor = true;
            this.btnQuick100.Click += new System.EventHandler(this.btnQuick100_Click);
            // 
            // btnQuick50
            // 
            this.btnQuick50.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuick50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuick50.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnQuick50.Location = new System.Drawing.Point(126, 360);
            this.btnQuick50.Name = "btnQuick50";
            this.btnQuick50.Size = new System.Drawing.Size(55, 30);
            this.btnQuick50.TabIndex = 17;
            this.btnQuick50.Text = "+50";
            this.btnQuick50.UseVisualStyleBackColor = true;
            this.btnQuick50.Click += new System.EventHandler(this.btnQuick50_Click);
            // 
            // btnQuick10
            // 
            this.btnQuick10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuick10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuick10.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnQuick10.Location = new System.Drawing.Point(56, 360);
            this.btnQuick10.Name = "btnQuick10";
            this.btnQuick10.Size = new System.Drawing.Size(55, 30);
            this.btnQuick10.TabIndex = 16;
            this.btnQuick10.Text = "+10";
            this.btnQuick10.UseVisualStyleBackColor = true;
            this.btnQuick10.Click += new System.EventHandler(this.btnQuick10_Click);
            // 
            // picProductPreview
            // 
            this.picProductPreview.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picProductPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProductPreview.Location = new System.Drawing.Point(60, 60);
            this.picProductPreview.Name = "picProductPreview";
            this.picProductPreview.Size = new System.Drawing.Size(190, 180);
            this.picProductPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProductPreview.TabIndex = 14;
            this.picProductPreview.TabStop = false;
            // 
            // numRestock
            // 
            this.numRestock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numRestock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numRestock.Location = new System.Drawing.Point(80, 315);
            this.numRestock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numRestock.Name = "numRestock";
            this.numRestock.Size = new System.Drawing.Size(150, 30);
            this.numRestock.TabIndex = 13;
            this.numRestock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSelectedItem
            // 
            this.lblSelectedItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSelectedItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSelectedItem.Location = new System.Drawing.Point(10, 250);
            this.lblSelectedItem.Name = "lblSelectedItem";
            this.lblSelectedItem.Size = new System.Drawing.Size(290, 30);
            this.lblSelectedItem.TabIndex = 12;
            this.lblSelectedItem.Text = "---";
            this.lblSelectedItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(10, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Amount to Add:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestock
            // 
            this.btnRestock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRestock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRestock.Location = new System.Drawing.Point(28, 415);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(256, 45);
            this.btnRestock.TabIndex = 4;
            this.btnRestock.Text = "Execute Restock";
            this.btnRestock.UseVisualStyleBackColor = true;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // panelDetailHeader
            // 
            this.panelDetailHeader.BackColor = System.Drawing.Color.HotPink;
            this.panelDetailHeader.Controls.Add(this.lblDetailTitle);
            this.panelDetailHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetailHeader.Location = new System.Drawing.Point(0, 0);
            this.panelDetailHeader.Name = "panelDetailHeader";
            this.panelDetailHeader.Size = new System.Drawing.Size(310, 40);
            this.panelDetailHeader.TabIndex = 13;
            // 
            // lblDetailTitle
            // 
            this.lblDetailTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetailTitle.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblDetailTitle.ForeColor = System.Drawing.Color.White;
            this.lblDetailTitle.Location = new System.Drawing.Point(0, 0);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(310, 40);
            this.lblDetailTitle.TabIndex = 0;
            this.lblDetailTitle.Text = "RESTOCK ACTION";
            this.lblDetailTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.panelTop);
            this.Name = "UC_Stock";
            this.Size = new System.Drawing.Size(986, 584);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.flowLayoutPanelSearch.ResumeLayout(false);
            this.flowLayoutPanelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).EndInit();
            this.panelDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProductPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRestock)).EndInit();
            this.panelDetailHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCriticalStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalLowStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.DataGridView dgvLowStock;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Panel panelDetailHeader;
        private System.Windows.Forms.Label lblDetailTitle;
        private System.Windows.Forms.PictureBox picProductPreview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSelectedItem;
        private System.Windows.Forms.NumericUpDown numRestock;
        private System.Windows.Forms.Button btnRestock;
        private System.Windows.Forms.Button btnQuick10;
        private System.Windows.Forms.Button btnQuick50;
        private System.Windows.Forms.Button btnQuick100;
    }
}