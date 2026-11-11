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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsset)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAsset
            // 
            this.dgvAsset.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvAsset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsset.Location = new System.Drawing.Point(18, 129);
            this.dgvAsset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAsset.Name = "dgvAsset";
            this.dgvAsset.RowHeadersWidth = 62;
            this.dgvAsset.Size = new System.Drawing.Size(1164, 508);
            this.dgvAsset.TabIndex = 0;
            this.dgvAsset.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsset_CellContentClick);
            // 
            // frmAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CIS_3309_Term_Project.Properties.Resources.BlueGradientBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 1073);
            this.Controls.Add(this.dgvAsset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAsset";
            this.ShowIcon = false;
            this.Text = "Asset Manager System - Assets";
            this.Load += new System.EventHandler(this.frmAsset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAsset;
    }
}