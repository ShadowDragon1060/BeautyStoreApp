namespace BeautyStoreApp
{
    partial class UC_Settings
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
            this.panelAccountCard = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.panelAccountControls = new System.Windows.Forms.Panel();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemoveAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.panelAccountHeader = new System.Windows.Forms.Panel();
            this.lblAccountHeader = new System.Windows.Forms.Label();
            this.splitRight = new System.Windows.Forms.SplitContainer();
            this.panelSecurityCard = new System.Windows.Forms.Panel();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.panelSecurityHeader = new System.Windows.Forms.Panel();
            this.lblSecurityHeader = new System.Windows.Forms.Label();
            this.panelToolsCard = new System.Windows.Forms.Panel();
            this.btnExportSales = new System.Windows.Forms.Button();
            this.btnExportInventory = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelToolsHeader = new System.Windows.Forms.Panel();
            this.lblToolsHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.panelAccountCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panelAccountControls.SuspendLayout();
            this.panelAccountHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).BeginInit();
            this.splitRight.Panel1.SuspendLayout();
            this.splitRight.Panel2.SuspendLayout();
            this.splitRight.SuspendLayout();
            this.panelSecurityCard.SuspendLayout();
            this.panelSecurityHeader.SuspendLayout();
            this.panelToolsCard.SuspendLayout();
            this.panelToolsHeader.SuspendLayout();
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
            this.splitMain.Panel1.Controls.Add(this.panelAccountCard);
            this.splitMain.Panel1.Padding = new System.Windows.Forms.Padding(15, 15, 5, 15);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.splitRight);
            this.splitMain.Panel2.Padding = new System.Windows.Forms.Padding(5, 15, 15, 15);
            this.splitMain.Size = new System.Drawing.Size(986, 584);
            this.splitMain.SplitterDistance = 580;
            this.splitMain.TabIndex = 0;
            // 
            // panelAccountCard
            // 
            this.panelAccountCard.BackColor = System.Drawing.Color.White;
            this.panelAccountCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAccountCard.Controls.Add(this.dgvUsers);
            this.panelAccountCard.Controls.Add(this.panelAccountControls);
            this.panelAccountCard.Controls.Add(this.panelAccountHeader);
            this.panelAccountCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAccountCard.Location = new System.Drawing.Point(15, 15);
            this.panelAccountCard.Name = "panelAccountCard";
            this.panelAccountCard.Size = new System.Drawing.Size(560, 554);
            this.panelAccountCard.TabIndex = 0;
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(0, 45);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.Size = new System.Drawing.Size(558, 357);
            this.dgvUsers.TabIndex = 7;
            // 
            // panelAccountControls
            // 
            this.panelAccountControls.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAccountControls.Controls.Add(this.cmbRole);
            this.panelAccountControls.Controls.Add(this.txtPassword);
            this.panelAccountControls.Controls.Add(this.txtAccountName);
            this.panelAccountControls.Controls.Add(this.label3);
            this.panelAccountControls.Controls.Add(this.label2);
            this.panelAccountControls.Controls.Add(this.label4);
            this.panelAccountControls.Controls.Add(this.btnRemoveAccount);
            this.panelAccountControls.Controls.Add(this.btnEditAccount);
            this.panelAccountControls.Controls.Add(this.btnAddAccount);
            this.panelAccountControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAccountControls.Location = new System.Drawing.Point(0, 402);
            this.panelAccountControls.Name = "panelAccountControls";
            this.panelAccountControls.Size = new System.Drawing.Size(558, 150);
            this.panelAccountControls.TabIndex = 1;
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(380, 20);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(150, 31);
            this.cmbRole.TabIndex = 13;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(100, 60);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 30);
            this.txtPassword.TabIndex = 12;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAccountName.Location = new System.Drawing.Point(100, 20);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(200, 30);
            this.txtAccountName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(320, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Role:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(15, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name:";
            // 
            // btnRemoveAccount
            // 
            this.btnRemoveAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoveAccount.Location = new System.Drawing.Point(430, 95);
            this.btnRemoveAccount.Name = "btnRemoveAccount";
            this.btnRemoveAccount.Size = new System.Drawing.Size(100, 40);
            this.btnRemoveAccount.TabIndex = 6;
            this.btnRemoveAccount.Text = "Remove";
            this.btnRemoveAccount.UseVisualStyleBackColor = true;
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditAccount.Location = new System.Drawing.Point(320, 95);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(100, 40);
            this.btnEditAccount.TabIndex = 5;
            this.btnEditAccount.Text = "Update";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddAccount.Location = new System.Drawing.Point(210, 95);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(100, 40);
            this.btnAddAccount.TabIndex = 3;
            this.btnAddAccount.Text = "Add New";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // panelAccountHeader
            // 
            this.panelAccountHeader.BackColor = System.Drawing.Color.HotPink;
            this.panelAccountHeader.Controls.Add(this.lblAccountHeader);
            this.panelAccountHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAccountHeader.Location = new System.Drawing.Point(0, 0);
            this.panelAccountHeader.Name = "panelAccountHeader";
            this.panelAccountHeader.Size = new System.Drawing.Size(558, 45);
            this.panelAccountHeader.TabIndex = 0;
            // 
            // lblAccountHeader
            // 
            this.lblAccountHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccountHeader.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblAccountHeader.ForeColor = System.Drawing.Color.White;
            this.lblAccountHeader.Location = new System.Drawing.Point(0, 0);
            this.lblAccountHeader.Name = "lblAccountHeader";
            this.lblAccountHeader.Size = new System.Drawing.Size(558, 45);
            this.lblAccountHeader.TabIndex = 0;
            this.lblAccountHeader.Text = "ACCOUNT MANAGEMENT";
            this.lblAccountHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitRight
            // 
            this.splitRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitRight.IsSplitterFixed = true;
            this.splitRight.Location = new System.Drawing.Point(5, 15);
            this.splitRight.Name = "splitRight";
            this.splitRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitRight.Panel1
            // 
            this.splitRight.Panel1.Controls.Add(this.panelSecurityCard);
            this.splitRight.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // splitRight.Panel2
            // 
            this.splitRight.Panel2.Controls.Add(this.panelToolsCard);
            this.splitRight.Panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.splitRight.Size = new System.Drawing.Size(382, 554);
            this.splitRight.SplitterDistance = 267;
            this.splitRight.TabIndex = 0;
            // 
            // panelSecurityCard
            // 
            this.panelSecurityCard.BackColor = System.Drawing.Color.White;
            this.panelSecurityCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSecurityCard.Controls.Add(this.txtNewPassword);
            this.panelSecurityCard.Controls.Add(this.txtOldPassword);
            this.panelSecurityCard.Controls.Add(this.label12);
            this.panelSecurityCard.Controls.Add(this.label13);
            this.panelSecurityCard.Controls.Add(this.btnChangePassword);
            this.panelSecurityCard.Controls.Add(this.panelSecurityHeader);
            this.panelSecurityCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSecurityCard.Location = new System.Drawing.Point(0, 0);
            this.panelSecurityCard.Name = "panelSecurityCard";
            this.panelSecurityCard.Size = new System.Drawing.Size(382, 257);
            this.panelSecurityCard.TabIndex = 0;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewPassword.Location = new System.Drawing.Point(145, 125);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(200, 30);
            this.txtNewPassword.TabIndex = 20;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOldPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOldPassword.Location = new System.Drawing.Point(145, 75);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(200, 30);
            this.txtOldPassword.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(20, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "New Password:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(20, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "Old Password:";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChangePassword.Location = new System.Drawing.Point(80, 185);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(220, 45);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            // 
            // panelSecurityHeader
            // 
            this.panelSecurityHeader.BackColor = System.Drawing.Color.HotPink;
            this.panelSecurityHeader.Controls.Add(this.lblSecurityHeader);
            this.panelSecurityHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSecurityHeader.Location = new System.Drawing.Point(0, 0);
            this.panelSecurityHeader.Name = "panelSecurityHeader";
            this.panelSecurityHeader.Size = new System.Drawing.Size(380, 45);
            this.panelSecurityHeader.TabIndex = 1;
            // 
            // lblSecurityHeader
            // 
            this.lblSecurityHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSecurityHeader.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblSecurityHeader.ForeColor = System.Drawing.Color.White;
            this.lblSecurityHeader.Location = new System.Drawing.Point(0, 0);
            this.lblSecurityHeader.Name = "lblSecurityHeader";
            this.lblSecurityHeader.Size = new System.Drawing.Size(380, 45);
            this.lblSecurityHeader.TabIndex = 0;
            this.lblSecurityHeader.Text = "SECURITY SETTINGS";
            this.lblSecurityHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelToolsCard
            // 
            this.panelToolsCard.BackColor = System.Drawing.Color.White;
            this.panelToolsCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelToolsCard.Controls.Add(this.btnExportSales);
            this.panelToolsCard.Controls.Add(this.btnExportInventory);
            this.panelToolsCard.Controls.Add(this.label9);
            this.panelToolsCard.Controls.Add(this.label10);
            this.panelToolsCard.Controls.Add(this.panelToolsHeader);
            this.panelToolsCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelToolsCard.Location = new System.Drawing.Point(0, 10);
            this.panelToolsCard.Name = "panelToolsCard";
            this.panelToolsCard.Size = new System.Drawing.Size(382, 273);
            this.panelToolsCard.TabIndex = 1;
            // 
            // btnExportSales
            // 
            this.btnExportSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportSales.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportSales.Location = new System.Drawing.Point(225, 160);
            this.btnExportSales.Name = "btnExportSales";
            this.btnExportSales.Size = new System.Drawing.Size(120, 40);
            this.btnExportSales.TabIndex = 18;
            this.btnExportSales.Text = "Export";
            this.btnExportSales.UseVisualStyleBackColor = true;
            // 
            // btnExportInventory
            // 
            this.btnExportInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportInventory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportInventory.Location = new System.Drawing.Point(225, 90);
            this.btnExportInventory.Name = "btnExportInventory";
            this.btnExportInventory.Size = new System.Drawing.Size(120, 40);
            this.btnExportInventory.TabIndex = 17;
            this.btnExportInventory.Text = "Export";
            this.btnExportInventory.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(40, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Export Sales to CSV:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(40, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Export Inv. to CSV:";
            // 
            // panelToolsHeader
            // 
            this.panelToolsHeader.BackColor = System.Drawing.Color.HotPink;
            this.panelToolsHeader.Controls.Add(this.lblToolsHeader);
            this.panelToolsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelToolsHeader.Name = "panelToolsHeader";
            this.panelToolsHeader.Size = new System.Drawing.Size(380, 45);
            this.panelToolsHeader.TabIndex = 2;
            // 
            // lblToolsHeader
            // 
            this.lblToolsHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToolsHeader.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblToolsHeader.ForeColor = System.Drawing.Color.White;
            this.lblToolsHeader.Location = new System.Drawing.Point(0, 0);
            this.lblToolsHeader.Name = "lblToolsHeader";
            this.lblToolsHeader.Size = new System.Drawing.Size(380, 45);
            this.lblToolsHeader.TabIndex = 0;
            this.lblToolsHeader.Text = "DATA EXPORT TOOLS";
            this.lblToolsHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.splitMain);
            this.Name = "UC_Settings";
            this.Size = new System.Drawing.Size(986, 584);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.panelAccountCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panelAccountControls.ResumeLayout(false);
            this.panelAccountControls.PerformLayout();
            this.panelAccountHeader.ResumeLayout(false);
            this.splitRight.Panel1.ResumeLayout(false);
            this.splitRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).EndInit();
            this.splitRight.ResumeLayout(false);
            this.panelSecurityCard.ResumeLayout(false);
            this.panelSecurityCard.PerformLayout();
            this.panelSecurityHeader.ResumeLayout(false);
            this.panelToolsCard.ResumeLayout(false);
            this.panelToolsCard.PerformLayout();
            this.panelToolsHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Panel panelAccountCard;
        private System.Windows.Forms.Panel panelAccountHeader;
        private System.Windows.Forms.Label lblAccountHeader;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel panelAccountControls;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnRemoveAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.SplitContainer splitRight;
        private System.Windows.Forms.Panel panelSecurityCard;
        private System.Windows.Forms.Panel panelSecurityHeader;
        private System.Windows.Forms.Label lblSecurityHeader;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Panel panelToolsCard;
        private System.Windows.Forms.Panel panelToolsHeader;
        private System.Windows.Forms.Label lblToolsHeader;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExportInventory;
        private System.Windows.Forms.Button btnExportSales;
    }
}