namespace BeautyStoreApp
{
    partial class UC_MySales
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.panelOrders = new System.Windows.Forms.Panel();
            this.dgvMyOrders = new System.Windows.Forms.DataGridView();
            this.panelOrdersHeader = new System.Windows.Forms.Panel();
            this.lblOrdersHeader = new System.Windows.Forms.Label();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.dgvMyDetails = new System.Windows.Forms.DataGridView();
            this.panelDetailsHeader = new System.Windows.Forms.Panel();
            this.lblDetailsHeader = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.panelOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyOrders)).BeginInit();
            this.panelOrdersHeader.SuspendLayout();
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyDetails)).BeginInit();
            this.panelDetailsHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.lblStaffName);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(986, 100);
            this.panelTop.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(15, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Keep up the good work!";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblStaffName.ForeColor = System.Drawing.Color.HotPink;
            this.lblStaffName.Location = new System.Drawing.Point(95, 45);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(34, 29);
            this.lblStaffName.TabIndex = 4;
            this.lblStaffName.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hello,";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALES HISTORY";
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.IsSplitterFixed = true;
            this.splitMain.Location = new System.Drawing.Point(0, 100);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.panelOrders);
            this.splitMain.Panel1.Padding = new System.Windows.Forms.Padding(15, 10, 5, 15);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.panelDetails);
            this.splitMain.Panel2.Padding = new System.Windows.Forms.Padding(5, 10, 15, 15);
            this.splitMain.Size = new System.Drawing.Size(986, 484);
            this.splitMain.SplitterDistance = 496;
            this.splitMain.SplitterWidth = 7;
            this.splitMain.TabIndex = 11;
            // 
            // panelOrders
            // 
            this.panelOrders.BackColor = System.Drawing.Color.White;
            this.panelOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrders.Controls.Add(this.dgvMyOrders);
            this.panelOrders.Controls.Add(this.panelOrdersHeader);
            this.panelOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrders.Location = new System.Drawing.Point(15, 10);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Size = new System.Drawing.Size(476, 459);
            this.panelOrders.TabIndex = 0;
            // 
            // dgvMyOrders
            // 
            this.dgvMyOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMyOrders.Location = new System.Drawing.Point(0, 40);
            this.dgvMyOrders.Name = "dgvMyOrders";
            this.dgvMyOrders.RowHeadersWidth = 51;
            this.dgvMyOrders.RowTemplate.Height = 24;
            this.dgvMyOrders.Size = new System.Drawing.Size(474, 417);
            this.dgvMyOrders.TabIndex = 9;
            // 
            // panelOrdersHeader
            // 
            this.panelOrdersHeader.BackColor = System.Drawing.Color.HotPink;
            this.panelOrdersHeader.Controls.Add(this.lblOrdersHeader);
            this.panelOrdersHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrdersHeader.Location = new System.Drawing.Point(0, 0);
            this.panelOrdersHeader.Name = "panelOrdersHeader";
            this.panelOrdersHeader.Size = new System.Drawing.Size(474, 40);
            this.panelOrdersHeader.TabIndex = 10;
            // 
            // lblOrdersHeader
            // 
            this.lblOrdersHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrdersHeader.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblOrdersHeader.ForeColor = System.Drawing.Color.White;
            this.lblOrdersHeader.Location = new System.Drawing.Point(0, 0);
            this.lblOrdersHeader.Name = "lblOrdersHeader";
            this.lblOrdersHeader.Size = new System.Drawing.Size(474, 40);
            this.lblOrdersHeader.TabIndex = 0;
            this.lblOrdersHeader.Text = "MY ORDER RECORDS";
            this.lblOrdersHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.White;
            this.panelDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetails.Controls.Add(this.dgvMyDetails);
            this.panelDetails.Controls.Add(this.panelDetailsHeader);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(5, 10);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(463, 459);
            this.panelDetails.TabIndex = 1;
            // 
            // dgvMyDetails
            // 
            this.dgvMyDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMyDetails.Location = new System.Drawing.Point(0, 40);
            this.dgvMyDetails.Name = "dgvMyDetails";
            this.dgvMyDetails.RowHeadersWidth = 51;
            this.dgvMyDetails.RowTemplate.Height = 24;
            this.dgvMyDetails.Size = new System.Drawing.Size(461, 417);
            this.dgvMyDetails.TabIndex = 10;
            // 
            // panelDetailsHeader
            // 
            this.panelDetailsHeader.BackColor = System.Drawing.Color.HotPink;
            this.panelDetailsHeader.Controls.Add(this.lblDetailsHeader);
            this.panelDetailsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetailsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelDetailsHeader.Name = "panelDetailsHeader";
            this.panelDetailsHeader.Size = new System.Drawing.Size(461, 40);
            this.panelDetailsHeader.TabIndex = 11;
            // 
            // lblDetailsHeader
            // 
            this.lblDetailsHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetailsHeader.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblDetailsHeader.ForeColor = System.Drawing.Color.White;
            this.lblDetailsHeader.Location = new System.Drawing.Point(0, 0);
            this.lblDetailsHeader.Name = "lblDetailsHeader";
            this.lblDetailsHeader.Size = new System.Drawing.Size(461, 40);
            this.lblDetailsHeader.TabIndex = 0;
            this.lblDetailsHeader.Text = "ORDER DETAILS";
            this.lblDetailsHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_MySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.panelTop);
            this.Name = "UC_MySales";
            this.Size = new System.Drawing.Size(986, 584);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.panelOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyOrders)).EndInit();
            this.panelOrdersHeader.ResumeLayout(false);
            this.panelDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyDetails)).EndInit();
            this.panelDetailsHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Panel panelOrders;
        private System.Windows.Forms.Panel panelOrdersHeader;
        private System.Windows.Forms.Label lblOrdersHeader;
        private System.Windows.Forms.DataGridView dgvMyOrders;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Panel panelDetailsHeader;
        private System.Windows.Forms.Label lblDetailsHeader;
        private System.Windows.Forms.DataGridView dgvMyDetails;
    }
}