namespace BeautyStoreApp
{
    partial class UC_Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Products));
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.panelDetailHeader = new System.Windows.Forms.Panel();
            this.lblDetailTitle = new System.Windows.Forms.Label();
            this.picProductPreview = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDetName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDetBrand = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDetPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDetStock = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.flowLayoutPanelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panelDetails.SuspendLayout();
            this.panelDetailHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProductPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.flowLayoutPanelSearch);
            this.panelTop.Controls.Add(this.btnAdd);
            this.panelTop.Controls.Add(this.btnEdit);
            this.panelTop.Controls.Add(this.btnRemove);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(986, 75);
            this.panelTop.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCT INVENTORY";
            // 
            // flowLayoutPanelSearch
            // 
            this.flowLayoutPanelSearch.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelSearch.Controls.Add(this.pictureBox2);
            this.flowLayoutPanelSearch.Controls.Add(this.txtSearch);
            this.flowLayoutPanelSearch.Location = new System.Drawing.Point(320, 18); // MOVED RIGHT TO FIX OVERLAP
            this.flowLayoutPanelSearch.Name = "flowLayoutPanelSearch";
            this.flowLayoutPanelSearch.Size = new System.Drawing.Size(310, 40); // SLIGHTLY ADJUSTED WIDTH
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
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(650, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(760, 18);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 40);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemove.Location = new System.Drawing.Point(870, 18);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 40);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            this.splitMain.Panel1.Controls.Add(this.dgvProducts);
            this.splitMain.Panel1.Padding = new System.Windows.Forms.Padding(15, 10, 5, 15);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.panelDetails);
            this.splitMain.Panel2.Padding = new System.Windows.Forms.Padding(5, 10, 15, 15);
            this.splitMain.Size = new System.Drawing.Size(986, 509);
            this.splitMain.SplitterDistance = 680;
            this.splitMain.TabIndex = 10;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(15, 10);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(660, 484);
            this.dgvProducts.TabIndex = 8;
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.White;
            this.panelDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetails.Controls.Add(this.lblDetStock);
            this.panelDetails.Controls.Add(this.label5);
            this.panelDetails.Controls.Add(this.lblDetPrice);
            this.panelDetails.Controls.Add(this.label3);
            this.panelDetails.Controls.Add(this.lblDetBrand);
            this.panelDetails.Controls.Add(this.label2);
            this.panelDetails.Controls.Add(this.lblDetName);
            this.panelDetails.Controls.Add(this.label4);
            this.panelDetails.Controls.Add(this.picProductPreview);
            this.panelDetails.Controls.Add(this.panelDetailHeader);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(5, 10);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(282, 484);
            this.panelDetails.TabIndex = 9;
            // 
            // panelDetailHeader
            // 
            this.panelDetailHeader.BackColor = System.Drawing.Color.HotPink;
            this.panelDetailHeader.Controls.Add(this.lblDetailTitle);
            this.panelDetailHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetailHeader.Location = new System.Drawing.Point(0, 0);
            this.panelDetailHeader.Name = "panelDetailHeader";
            this.panelDetailHeader.Size = new System.Drawing.Size(280, 40);
            this.panelDetailHeader.TabIndex = 13;
            // 
            // lblDetailTitle
            // 
            this.lblDetailTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetailTitle.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblDetailTitle.ForeColor = System.Drawing.Color.White;
            this.lblDetailTitle.Location = new System.Drawing.Point(0, 0);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(280, 40);
            this.lblDetailTitle.TabIndex = 0;
            this.lblDetailTitle.Text = "PRODUCT DETAILS";
            this.lblDetailTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picProductPreview
            // 
            this.picProductPreview.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picProductPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProductPreview.Location = new System.Drawing.Point(40, 60);
            this.picProductPreview.Name = "picProductPreview";
            this.picProductPreview.Size = new System.Drawing.Size(200, 200);
            this.picProductPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProductPreview.TabIndex = 0;
            this.picProductPreview.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(15, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name:";
            // 
            // lblDetName
            // 
            this.lblDetName.AutoSize = true;
            this.lblDetName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetName.Location = new System.Drawing.Point(75, 288);
            this.lblDetName.Name = "lblDetName";
            this.lblDetName.Size = new System.Drawing.Size(31, 23);
            this.lblDetName.TabIndex = 9;
            this.lblDetName.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(15, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Brand:";
            // 
            // lblDetBrand
            // 
            this.lblDetBrand.AutoSize = true;
            this.lblDetBrand.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetBrand.Location = new System.Drawing.Point(75, 328);
            this.lblDetBrand.Name = "lblDetBrand";
            this.lblDetBrand.Size = new System.Drawing.Size(31, 23);
            this.lblDetBrand.TabIndex = 10;
            this.lblDetBrand.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(15, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price:";
            // 
            // lblDetPrice
            // 
            this.lblDetPrice.AutoSize = true;
            this.lblDetPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDetPrice.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblDetPrice.Location = new System.Drawing.Point(75, 368);
            this.lblDetPrice.Name = "lblDetPrice";
            this.lblDetPrice.Size = new System.Drawing.Size(31, 23);
            this.lblDetPrice.TabIndex = 11;
            this.lblDetPrice.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(15, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stock:";
            // 
            // lblDetStock
            // 
            this.lblDetStock.AutoSize = true;
            this.lblDetStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDetStock.ForeColor = System.Drawing.Color.HotPink;
            this.lblDetStock.Location = new System.Drawing.Point(75, 408);
            this.lblDetStock.Name = "lblDetStock";
            this.lblDetStock.Size = new System.Drawing.Size(31, 23);
            this.lblDetStock.TabIndex = 12;
            this.lblDetStock.Text = "---";
            // 
            // UC_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.panelTop);
            this.Name = "UC_Products";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.panelDetailHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProductPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Panel panelDetailHeader;
        private System.Windows.Forms.Label lblDetailTitle;
        private System.Windows.Forms.PictureBox picProductPreview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDetName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDetBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDetPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDetStock;
    }
}