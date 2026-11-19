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
            this.lblProfilePic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyAssets)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxProfile
            // 
            this.pbxProfile.BackColor = System.Drawing.Color.Transparent;
            this.pbxProfile.Image = global::CIS_3309_Term_Project.Properties.Resources.ProfileIcon;
            this.pbxProfile.Location = new System.Drawing.Point(167, 89);
            this.pbxProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxProfile.Name = "pbxProfile";
            this.pbxProfile.Size = new System.Drawing.Size(176, 139);
            this.pbxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProfile.TabIndex = 0;
            this.pbxProfile.TabStop = false;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(171, 461);
            this.txtState.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(173, 20);
            this.txtState.TabIndex = 45;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsername.Location = new System.Drawing.Point(88, 258);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 26;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPassword.Location = new System.Drawing.Point(88, 286);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 27;
            this.lblPassword.Text = "Password:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFirstName.Location = new System.Drawing.Point(83, 317);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 28;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblProfileImage
            // 
            this.lblProfileImage.AutoSize = true;
            this.lblProfileImage.BackColor = System.Drawing.Color.Transparent;
            this.lblProfileImage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProfileImage.Location = new System.Drawing.Point(43, 523);
            this.lblProfileImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfileImage.Name = "lblProfileImage";
            this.lblProfileImage.Size = new System.Drawing.Size(103, 13);
            this.lblProfileImage.TabIndex = 29;
            this.lblProfileImage.Text = "Image Url (Optional):";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLastName.Location = new System.Drawing.Point(86, 344);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
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
            "Finance",
            "Claims",
            "Facility"});
            this.cbxDept.Location = new System.Drawing.Point(171, 491);
            this.cbxDept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxDept.Name = "cbxDept";
            this.cbxDept.Size = new System.Drawing.Size(173, 21);
            this.cbxDept.TabIndex = 31;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.BackColor = System.Drawing.Color.Transparent;
            this.lblDept.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDept.Location = new System.Drawing.Point(81, 491);
            this.lblDept.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(65, 13);
            this.lblDept.TabIndex = 32;
            this.lblDept.Text = "Department:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(171, 258);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(173, 20);
            this.txtUsername.TabIndex = 33;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(171, 286);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(173, 20);
            this.txtPassword.TabIndex = 34;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(171, 315);
            this.txtFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(173, 20);
            this.txtFirst.TabIndex = 35;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(171, 344);
            this.txtLast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(173, 20);
            this.txtLast.TabIndex = 36;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(171, 523);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(173, 20);
            this.txtUrl.TabIndex = 37;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPhoneNumber.Location = new System.Drawing.Point(63, 372);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 38;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAddress.Location = new System.Drawing.Point(95, 401);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 39;
            this.lblAddress.Text = "Address:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblState.Location = new System.Drawing.Point(108, 461);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 40;
            this.lblState.Text = "State:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCity.Location = new System.Drawing.Point(119, 432);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 41;
            this.lblCity.Text = "City";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(171, 372);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(173, 20);
            this.txtPhoneNumber.TabIndex = 42;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(171, 401);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(173, 20);
            this.txtAddress.TabIndex = 43;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(171, 432);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(173, 20);
            this.txtCity.TabIndex = 44;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Ebrima", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(196, 45);
            this.lblTitle.TabIndex = 46;
            this.lblTitle.Text = "User Profile";
            // 
            // dgvMyAssets
            // 
            this.dgvMyAssets.AllowUserToAddRows = false;
            this.dgvMyAssets.AllowUserToDeleteRows = false;
            this.dgvMyAssets.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvMyAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyAssets.Location = new System.Drawing.Point(447, 291);
            this.dgvMyAssets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMyAssets.Name = "dgvMyAssets";
            this.dgvMyAssets.ReadOnly = true;
            this.dgvMyAssets.RowHeadersWidth = 62;
            this.dgvMyAssets.RowTemplate.Height = 28;
            this.dgvMyAssets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyAssets.Size = new System.Drawing.Size(496, 248);
            this.dgvMyAssets.TabIndex = 47;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(42, 564);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(125, 33);
            this.btnSaveChanges.TabIndex = 48;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(217, 564);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 33);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Delete Account";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnViewSelectedAsset
            // 
            this.btnViewSelectedAsset.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSelectedAsset.Location = new System.Drawing.Point(603, 564);
            this.btnViewSelectedAsset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewSelectedAsset.Name = "btnViewSelectedAsset";
            this.btnViewSelectedAsset.Size = new System.Drawing.Size(180, 33);
            this.btnViewSelectedAsset.TabIndex = 50;
            this.btnViewSelectedAsset.Text = "View Selected Asset";
            this.btnViewSelectedAsset.UseVisualStyleBackColor = true;
            this.btnViewSelectedAsset.Click += new System.EventHandler(this.btnViewSelectedAsset_Click);
            // 
            // lblUserProfileIntro
            // 
            this.lblUserProfileIntro.AutoSize = true;
            this.lblUserProfileIntro.BackColor = System.Drawing.Color.Transparent;
            this.lblUserProfileIntro.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserProfileIntro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUserProfileIntro.Location = new System.Drawing.Point(390, 89);
            this.lblUserProfileIntro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserProfileIntro.Name = "lblUserProfileIntro";
            this.lblUserProfileIntro.Size = new System.Drawing.Size(587, 38);
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
            this.lblUserAssets.Location = new System.Drawing.Point(628, 254);
            this.lblUserAssets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserAssets.Name = "lblUserAssets";
            this.lblUserAssets.Size = new System.Drawing.Size(99, 21);
            this.lblUserAssets.TabIndex = 52;
            this.lblUserAssets.Text = "User Assets:";
            // 
            // lblProfilePic
            // 
            this.lblProfilePic.AutoSize = true;
            this.lblProfilePic.BackColor = System.Drawing.Color.Transparent;
            this.lblProfilePic.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProfilePic.Location = new System.Drawing.Point(63, 160);
            this.lblProfilePic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfilePic.Name = "lblProfilePic";
            this.lblProfilePic.Size = new System.Drawing.Size(75, 13);
            this.lblProfilePic.TabIndex = 53;
            this.lblProfilePic.Text = "Profile Picture:";
            // 
            // frmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CIS_3309_Term_Project.Properties.Resources.BlueGradientBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 679);
            this.Controls.Add(this.lblProfilePic);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmUserProfile";
            this.ShowIcon = false;
            this.Text = "Asset Manager System - Profile";
            this.Load += new System.EventHandler(this.frmUserProfile_Load);
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
        private System.Windows.Forms.Label lblProfilePic;
    }
}