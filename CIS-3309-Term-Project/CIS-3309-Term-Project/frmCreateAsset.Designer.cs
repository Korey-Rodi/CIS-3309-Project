namespace CIS_3309_Term_Project
{
    partial class frmCreateAsset
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
            this.txtRam = new System.Windows.Forms.TextBox();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.btnCreateAsset = new System.Windows.Forms.Button();
            this.chkAssetAutofill = new System.Windows.Forms.CheckBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblStorage = new System.Windows.Forms.Label();
            this.lblOS = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.txtStorage = new System.Windows.Forms.TextBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.txtImageURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbxProfile = new System.Windows.Forms.PictureBox();
            this.lblAssignedUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRam
            // 
            this.txtRam.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRam.Location = new System.Drawing.Point(423, 492);
            this.txtRam.Margin = new System.Windows.Forms.Padding(2);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(173, 22);
            this.txtRam.TabIndex = 46;
            // 
            // txtCPU
            // 
            this.txtCPU.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPU.Location = new System.Drawing.Point(423, 458);
            this.txtCPU.Margin = new System.Windows.Forms.Padding(2);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(173, 22);
            this.txtCPU.TabIndex = 45;
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.BackColor = System.Drawing.Color.Transparent;
            this.lblRAM.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRAM.Location = new System.Drawing.Point(350, 495);
            this.lblRAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(33, 13);
            this.lblRAM.TabIndex = 43;
            this.lblRAM.Text = "RAM:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblState.Location = new System.Drawing.Point(349, 326);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 42;
            this.lblState.Text = "State:";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.BackColor = System.Drawing.Color.Transparent;
            this.lblCPU.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCPU.Location = new System.Drawing.Point(350, 465);
            this.lblCPU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(30, 13);
            this.lblCPU.TabIndex = 41;
            this.lblCPU.Text = "CPU:";
            // 
            // btnCreateAsset
            // 
            this.btnCreateAsset.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAsset.Location = new System.Drawing.Point(338, 602);
            this.btnCreateAsset.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateAsset.Name = "btnCreateAsset";
            this.btnCreateAsset.Size = new System.Drawing.Size(173, 33);
            this.btnCreateAsset.TabIndex = 39;
            this.btnCreateAsset.Text = "Create";
            this.btnCreateAsset.UseVisualStyleBackColor = true;
            this.btnCreateAsset.Click += new System.EventHandler(this.btnCreateAsset_Click);
            // 
            // chkAssetAutofill
            // 
            this.chkAssetAutofill.AutoSize = true;
            this.chkAssetAutofill.BackColor = System.Drawing.Color.Transparent;
            this.chkAssetAutofill.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAssetAutofill.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkAssetAutofill.Location = new System.Drawing.Point(394, 427);
            this.chkAssetAutofill.Margin = new System.Windows.Forms.Padding(2);
            this.chkAssetAutofill.Name = "chkAssetAutofill";
            this.chkAssetAutofill.Size = new System.Drawing.Size(189, 17);
            this.chkAssetAutofill.TabIndex = 38;
            this.chkAssetAutofill.Text = "Autofill with my computer\'s specs";
            this.chkAssetAutofill.UseVisualStyleBackColor = false;
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(422, 357);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(173, 22);
            this.txtLocation.TabIndex = 37;
            // 
            // txtMake
            // 
            this.txtMake.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMake.Location = new System.Drawing.Point(422, 287);
            this.txtMake.Margin = new System.Windows.Forms.Padding(2);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(173, 22);
            this.txtMake.TabIndex = 34;
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(422, 254);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(173, 22);
            this.txtModel.TabIndex = 33;
            // 
            // lblStorage
            // 
            this.lblStorage.AutoSize = true;
            this.lblStorage.BackColor = System.Drawing.Color.Transparent;
            this.lblStorage.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStorage.Location = new System.Drawing.Point(350, 561);
            this.lblStorage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStorage.Name = "lblStorage";
            this.lblStorage.Size = new System.Drawing.Size(47, 13);
            this.lblStorage.TabIndex = 32;
            this.lblStorage.Text = "Storage:";
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.BackColor = System.Drawing.Color.Transparent;
            this.lblOS.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOS.Location = new System.Drawing.Point(350, 528);
            this.lblOS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(23, 13);
            this.lblOS.TabIndex = 30;
            this.lblOS.Text = "OS:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLocation.Location = new System.Drawing.Point(349, 360);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(50, 13);
            this.lblLocation.TabIndex = 29;
            this.lblLocation.Text = "Location:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.BackColor = System.Drawing.Color.Transparent;
            this.lblMake.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMake.Location = new System.Drawing.Point(347, 290);
            this.lblMake.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(36, 13);
            this.lblMake.TabIndex = 27;
            this.lblMake.Text = "Make:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.Color.Transparent;
            this.lblModel.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblModel.Location = new System.Drawing.Point(347, 261);
            this.lblModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(40, 13);
            this.lblModel.TabIndex = 26;
            this.lblModel.Text = "Model:";
            // 
            // cboState
            // 
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "Retired",
            "Broken",
            "In_Use",
            "In_Stock"});
            this.cboState.Location = new System.Drawing.Point(422, 323);
            this.cboState.Margin = new System.Windows.Forms.Padding(2);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(173, 21);
            this.cboState.TabIndex = 50;
            // 
            // txtOS
            // 
            this.txtOS.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOS.Location = new System.Drawing.Point(423, 525);
            this.txtOS.Margin = new System.Windows.Forms.Padding(2);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(173, 22);
            this.txtOS.TabIndex = 36;
            // 
            // txtStorage
            // 
            this.txtStorage.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStorage.Location = new System.Drawing.Point(423, 558);
            this.txtStorage.Margin = new System.Windows.Forms.Padding(2);
            this.txtStorage.Name = "txtStorage";
            this.txtStorage.Size = new System.Drawing.Size(173, 22);
            this.txtStorage.TabIndex = 51;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplay.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDisplay.Location = new System.Drawing.Point(348, 21);
            this.lblDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(315, 21);
            this.lblDisplay.TabIndex = 76;
            this.lblDisplay.Text = "Input device information and hit create!";
            // 
            // txtImageURL
            // 
            this.txtImageURL.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImageURL.Location = new System.Drawing.Point(422, 391);
            this.txtImageURL.Margin = new System.Windows.Forms.Padding(2);
            this.txtImageURL.Name = "txtImageURL";
            this.txtImageURL.Size = new System.Drawing.Size(173, 22);
            this.txtImageURL.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(263, 394);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Asset Image URL (Optional):";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(515, 602);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(173, 33);
            this.btnCancel.TabIndex = 79;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // pbxProfile
            // 
            this.pbxProfile.BackColor = System.Drawing.Color.Transparent;
            this.pbxProfile.Image = global::CIS_3309_Term_Project.Properties.Resources.computerSymbol;
            this.pbxProfile.Location = new System.Drawing.Point(422, 88);
            this.pbxProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pbxProfile.Name = "pbxProfile";
            this.pbxProfile.Size = new System.Drawing.Size(173, 139);
            this.pbxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProfile.TabIndex = 80;
            this.pbxProfile.TabStop = false;
            // 
            // lblAssignedUser
            // 
            this.lblAssignedUser.AutoSize = true;
            this.lblAssignedUser.BackColor = System.Drawing.Color.Transparent;
            this.lblAssignedUser.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignedUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAssignedUser.Location = new System.Drawing.Point(418, 51);
            this.lblAssignedUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAssignedUser.Name = "lblAssignedUser";
            this.lblAssignedUser.Size = new System.Drawing.Size(133, 21);
            this.lblAssignedUser.TabIndex = 83;
            this.lblAssignedUser.Text = "lblAssignedUser";
            // 
            // frmCreateAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(989, 699);
            this.Controls.Add(this.lblAssignedUser);
            this.Controls.Add(this.pbxProfile);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtImageURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.txtStorage);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.txtRam);
            this.Controls.Add(this.txtCPU);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.btnCreateAsset);
            this.Controls.Add(this.chkAssetAutofill);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtOS);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblStorage);
            this.Controls.Add(this.lblOS);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblModel);
            this.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCreateAsset";
            this.Text = "Asset Manager System - Create Asset";
            this.Load += new System.EventHandler(this.frmCreateAsset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Button btnCreateAsset;
        private System.Windows.Forms.CheckBox chkAssetAutofill;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblStorage;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.TextBox txtStorage;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.TextBox txtImageURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbxProfile;
        private System.Windows.Forms.Label lblAssignedUser;
    }
}