namespace CIS_3309_Term_Project
{
    partial class frmAsset
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
            this.dgvAsset = new System.Windows.Forms.DataGridView();
            this.btnCreateAsset = new System.Windows.Forms.Button();
            this.btnViewAsset = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboSearchAsset = new System.Windows.Forms.ComboBox();
            this.txtSearchAsset = new System.Windows.Forms.TextBox();
            this.btnSearchAsset = new System.Windows.Forms.Button();
            this.btnLoadAssets = new System.Windows.Forms.Button();
            this.btnLoadInUse = new System.Windows.Forms.Button();
            this.btnInStock = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNewForms = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRecent = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsset)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAsset
            // 
            this.dgvAsset.AllowUserToAddRows = false;
            this.dgvAsset.AllowUserToDeleteRows = false;
            this.dgvAsset.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvAsset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsset.Location = new System.Drawing.Point(27, 133);
            this.dgvAsset.MultiSelect = false;
            this.dgvAsset.Name = "dgvAsset";
            this.dgvAsset.ReadOnly = true;
            this.dgvAsset.RowHeadersWidth = 62;
            this.dgvAsset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsset.Size = new System.Drawing.Size(918, 456);
            this.dgvAsset.TabIndex = 0;
            this.dgvAsset.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsset_CellContentClick);
            // 
            // btnCreateAsset
            // 
            this.btnCreateAsset.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAsset.Location = new System.Drawing.Point(285, 595);
            this.btnCreateAsset.Name = "btnCreateAsset";
            this.btnCreateAsset.Size = new System.Drawing.Size(125, 49);
            this.btnCreateAsset.TabIndex = 1;
            this.btnCreateAsset.Text = "Create";
            this.btnCreateAsset.UseVisualStyleBackColor = true;
            this.btnCreateAsset.Click += new System.EventHandler(this.btnCreateAsset_Click);
            // 
            // btnViewAsset
            // 
            this.btnViewAsset.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAsset.Location = new System.Drawing.Point(416, 595);
            this.btnViewAsset.Name = "btnViewAsset";
            this.btnViewAsset.Size = new System.Drawing.Size(125, 49);
            this.btnViewAsset.TabIndex = 2;
            this.btnViewAsset.Text = "View";
            this.btnViewAsset.UseVisualStyleBackColor = true;
            this.btnViewAsset.Click += new System.EventHandler(this.btnViewAsset_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(520, 90);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 17);
            this.lblName.TabIndex = 96;
            this.lblName.Text = "Value:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCategory.Location = new System.Drawing.Point(336, 88);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(64, 17);
            this.lblCategory.TabIndex = 95;
            this.lblCategory.Text = "Category:";
            // 
            // cboSearchAsset
            // 
            this.cboSearchAsset.FormattingEnabled = true;
            this.cboSearchAsset.Items.AddRange(new object[] {
            "ID",
            "Make",
            "Model"});
            this.cboSearchAsset.Location = new System.Drawing.Point(405, 90);
            this.cboSearchAsset.Name = "cboSearchAsset";
            this.cboSearchAsset.Size = new System.Drawing.Size(112, 21);
            this.cboSearchAsset.TabIndex = 94;
            // 
            // txtSearchAsset
            // 
            this.txtSearchAsset.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAsset.Location = new System.Drawing.Point(567, 89);
            this.txtSearchAsset.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchAsset.Name = "txtSearchAsset";
            this.txtSearchAsset.Size = new System.Drawing.Size(125, 22);
            this.txtSearchAsset.TabIndex = 93;
            // 
            // btnSearchAsset
            // 
            this.btnSearchAsset.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAsset.Location = new System.Drawing.Point(753, 82);
            this.btnSearchAsset.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchAsset.Name = "btnSearchAsset";
            this.btnSearchAsset.Size = new System.Drawing.Size(128, 31);
            this.btnSearchAsset.TabIndex = 92;
            this.btnSearchAsset.Text = "Search";
            this.btnSearchAsset.UseVisualStyleBackColor = true;
            this.btnSearchAsset.Click += new System.EventHandler(this.btnSearchAsset_Click);
            // 
            // btnLoadAssets
            // 
            this.btnLoadAssets.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadAssets.Location = new System.Drawing.Point(27, 62);
            this.btnLoadAssets.Name = "btnLoadAssets";
            this.btnLoadAssets.Size = new System.Drawing.Size(110, 31);
            this.btnLoadAssets.TabIndex = 97;
            this.btnLoadAssets.Text = "Load All";
            this.btnLoadAssets.UseVisualStyleBackColor = true;
            this.btnLoadAssets.Click += new System.EventHandler(this.btnLoadAssets_Click);
            // 
            // btnLoadInUse
            // 
            this.btnLoadInUse.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadInUse.Location = new System.Drawing.Point(143, 96);
            this.btnLoadInUse.Name = "btnLoadInUse";
            this.btnLoadInUse.Size = new System.Drawing.Size(110, 31);
            this.btnLoadInUse.TabIndex = 98;
            this.btnLoadInUse.Text = "In Use";
            this.btnLoadInUse.UseVisualStyleBackColor = true;
            this.btnLoadInUse.Click += new System.EventHandler(this.btnLoadInUse_Click);
            // 
            // btnInStock
            // 
            this.btnInStock.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInStock.Location = new System.Drawing.Point(27, 96);
            this.btnInStock.Name = "btnInStock";
            this.btnInStock.Size = new System.Drawing.Size(110, 31);
            this.btnInStock.TabIndex = 99;
            this.btnInStock.Text = "In Stock";
            this.btnInStock.UseVisualStyleBackColor = true;
            this.btnInStock.Click += new System.EventHandler(this.btnInStock_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Ebrima", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(418, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(148, 32);
            this.lblTitle.TabIndex = 100;
            this.lblTitle.Text = "Assets View";
            // 
            // lblNewForms
            // 
            this.lblNewForms.AutoSize = true;
            this.lblNewForms.BackColor = System.Drawing.Color.Transparent;
            this.lblNewForms.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewForms.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNewForms.Location = new System.Drawing.Point(14, 595);
            this.lblNewForms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewForms.Name = "lblNewForms";
            this.lblNewForms.Size = new System.Drawing.Size(266, 39);
            this.lblNewForms.TabIndex = 102;
            this.lblNewForms.Text = "Add a new asset to the systems by hitting \"Create\"\r\nView an asset\'s info by selec" +
    "ting it and hitting \"View\"\r\nDelete an asset by selecting and hitting \"Delete\"\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(448, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 17);
            this.label1.TabIndex = 115;
            this.label1.Text = "Search by each category within assets:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(547, 595);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 49);
            this.btnDelete.TabIndex = 116;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRecent
            // 
            this.btnRecent.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecent.Location = new System.Drawing.Point(143, 62);
            this.btnRecent.Name = "btnRecent";
            this.btnRecent.Size = new System.Drawing.Size(110, 31);
            this.btnRecent.TabIndex = 117;
            this.btnRecent.Text = "Load Recent";
            this.btnRecent.UseVisualStyleBackColor = true;
            this.btnRecent.Click += new System.EventHandler(this.btnRecent_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(678, 595);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(125, 49);
            this.btnCheckIn.TabIndex = 118;
            this.btnCheckIn.Text = "Check In\r\n";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(809, 595);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(125, 49);
            this.btnCheckOut.TabIndex = 119;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // frmAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::CIS_3309_Term_Project.Properties.Resources.BlueGradientBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 695);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnRecent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNewForms);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnInStock);
            this.Controls.Add(this.btnLoadInUse);
            this.Controls.Add(this.btnLoadAssets);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cboSearchAsset);
            this.Controls.Add(this.txtSearchAsset);
            this.Controls.Add(this.btnSearchAsset);
            this.Controls.Add(this.btnViewAsset);
            this.Controls.Add(this.btnCreateAsset);
            this.Controls.Add(this.dgvAsset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAsset";
            this.ShowIcon = false;
            this.Text = "Asset Manager System - Assets";
            this.Load += new System.EventHandler(this.frmAsset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAsset;
        private System.Windows.Forms.Button btnCreateAsset;
        private System.Windows.Forms.Button btnViewAsset;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboSearchAsset;
        private System.Windows.Forms.TextBox txtSearchAsset;
        private System.Windows.Forms.Button btnSearchAsset;
        private System.Windows.Forms.Button btnLoadAssets;
        private System.Windows.Forms.Button btnLoadInUse;
        private System.Windows.Forms.Button btnInStock;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNewForms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRecent;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
    }
}