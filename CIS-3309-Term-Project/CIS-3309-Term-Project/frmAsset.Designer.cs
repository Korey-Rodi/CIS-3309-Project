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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsset)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAsset
            // 
            this.dgvAsset.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvAsset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsset.Location = new System.Drawing.Point(80, 100);
            this.dgvAsset.Name = "dgvAsset";
            this.dgvAsset.RowHeadersWidth = 62;
            this.dgvAsset.Size = new System.Drawing.Size(776, 330);
            this.dgvAsset.TabIndex = 0;
            this.dgvAsset.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsset_CellContentClick);
            // 
            // btnCreateAsset
            // 
            this.btnCreateAsset.Location = new System.Drawing.Point(274, 534);
            this.btnCreateAsset.Name = "btnCreateAsset";
            this.btnCreateAsset.Size = new System.Drawing.Size(208, 84);
            this.btnCreateAsset.TabIndex = 1;
            this.btnCreateAsset.Text = "Create";
            this.btnCreateAsset.UseVisualStyleBackColor = true;
            this.btnCreateAsset.Click += new System.EventHandler(this.btnCreateAsset_Click);
            // 
            // btnViewAsset
            // 
            this.btnViewAsset.Location = new System.Drawing.Point(511, 534);
            this.btnViewAsset.Name = "btnViewAsset";
            this.btnViewAsset.Size = new System.Drawing.Size(208, 84);
            this.btnViewAsset.TabIndex = 2;
            this.btnViewAsset.Text = "View";
            this.btnViewAsset.UseVisualStyleBackColor = true;
            this.btnViewAsset.Click += new System.EventHandler(this.btnViewAsset_Click);
            // 
            // frmAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CIS_3309_Term_Project.Properties.Resources.BlueGradientBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 697);
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

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAsset;
        private System.Windows.Forms.Button btnCreateAsset;
        private System.Windows.Forms.Button btnViewAsset;
    }
}