namespace CIS_3309_Term_Project
{
    partial class frmDashboard
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
            this.miHome = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miAsset = new System.Windows.Forms.ToolStripMenuItem();
            this.miUser = new System.Windows.Forms.ToolStripMenuItem();
            this.miProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAssetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // miHome
            // 
            this.miHome.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.miHome.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.miHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.miAsset,
            this.miUser,
            this.miProfile});
            this.miHome.Location = new System.Drawing.Point(0, 0);
            this.miHome.Name = "miHome";
            this.miHome.Size = new System.Drawing.Size(1478, 36);
            this.miHome.TabIndex = 0;
            this.miHome.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(77, 32);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // miAsset
            // 
            this.miAsset.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAssetsToolStripMenuItem});
            this.miAsset.Name = "miAsset";
            this.miAsset.Size = new System.Drawing.Size(71, 32);
            this.miAsset.Text = "Asset";
            // 
            // miUser
            // 
            this.miUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewUserToolStripMenuItem});
            this.miUser.Name = "miUser";
            this.miUser.Size = new System.Drawing.Size(63, 32);
            this.miUser.Text = "User";
            // 
            // miProfile
            // 
            this.miProfile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.miProfile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProfileToolStripMenuItem});
            this.miProfile.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miProfile.Name = "miProfile";
            this.miProfile.Size = new System.Drawing.Size(84, 32);
            this.miProfile.Text = "Profile";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // viewAssetsToolStripMenuItem
            // 
            this.viewAssetsToolStripMenuItem.Name = "viewAssetsToolStripMenuItem";
            this.viewAssetsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.viewAssetsToolStripMenuItem.Text = "View Assets";
            // 
            // viewUserToolStripMenuItem
            // 
            this.viewUserToolStripMenuItem.Name = "viewUserToolStripMenuItem";
            this.viewUserToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.viewUserToolStripMenuItem.Text = "View User";
            // 
            // viewProfileToolStripMenuItem
            // 
            this.viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.viewProfileToolStripMenuItem.Text = "View Profile";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CIS_3309_Term_Project.Properties.Resources.BlueGradientBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 1069);
            this.Controls.Add(this.miHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.miHome;
            this.Name = "frmDashboard";
            this.ShowIcon = false;
            this.Text = "Asset Manager System - Dashboard";
            this.miHome.ResumeLayout(false);
            this.miHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip miHome;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miAsset;
        private System.Windows.Forms.ToolStripMenuItem viewAssetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miUser;
        private System.Windows.Forms.ToolStripMenuItem viewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miProfile;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
    }
}