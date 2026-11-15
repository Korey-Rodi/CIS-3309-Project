namespace CIS_3309_Term_Project
{
    partial class frmUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.lblNewForms = new System.Windows.Forms.Label();
            this.lblNotice = new System.Windows.Forms.Label();
            this.btnLoadUsers = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboSearchAsset = new System.Windows.Forms.ComboBox();
            this.txtSearchAsset = new System.Windows.Forms.TextBox();
            this.btnSearchAsset = new System.Windows.Forms.Button();
            this.lblAssetSearch = new System.Windows.Forms.Label();
            this.btnViewAsset = new System.Windows.Forms.Button();
            this.btnCreateAsset = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(14, 52);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 62;
            this.dgvUser.Size = new System.Drawing.Size(948, 404);
            this.dgvUser.TabIndex = 0;
            // 
            // lblNewForms
            // 
            this.lblNewForms.AutoSize = true;
            this.lblNewForms.BackColor = System.Drawing.Color.Transparent;
            this.lblNewForms.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewForms.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNewForms.Location = new System.Drawing.Point(11, 636);
            this.lblNewForms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewForms.Name = "lblNewForms";
            this.lblNewForms.Size = new System.Drawing.Size(283, 26);
            this.lblNewForms.TabIndex = 115;
            this.lblNewForms.Text = "Add a new asset to the systems by hitting \"Create\"\r\nView an asset\'s info by selec" +
    "ting it and hitting \"View\"";
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.BackColor = System.Drawing.Color.Transparent;
            this.lblNotice.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNotice.Location = new System.Drawing.Point(35, 548);
            this.lblNotice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(239, 17);
            this.lblNotice.TabIndex = 114;
            this.lblNotice.Text = "Search by each category within users:";
            // 
            // btnLoadUsers
            // 
            this.btnLoadUsers.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadUsers.Location = new System.Drawing.Point(496, 571);
            this.btnLoadUsers.Name = "btnLoadUsers";
            this.btnLoadUsers.Size = new System.Drawing.Size(123, 33);
            this.btnLoadUsers.TabIndex = 111;
            this.btnLoadUsers.Text = "Load All";
            this.btnLoadUsers.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(296, 540);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 17);
            this.lblName.TabIndex = 110;
            this.lblName.Text = "Name:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCategory.Location = new System.Drawing.Point(296, 497);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(64, 17);
            this.lblCategory.TabIndex = 109;
            this.lblCategory.Text = "Category:";
            // 
            // cboSearchAsset
            // 
            this.cboSearchAsset.FormattingEnabled = true;
            this.cboSearchAsset.Location = new System.Drawing.Point(365, 493);
            this.cboSearchAsset.Name = "cboSearchAsset";
            this.cboSearchAsset.Size = new System.Drawing.Size(254, 21);
            this.cboSearchAsset.TabIndex = 108;
            // 
            // txtSearchAsset
            // 
            this.txtSearchAsset.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAsset.Location = new System.Drawing.Point(365, 535);
            this.txtSearchAsset.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchAsset.Name = "txtSearchAsset";
            this.txtSearchAsset.Size = new System.Drawing.Size(254, 22);
            this.txtSearchAsset.TabIndex = 107;
            // 
            // btnSearchAsset
            // 
            this.btnSearchAsset.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAsset.Location = new System.Drawing.Point(365, 571);
            this.btnSearchAsset.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchAsset.Name = "btnSearchAsset";
            this.btnSearchAsset.Size = new System.Drawing.Size(125, 33);
            this.btnSearchAsset.TabIndex = 106;
            this.btnSearchAsset.Text = "Search";
            this.btnSearchAsset.UseVisualStyleBackColor = true;
            // 
            // lblAssetSearch
            // 
            this.lblAssetSearch.AutoSize = true;
            this.lblAssetSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblAssetSearch.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAssetSearch.Location = new System.Drawing.Point(411, 459);
            this.lblAssetSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAssetSearch.Name = "lblAssetSearch";
            this.lblAssetSearch.Size = new System.Drawing.Size(161, 21);
            this.lblAssetSearch.TabIndex = 105;
            this.lblAssetSearch.Text = "Search by Category:";
            // 
            // btnViewAsset
            // 
            this.btnViewAsset.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAsset.Location = new System.Drawing.Point(496, 622);
            this.btnViewAsset.Name = "btnViewAsset";
            this.btnViewAsset.Size = new System.Drawing.Size(174, 65);
            this.btnViewAsset.TabIndex = 104;
            this.btnViewAsset.Text = "View";
            this.btnViewAsset.UseVisualStyleBackColor = true;
            // 
            // btnCreateAsset
            // 
            this.btnCreateAsset.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAsset.Location = new System.Drawing.Point(316, 622);
            this.btnCreateAsset.Name = "btnCreateAsset";
            this.btnCreateAsset.Size = new System.Drawing.Size(174, 65);
            this.btnCreateAsset.TabIndex = 103;
            this.btnCreateAsset.Text = "Create";
            this.btnCreateAsset.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(420, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(138, 32);
            this.lblTitle.TabIndex = 116;
            this.lblTitle.Text = "Users View";
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 697);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNewForms);
            this.Controls.Add(this.lblNotice);
            this.Controls.Add(this.btnLoadUsers);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cboSearchAsset);
            this.Controls.Add(this.txtSearchAsset);
            this.Controls.Add(this.btnSearchAsset);
            this.Controls.Add(this.lblAssetSearch);
            this.Controls.Add(this.btnViewAsset);
            this.Controls.Add(this.btnCreateAsset);
            this.Controls.Add(this.dgvUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmUser";
            this.ShowIcon = false;
            this.Text = "Asset Management System - Users";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Label lblNewForms;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.Button btnLoadUsers;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboSearchAsset;
        private System.Windows.Forms.TextBox txtSearchAsset;
        private System.Windows.Forms.Button btnSearchAsset;
        private System.Windows.Forms.Label lblAssetSearch;
        private System.Windows.Forms.Button btnViewAsset;
        private System.Windows.Forms.Button btnCreateAsset;
        private System.Windows.Forms.Label lblTitle;
    }
}