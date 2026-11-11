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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.miHome = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miAsset = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAssetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miUser = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fpPieChart = new ScottPlot.WinForms.FormsPlot();
            this.fpBarChartAssetsByState = new ScottPlot.WinForms.FormsPlot();
            this.fpBarChartUsersByDept = new ScottPlot.WinForms.FormsPlot();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblAssetsByState = new System.Windows.Forms.Label();
            this.lblUsersByDept = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTotalUsersTitle = new System.Windows.Forms.Label();
            this.lblTotalAssetsTitle = new System.Windows.Forms.Label();
            this.lblDashboardIntro = new System.Windows.Forms.Label();
            this.lblTotalUsersData = new System.Windows.Forms.Label();
            this.lblTotalAssetsData = new System.Windows.Forms.Label();
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
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // miAsset
            // 
            this.miAsset.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAssetsToolStripMenuItem});
            this.miAsset.Name = "miAsset";
            this.miAsset.Size = new System.Drawing.Size(71, 32);
            this.miAsset.Text = "Asset";
            // 
            // viewAssetsToolStripMenuItem
            // 
            this.viewAssetsToolStripMenuItem.Name = "viewAssetsToolStripMenuItem";
            this.viewAssetsToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.viewAssetsToolStripMenuItem.Text = "View Assets";
            this.viewAssetsToolStripMenuItem.Click += new System.EventHandler(this.viewAssetsToolStripMenuItem_Click);
            // 
            // miUser
            // 
            this.miUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewUserToolStripMenuItem});
            this.miUser.Name = "miUser";
            this.miUser.Size = new System.Drawing.Size(63, 32);
            this.miUser.Text = "User";
            // 
            // viewUserToolStripMenuItem
            // 
            this.viewUserToolStripMenuItem.Name = "viewUserToolStripMenuItem";
            this.viewUserToolStripMenuItem.Size = new System.Drawing.Size(199, 34);
            this.viewUserToolStripMenuItem.Text = "View Users";
            this.viewUserToolStripMenuItem.Click += new System.EventHandler(this.viewUsersToolStripMenuItem_Click);
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
            // viewProfileToolStripMenuItem
            // 
            this.viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(216, 36);
            this.viewProfileToolStripMenuItem.Text = "View Profile";
            this.viewProfileToolStripMenuItem.Click += new System.EventHandler(this.viewProfileToolStripMenuItem_Click);
            // 
            // fpPieChart
            // 
            this.fpPieChart.Location = new System.Drawing.Point(938, 75);
            this.fpPieChart.Name = "fpPieChart";
            this.fpPieChart.Size = new System.Drawing.Size(489, 425);
            this.fpPieChart.TabIndex = 1;
            // 
            // fpBarChartAssetsByState
            // 
            this.fpBarChartAssetsByState.Location = new System.Drawing.Point(766, 655);
            this.fpBarChartAssetsByState.Name = "fpBarChartAssetsByState";
            this.fpBarChartAssetsByState.Size = new System.Drawing.Size(678, 295);
            this.fpBarChartAssetsByState.TabIndex = 2;
            // 
            // fpBarChartUsersByDept
            // 
            this.fpBarChartUsersByDept.Location = new System.Drawing.Point(30, 655);
            this.fpBarChartUsersByDept.Name = "fpBarChartUsersByDept";
            this.fpBarChartUsersByDept.Size = new System.Drawing.Size(678, 295);
            this.fpBarChartUsersByDept.TabIndex = 3;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.Transparent;
            this.lblStock.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStock.Location = new System.Drawing.Point(1142, 517);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(76, 32);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stock";
            // 
            // lblAssetsByState
            // 
            this.lblAssetsByState.AutoSize = true;
            this.lblAssetsByState.BackColor = System.Drawing.Color.Transparent;
            this.lblAssetsByState.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetsByState.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAssetsByState.Location = new System.Drawing.Point(1010, 622);
            this.lblAssetsByState.Name = "lblAssetsByState";
            this.lblAssetsByState.Size = new System.Drawing.Size(192, 32);
            this.lblAssetsByState.TabIndex = 5;
            this.lblAssetsByState.Text = "Assets By State:";
            // 
            // lblUsersByDept
            // 
            this.lblUsersByDept.AutoSize = true;
            this.lblUsersByDept.BackColor = System.Drawing.Color.Transparent;
            this.lblUsersByDept.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersByDept.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsersByDept.Location = new System.Drawing.Point(240, 622);
            this.lblUsersByDept.Name = "lblUsersByDept";
            this.lblUsersByDept.Size = new System.Drawing.Size(262, 32);
            this.lblUsersByDept.TabIndex = 6;
            this.lblUsersByDept.Text = "Users By Department:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Ebrima", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(20, 49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(273, 65);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Dashboard";
            // 
            // lblTotalUsersTitle
            // 
            this.lblTotalUsersTitle.AutoSize = true;
            this.lblTotalUsersTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalUsersTitle.Font = new System.Drawing.Font("Ebrima", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsersTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalUsersTitle.Location = new System.Drawing.Point(20, 260);
            this.lblTotalUsersTitle.Name = "lblTotalUsersTitle";
            this.lblTotalUsersTitle.Size = new System.Drawing.Size(292, 65);
            this.lblTotalUsersTitle.TabIndex = 8;
            this.lblTotalUsersTitle.Text = "Total Users:";
            // 
            // lblTotalAssetsTitle
            // 
            this.lblTotalAssetsTitle.AutoSize = true;
            this.lblTotalAssetsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAssetsTitle.Font = new System.Drawing.Font("Ebrima", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAssetsTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalAssetsTitle.Location = new System.Drawing.Point(20, 435);
            this.lblTotalAssetsTitle.Name = "lblTotalAssetsTitle";
            this.lblTotalAssetsTitle.Size = new System.Drawing.Size(312, 65);
            this.lblTotalAssetsTitle.TabIndex = 9;
            this.lblTotalAssetsTitle.Text = "Total Assets:";
            // 
            // lblDashboardIntro
            // 
            this.lblDashboardIntro.AutoSize = true;
            this.lblDashboardIntro.BackColor = System.Drawing.Color.Transparent;
            this.lblDashboardIntro.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardIntro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDashboardIntro.Location = new System.Drawing.Point(26, 115);
            this.lblDashboardIntro.Name = "lblDashboardIntro";
            this.lblDashboardIntro.Size = new System.Drawing.Size(848, 140);
            this.lblDashboardIntro.TabIndex = 11;
            this.lblDashboardIntro.Text = resources.GetString("lblDashboardIntro.Text");
            // 
            // lblTotalUsersData
            // 
            this.lblTotalUsersData.AutoSize = true;
            this.lblTotalUsersData.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalUsersData.Font = new System.Drawing.Font("Ebrima", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsersData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalUsersData.Location = new System.Drawing.Point(412, 260);
            this.lblTotalUsersData.Name = "lblTotalUsersData";
            this.lblTotalUsersData.Size = new System.Drawing.Size(446, 65);
            this.lblTotalUsersData.TabIndex = 12;
            this.lblTotalUsersData.Text = "323 Managed Users";
            // 
            // lblTotalAssetsData
            // 
            this.lblTotalAssetsData.AutoSize = true;
            this.lblTotalAssetsData.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAssetsData.Font = new System.Drawing.Font("Ebrima", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAssetsData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalAssetsData.Location = new System.Drawing.Point(412, 435);
            this.lblTotalAssetsData.Name = "lblTotalAssetsData";
            this.lblTotalAssetsData.Size = new System.Drawing.Size(463, 65);
            this.lblTotalAssetsData.TabIndex = 13;
            this.lblTotalAssetsData.Text = "450 Managed Assets";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CIS_3309_Term_Project.Properties.Resources.BlueGradientBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 1069);
            this.Controls.Add(this.lblTotalAssetsData);
            this.Controls.Add(this.lblTotalUsersData);
            this.Controls.Add(this.lblDashboardIntro);
            this.Controls.Add(this.lblTotalAssetsTitle);
            this.Controls.Add(this.lblTotalUsersTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsersByDept);
            this.Controls.Add(this.lblAssetsByState);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.fpBarChartUsersByDept);
            this.Controls.Add(this.fpBarChartAssetsByState);
            this.Controls.Add(this.fpPieChart);
            this.Controls.Add(this.miHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.miHome;
            this.Name = "frmDashboard";
            this.ShowIcon = false;
            this.Text = "Asset Manager System - Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
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
        private ScottPlot.WinForms.FormsPlot fpPieChart;
        private ScottPlot.WinForms.FormsPlot fpBarChartAssetsByState;
        private ScottPlot.WinForms.FormsPlot fpBarChartUsersByDept;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblAssetsByState;
        private System.Windows.Forms.Label lblUsersByDept;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotalUsersTitle;
        private System.Windows.Forms.Label lblTotalAssetsTitle;
        private System.Windows.Forms.Label lblDashboardIntro;
        private System.Windows.Forms.Label lblTotalUsersData;
        private System.Windows.Forms.Label lblTotalAssetsData;
    }
}