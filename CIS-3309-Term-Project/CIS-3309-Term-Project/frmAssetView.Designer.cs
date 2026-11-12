namespace CIS_3309_Term_Project
{
    partial class frmAssetView
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
            this.txtStorage = new System.Windows.Forms.TextBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.txtAssignedUserID = new System.Windows.Forms.TextBox();
            this.lblAssignedUserID = new System.Windows.Forms.Label();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.btnCloseViewAsset = new System.Windows.Forms.Button();
            this.chkAssetAutofill = new System.Windows.Forms.CheckBox();
            this.txtPictureAsset = new System.Windows.Forms.TextBox();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.txtDataLastStateChange = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblStorage = new System.Windows.Forms.Label();
            this.lblOS = new System.Windows.Forms.Label();
            this.lblPictureAsset = new System.Windows.Forms.Label();
            this.lblDataLastStateChange = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStorage
            // 
            this.txtStorage.Location = new System.Drawing.Point(429, 473);
            this.txtStorage.Margin = new System.Windows.Forms.Padding(2);
            this.txtStorage.Name = "txtStorage";
            this.txtStorage.Size = new System.Drawing.Size(173, 20);
            this.txtStorage.TabIndex = 73;
            // 
            // cboState
            // 
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "IT",
            "HR",
            "Claims",
            "Finance",
            "Facility"});
            this.cboState.Location = new System.Drawing.Point(429, 240);
            this.cboState.Margin = new System.Windows.Forms.Padding(2);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(173, 21);
            this.cboState.TabIndex = 72;
            // 
            // txtAssignedUserID
            // 
            this.txtAssignedUserID.Location = new System.Drawing.Point(429, 274);
            this.txtAssignedUserID.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssignedUserID.Name = "txtAssignedUserID";
            this.txtAssignedUserID.Size = new System.Drawing.Size(173, 20);
            this.txtAssignedUserID.TabIndex = 71;
            // 
            // lblAssignedUserID
            // 
            this.lblAssignedUserID.AutoSize = true;
            this.lblAssignedUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblAssignedUserID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAssignedUserID.Location = new System.Drawing.Point(322, 277);
            this.lblAssignedUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAssignedUserID.Name = "lblAssignedUserID";
            this.lblAssignedUserID.Size = new System.Drawing.Size(89, 13);
            this.lblAssignedUserID.TabIndex = 70;
            this.lblAssignedUserID.Text = "Assigned UserID:";
            // 
            // txtRam
            // 
            this.txtRam.Location = new System.Drawing.Point(429, 407);
            this.txtRam.Margin = new System.Windows.Forms.Padding(2);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(173, 20);
            this.txtRam.TabIndex = 69;
            // 
            // txtCPU
            // 
            this.txtCPU.Location = new System.Drawing.Point(429, 373);
            this.txtCPU.Margin = new System.Windows.Forms.Padding(2);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(173, 20);
            this.txtCPU.TabIndex = 68;
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.BackColor = System.Drawing.Color.Transparent;
            this.lblRAM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRAM.Location = new System.Drawing.Point(356, 410);
            this.lblRAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(34, 13);
            this.lblRAM.TabIndex = 67;
            this.lblRAM.Text = "RAM:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblState.Location = new System.Drawing.Point(356, 243);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 66;
            this.lblState.Text = "State:";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.BackColor = System.Drawing.Color.Transparent;
            this.lblCPU.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCPU.Location = new System.Drawing.Point(356, 380);
            this.lblCPU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(32, 13);
            this.lblCPU.TabIndex = 65;
            this.lblCPU.Text = "CPU:";
            // 
            // btnCloseViewAsset
            // 
            this.btnCloseViewAsset.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseViewAsset.Location = new System.Drawing.Point(380, 589);
            this.btnCloseViewAsset.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseViewAsset.Name = "btnCloseViewAsset";
            this.btnCloseViewAsset.Size = new System.Drawing.Size(173, 33);
            this.btnCloseViewAsset.TabIndex = 64;
            this.btnCloseViewAsset.Text = "Close";
            this.btnCloseViewAsset.UseVisualStyleBackColor = true;
            // 
            // chkAssetAutofill
            // 
            this.chkAssetAutofill.AutoSize = true;
            this.chkAssetAutofill.BackColor = System.Drawing.Color.Transparent;
            this.chkAssetAutofill.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkAssetAutofill.Location = new System.Drawing.Point(401, 342);
            this.chkAssetAutofill.Margin = new System.Windows.Forms.Padding(2);
            this.chkAssetAutofill.Name = "chkAssetAutofill";
            this.chkAssetAutofill.Size = new System.Drawing.Size(180, 17);
            this.chkAssetAutofill.TabIndex = 63;
            this.chkAssetAutofill.Text = "Autofill with my computer\'s specs";
            this.chkAssetAutofill.UseVisualStyleBackColor = false;
            // 
            // txtPictureAsset
            // 
            this.txtPictureAsset.Location = new System.Drawing.Point(429, 307);
            this.txtPictureAsset.Margin = new System.Windows.Forms.Padding(2);
            this.txtPictureAsset.Name = "txtPictureAsset";
            this.txtPictureAsset.Size = new System.Drawing.Size(173, 20);
            this.txtPictureAsset.TabIndex = 62;
            // 
            // txtOS
            // 
            this.txtOS.Location = new System.Drawing.Point(429, 440);
            this.txtOS.Margin = new System.Windows.Forms.Padding(2);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(173, 20);
            this.txtOS.TabIndex = 61;
            // 
            // txtDataLastStateChange
            // 
            this.txtDataLastStateChange.Location = new System.Drawing.Point(429, 207);
            this.txtDataLastStateChange.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataLastStateChange.Name = "txtDataLastStateChange";
            this.txtDataLastStateChange.Size = new System.Drawing.Size(173, 20);
            this.txtDataLastStateChange.TabIndex = 60;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(429, 173);
            this.txtMake.Margin = new System.Windows.Forms.Padding(2);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(173, 20);
            this.txtMake.TabIndex = 59;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(429, 140);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(173, 20);
            this.txtModel.TabIndex = 58;
            // 
            // lblStorage
            // 
            this.lblStorage.AutoSize = true;
            this.lblStorage.BackColor = System.Drawing.Color.Transparent;
            this.lblStorage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStorage.Location = new System.Drawing.Point(356, 476);
            this.lblStorage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStorage.Name = "lblStorage";
            this.lblStorage.Size = new System.Drawing.Size(47, 13);
            this.lblStorage.TabIndex = 57;
            this.lblStorage.Text = "Storage:";
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.BackColor = System.Drawing.Color.Transparent;
            this.lblOS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOS.Location = new System.Drawing.Point(356, 443);
            this.lblOS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(25, 13);
            this.lblOS.TabIndex = 56;
            this.lblOS.Text = "OS:";
            // 
            // lblPictureAsset
            // 
            this.lblPictureAsset.AutoSize = true;
            this.lblPictureAsset.BackColor = System.Drawing.Color.Transparent;
            this.lblPictureAsset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPictureAsset.Location = new System.Drawing.Point(270, 310);
            this.lblPictureAsset.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPictureAsset.Name = "lblPictureAsset";
            this.lblPictureAsset.Size = new System.Drawing.Size(141, 13);
            this.lblPictureAsset.TabIndex = 55;
            this.lblPictureAsset.Text = "Asset Image URL (Optional):";
            // 
            // lblDataLastStateChange
            // 
            this.lblDataLastStateChange.AutoSize = true;
            this.lblDataLastStateChange.BackColor = System.Drawing.Color.Transparent;
            this.lblDataLastStateChange.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDataLastStateChange.Location = new System.Drawing.Point(272, 210);
            this.lblDataLastStateChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataLastStateChange.Name = "lblDataLastStateChange";
            this.lblDataLastStateChange.Size = new System.Drawing.Size(139, 13);
            this.lblDataLastStateChange.TabIndex = 54;
            this.lblDataLastStateChange.Text = "Most Recent State Change:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.BackColor = System.Drawing.Color.Transparent;
            this.lblMake.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMake.Location = new System.Drawing.Point(354, 176);
            this.lblMake.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(37, 13);
            this.lblMake.TabIndex = 53;
            this.lblMake.Text = "Make:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.Color.Transparent;
            this.lblModel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblModel.Location = new System.Drawing.Point(354, 147);
            this.lblModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 52;
            this.lblModel.Text = "Model:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(487, 521);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 33);
            this.btnDelete.TabIndex = 75;
            this.btnDelete.Text = "Delete Asset";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(312, 521);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(125, 33);
            this.btnSaveChanges.TabIndex = 74;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDisplay.Location = new System.Drawing.Point(390, 85);
            this.lblDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(191, 13);
            this.lblDisplay.TabIndex = 76;
            this.lblDisplay.Text = "Input device information and hit create!";
            // 
            // frmAssetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(989, 699);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.txtStorage);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.txtAssignedUserID);
            this.Controls.Add(this.lblAssignedUserID);
            this.Controls.Add(this.txtRam);
            this.Controls.Add(this.txtCPU);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.btnCloseViewAsset);
            this.Controls.Add(this.chkAssetAutofill);
            this.Controls.Add(this.txtPictureAsset);
            this.Controls.Add(this.txtOS);
            this.Controls.Add(this.txtDataLastStateChange);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblStorage);
            this.Controls.Add(this.lblOS);
            this.Controls.Add(this.lblPictureAsset);
            this.Controls.Add(this.lblDataLastStateChange);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblModel);
            this.Name = "frmAssetView";
            this.Text = "Asset Manager System - Asset View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStorage;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.TextBox txtAssignedUserID;
        private System.Windows.Forms.Label lblAssignedUserID;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Button btnCloseViewAsset;
        private System.Windows.Forms.CheckBox chkAssetAutofill;
        private System.Windows.Forms.TextBox txtPictureAsset;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.TextBox txtDataLastStateChange;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblStorage;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label lblPictureAsset;
        private System.Windows.Forms.Label lblDataLastStateChange;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblDisplay;
    }
}