namespace CIS_3309_Term_Project
{
    partial class frmUserProfile
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
            this.pbxProfile = new System.Windows.Forms.PictureBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblProfileImage = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.cbxDept = new System.Windows.Forms.ComboBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvMyAssets = new System.Windows.Forms.DataGridView();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnViewSelectedAsset = new System.Windows.Forms.Button();
            this.lblUserProfileIntro = new System.Windows.Forms.Label();
            this.lblUserAssets = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyAssets)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxProfile
            // 
            this.pbxProfile.Location = new System.Drawing.Point(250, 137);
            this.pbxProfile.Name = "pbxProfile";
            this.pbxProfile.Size = new System.Drawing.Size(264, 214);
            this.pbxProfile.TabIndex = 0;
            this.pbxProfile.TabStop = false;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(257, 709);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(257, 26);
            this.txtState.TabIndex = 45;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsername.Location = new System.Drawing.Point(132, 397);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 20);
            this.lblUsername.TabIndex = 26;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPassword.Location = new System.Drawing.Point(132, 440);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 27;
            this.lblPassword.Text = "Password:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFirstName.Location = new System.Drawing.Point(124, 488);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 28;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblProfileImage
            // 
            this.lblProfileImage.AutoSize = true;
            this.lblProfileImage.BackColor = System.Drawing.Color.Transparent;
            this.lblProfileImage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProfileImage.Location = new System.Drawing.Point(64, 804);
            this.lblProfileImage.Name = "lblProfileImage";
            this.lblProfileImage.Size = new System.Drawing.Size(155, 20);
            this.lblProfileImage.TabIndex = 29;
            this.lblProfileImage.Text = "Image Url (Optional):";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLastName.Location = new System.Drawing.Point(129, 530);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 20);
            this.lblLastName.TabIndex = 30;
            this.lblLastName.Text = "Last Name:";
            // 
            // cbxDept
            // 
            this.cbxDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDept.FormattingEnabled = true;
            this.cbxDept.Items.AddRange(new object[] {
            "IT",
            "HR",
            "Claims",
            "Finance",
            "Facility"});
            this.cbxDept.Location = new System.Drawing.Point(256, 755);
            this.cbxDept.Name = "cbxDept";
            this.cbxDept.Size = new System.Drawing.Size(257, 28);
            this.cbxDept.TabIndex = 31;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.BackColor = System.Drawing.Color.Transparent;
            this.lblDept.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDept.Location = new System.Drawing.Point(121, 755);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(98, 20);
            this.lblDept.TabIndex = 32;
            this.lblDept.Text = "Department:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(257, 397);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(257, 26);
            this.txtUsername.TabIndex = 33;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(257, 440);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(257, 26);
            this.txtPassword.TabIndex = 34;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(256, 485);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(257, 26);
            this.txtFirst.TabIndex = 35;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(256, 530);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(257, 26);
            this.txtLast.TabIndex = 36;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(257, 804);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(257, 26);
            this.txtUrl.TabIndex = 37;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPhoneNumber.Location = new System.Drawing.Point(95, 573);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(119, 20);
            this.lblPhoneNumber.TabIndex = 38;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAddress.Location = new System.Drawing.Point(142, 617);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 20);
            this.lblAddress.TabIndex = 39;
            this.lblAddress.Text = "Address:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblState.Location = new System.Drawing.Point(162, 709);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(52, 20);
            this.lblState.TabIndex = 40;
            this.lblState.Text = "State:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCity.Location = new System.Drawing.Point(179, 664);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 20);
            this.lblCity.TabIndex = 41;
            this.lblCity.Text = "City";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(257, 573);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(257, 26);
            this.txtPhoneNumber.TabIndex = 42;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(257, 617);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(257, 26);
            this.txtAddress.TabIndex = 43;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(256, 664);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(257, 26);
            this.txtCity.TabIndex = 44;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Ebrima", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(23, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(291, 65);
            this.lblTitle.TabIndex = 46;
            this.lblTitle.Text = "User Profile";
            // 
            // dgvMyAssets
            // 
            this.dgvMyAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyAssets.Location = new System.Drawing.Point(670, 448);
            this.dgvMyAssets.Name = "dgvMyAssets";
            this.dgvMyAssets.RowHeadersWidth = 62;
            this.dgvMyAssets.RowTemplate.Height = 28;
            this.dgvMyAssets.Size = new System.Drawing.Size(744, 382);
            this.dgvMyAssets.TabIndex = 47;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(63, 868);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(187, 51);
            this.btnSaveChanges.TabIndex = 48;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(326, 868);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(187, 51);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Delete Account";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnViewSelectedAsset
            // 
            this.btnViewSelectedAsset.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSelectedAsset.Location = new System.Drawing.Point(904, 868);
            this.btnViewSelectedAsset.Name = "btnViewSelectedAsset";
            this.btnViewSelectedAsset.Size = new System.Drawing.Size(270, 51);
            this.btnViewSelectedAsset.TabIndex = 50;
            this.btnViewSelectedAsset.Text = "View Selected Asset";
            this.btnViewSelectedAsset.UseVisualStyleBackColor = true;
            // 
            // lblUserProfileIntro
            // 
            this.lblUserProfileIntro.AutoSize = true;
            this.lblUserProfileIntro.BackColor = System.Drawing.Color.Transparent;
            this.lblUserProfileIntro.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserProfileIntro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUserProfileIntro.Location = new System.Drawing.Point(585, 137);
            this.lblUserProfileIntro.Name = "lblUserProfileIntro";
            this.lblUserProfileIntro.Size = new System.Drawing.Size(826, 56);
            this.lblUserProfileIntro.TabIndex = 51;
            this.lblUserProfileIntro.Text = "Welcome to the user Profile view! Here, you can view an overview of the users ass" +
    "igned assets \r\nand configure user information";
            // 
            // lblUserAssets
            // 
            this.lblUserAssets.AutoSize = true;
            this.lblUserAssets.BackColor = System.Drawing.Color.Transparent;
            this.lblUserAssets.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserAssets.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUserAssets.Location = new System.Drawing.Point(942, 391);
            this.lblUserAssets.Name = "lblUserAssets";
            this.lblUserAssets.Size = new System.Drawing.Size(151, 32);
            this.lblUserAssets.TabIndex = 52;
            this.lblUserAssets.Text = "User Assets:";
            // 
            // frmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CIS_3309_Term_Project.Properties.Resources.BlueGradientBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 1069);
            this.Controls.Add(this.lblUserAssets);
            this.Controls.Add(this.lblUserProfileIntro);
            this.Controls.Add(this.btnViewSelectedAsset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.dgvMyAssets);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.cbxDept);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblProfileImage);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pbxProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmUserProfile";
            this.ShowIcon = false;
            this.Text = "Asset Manager System - User";
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyAssets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxProfile;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblProfileImage;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.ComboBox cbxDept;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvMyAssets;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnViewSelectedAsset;
        private System.Windows.Forms.Label lblUserProfileIntro;
        private System.Windows.Forms.Label lblUserAssets;
    }
}