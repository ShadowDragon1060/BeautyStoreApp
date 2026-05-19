namespace BeautyStoreApp
{
    partial class UC_Classifications
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
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.panelCatMain = new System.Windows.Forms.Panel();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.panelCatHeader = new System.Windows.Forms.Panel();
            this.lblCatHeader = new System.Windows.Forms.Label();
            this.panelCatControls = new System.Windows.Forms.Panel();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblCatName = new System.Windows.Forms.Label();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.panelBrandMain = new System.Windows.Forms.Panel();
            this.dgvBrands = new System.Windows.Forms.DataGridView();
            this.panelBrandHeader = new System.Windows.Forms.Panel();
            this.lblBrandHeader = new System.Windows.Forms.Label();
            this.panelBrandControls = new System.Windows.Forms.Panel();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.btnRemoveBrand = new System.Windows.Forms.Button();
            this.btnEditBrand = new System.Windows.Forms.Button();
            this.btnAddBrand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.panelCatMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.panelCatHeader.SuspendLayout();
            this.panelCatControls.SuspendLayout();
            this.panelBrandMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrands)).BeginInit();
            this.panelBrandHeader.SuspendLayout();
            this.panelBrandControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.IsSplitterFixed = true;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.panelCatMain);
            this.splitMain.Panel1.Padding = new System.Windows.Forms.Padding(15, 15, 10, 15);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.panelBrandMain);
            this.splitMain.Panel2.Padding = new System.Windows.Forms.Padding(10, 15, 15, 15);
            this.splitMain.Size = new System.Drawing.Size(986, 584);
            this.splitMain.SplitterDistance = 493;
            this.splitMain.TabIndex = 0;
            // 
            // panelCatMain
            // 
            this.panelCatMain.BackColor = System.Drawing.Color.White;
            this.panelCatMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCatMain.Controls.Add(this.dgvCategories);
            this.panelCatMain.Controls.Add(this.panelCatControls);
            this.panelCatMain.Controls.Add(this.panelCatHeader);
            this.panelCatMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCatMain.Location = new System.Drawing.Point(15, 15);
            this.panelCatMain.Name = "panelCatMain";
            this.panelCatMain.Size = new System.Drawing.Size(468, 554);
            this.panelCatMain.TabIndex = 0;
            // 
            // dgvCategories
            // 
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategories.Location = new System.Drawing.Point(0, 50);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowHeadersWidth = 51;
            this.dgvCategories.RowTemplate.Height = 24;
            this.dgvCategories.Size = new System.Drawing.Size(466, 382);
            this.dgvCategories.TabIndex = 2;
            // 
            // panelCatHeader
            // 
            this.panelCatHeader.BackColor = System.Drawing.Color.HotPink;
            this.panelCatHeader.Controls.Add(this.lblCatHeader);
            this.panelCatHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCatHeader.Location = new System.Drawing.Point(0, 0);
            this.panelCatHeader.Name = "panelCatHeader";
            this.panelCatHeader.Size = new System.Drawing.Size(466, 50);
            this.panelCatHeader.TabIndex = 0;
            // 
            // lblCatHeader
            // 
            this.lblCatHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCatHeader.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblCatHeader.ForeColor = System.Drawing.Color.White;
            this.lblCatHeader.Location = new System.Drawing.Point(0, 0);
            this.lblCatHeader.Name = "lblCatHeader";
            this.lblCatHeader.Size = new System.Drawing.Size(466, 50);
            this.lblCatHeader.TabIndex = 0;
            this.lblCatHeader.Text = "CATEGORIES";
            this.lblCatHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCatControls
            // 
            this.panelCatControls.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCatControls.Controls.Add(this.txtCategory);
            this.panelCatControls.Controls.Add(this.lblCatName);
            this.panelCatControls.Controls.Add(this.btnRemoveCategory);
            this.panelCatControls.Controls.Add(this.btnEditCategory);
            this.panelCatControls.Controls.Add(this.btnAddCategory);
            this.panelCatControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCatControls.Location = new System.Drawing.Point(0, 432);
            this.panelCatControls.Name = "panelCatControls";
            this.panelCatControls.Size = new System.Drawing.Size(466, 120);
            this.panelCatControls.TabIndex = 1;
            // 
            // txtCategory
            // 
            this.txtCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCategory.Location = new System.Drawing.Point(80, 20);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(360, 32);
            this.txtCategory.TabIndex = 4;
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCatName.ForeColor = System.Drawing.Color.DimGray;
            this.lblCatName.Location = new System.Drawing.Point(15, 25);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(62, 23);
            this.lblCatName.TabIndex = 3;
            this.lblCatName.Text = "Name:";
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoveCategory.Location = new System.Drawing.Point(340, 65);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(100, 40);
            this.btnRemoveCategory.TabIndex = 2;
            this.btnRemoveCategory.Text = "Remove";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditCategory.Location = new System.Drawing.Point(230, 65);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(100, 40);
            this.btnEditCategory.TabIndex = 1;
            this.btnEditCategory.Text = "Update";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddCategory.Location = new System.Drawing.Point(120, 65);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(100, 40);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "Add New";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // panelBrandMain
            // 
            this.panelBrandMain.BackColor = System.Drawing.Color.White;
            this.panelBrandMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBrandMain.Controls.Add(this.dgvBrands);
            this.panelBrandMain.Controls.Add(this.panelBrandControls);
            this.panelBrandMain.Controls.Add(this.panelBrandHeader);
            this.panelBrandMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBrandMain.Location = new System.Drawing.Point(10, 15);
            this.panelBrandMain.Name = "panelBrandMain";
            this.panelBrandMain.Size = new System.Drawing.Size(464, 554);
            this.panelBrandMain.TabIndex = 1;
            // 
            // dgvBrands
            // 
            this.dgvBrands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBrands.Location = new System.Drawing.Point(0, 50);
            this.dgvBrands.Name = "dgvBrands";
            this.dgvBrands.RowHeadersWidth = 51;
            this.dgvBrands.RowTemplate.Height = 24;
            this.dgvBrands.Size = new System.Drawing.Size(462, 382);
            this.dgvBrands.TabIndex = 3;
            // 
            // panelBrandHeader
            // 
            this.panelBrandHeader.BackColor = System.Drawing.Color.HotPink;
            this.panelBrandHeader.Controls.Add(this.lblBrandHeader);
            this.panelBrandHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBrandHeader.Location = new System.Drawing.Point(0, 0);
            this.panelBrandHeader.Name = "panelBrandHeader";
            this.panelBrandHeader.Size = new System.Drawing.Size(462, 50);
            this.panelBrandHeader.TabIndex = 1;
            // 
            // lblBrandHeader
            // 
            this.lblBrandHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBrandHeader.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblBrandHeader.ForeColor = System.Drawing.Color.White;
            this.lblBrandHeader.Location = new System.Drawing.Point(0, 0);
            this.lblBrandHeader.Name = "lblBrandHeader";
            this.lblBrandHeader.Size = new System.Drawing.Size(462, 50);
            this.lblBrandHeader.TabIndex = 1;
            this.lblBrandHeader.Text = "BRANDS";
            this.lblBrandHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBrandControls
            // 
            this.panelBrandControls.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBrandControls.Controls.Add(this.txtBrand);
            this.panelBrandControls.Controls.Add(this.lblBrandName);
            this.panelBrandControls.Controls.Add(this.btnRemoveBrand);
            this.panelBrandControls.Controls.Add(this.btnEditBrand);
            this.panelBrandControls.Controls.Add(this.btnAddBrand);
            this.panelBrandControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBrandControls.Location = new System.Drawing.Point(0, 432);
            this.panelBrandControls.Name = "panelBrandControls";
            this.panelBrandControls.Size = new System.Drawing.Size(462, 120);
            this.panelBrandControls.TabIndex = 2;
            // 
            // txtBrand
            // 
            this.txtBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBrand.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBrand.Location = new System.Drawing.Point(80, 20);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(360, 32);
            this.txtBrand.TabIndex = 9;
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBrandName.ForeColor = System.Drawing.Color.DimGray;
            this.lblBrandName.Location = new System.Drawing.Point(15, 25);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(62, 23);
            this.lblBrandName.TabIndex = 8;
            this.lblBrandName.Text = "Name:";
            // 
            // btnRemoveBrand
            // 
            this.btnRemoveBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveBrand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoveBrand.Location = new System.Drawing.Point(340, 65);
            this.btnRemoveBrand.Name = "btnRemoveBrand";
            this.btnRemoveBrand.Size = new System.Drawing.Size(100, 40);
            this.btnRemoveBrand.TabIndex = 7;
            this.btnRemoveBrand.Text = "Remove";
            this.btnRemoveBrand.UseVisualStyleBackColor = true;
            // 
            // btnEditBrand
            // 
            this.btnEditBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditBrand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditBrand.Location = new System.Drawing.Point(230, 65);
            this.btnEditBrand.Name = "btnEditBrand";
            this.btnEditBrand.Size = new System.Drawing.Size(100, 40);
            this.btnEditBrand.TabIndex = 6;
            this.btnEditBrand.Text = "Update";
            this.btnEditBrand.UseVisualStyleBackColor = true;
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBrand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddBrand.Location = new System.Drawing.Point(120, 65);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(100, 40);
            this.btnAddBrand.TabIndex = 5;
            this.btnAddBrand.Text = "Add New";
            this.btnAddBrand.UseVisualStyleBackColor = true;
            // 
            // UC_Classifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.splitMain);
            this.Name = "UC_Classifications";
            this.Size = new System.Drawing.Size(986, 584);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.panelCatMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.panelCatHeader.ResumeLayout(false);
            this.panelCatControls.ResumeLayout(false);
            this.panelCatControls.PerformLayout();
            this.panelBrandMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrands)).EndInit();
            this.panelBrandHeader.ResumeLayout(false);
            this.panelBrandControls.ResumeLayout(false);
            this.panelBrandControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Panel panelCatMain;
        private System.Windows.Forms.Panel panelCatHeader;
        private System.Windows.Forms.Label lblCatHeader;
        private System.Windows.Forms.Panel panelCatControls;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Panel panelBrandMain;
        private System.Windows.Forms.DataGridView dgvBrands;
        private System.Windows.Forms.Panel panelBrandControls;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.Button btnRemoveBrand;
        private System.Windows.Forms.Button btnEditBrand;
        private System.Windows.Forms.Button btnAddBrand;
        private System.Windows.Forms.Panel panelBrandHeader;
        private System.Windows.Forms.Label lblBrandHeader;
    }
}