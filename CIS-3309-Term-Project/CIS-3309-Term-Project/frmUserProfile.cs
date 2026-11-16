using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_3309_Term_Project
{
    public partial class frmUserProfile : Form
    {
        private User currentUser;
        private AssetCollectionController AssetCollection;
        private UserCollectionController UserCollection = new UserCollectionController();
        public frmUserProfile(User user, AssetCollectionController assetCollection)
        {
            AssetCollection = assetCollection;
            currentUser = user;
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //User cannot be deleted if they have assets assigned to them
            List<Asset> assets = AssetCollection.LoadMyDevices(currentUser);
            if (assets.Count > 0)
            {
                MessageBox.Show("You Cannot Delete Account with Assets Assigned", "Database Error");
            } else
            {
                if (UserCollection.DeleteUser(currentUser))
                {
                    MessageBox.Show("Please log out out Asset Management System", "Account Deleted");
                } else
                {
                    MessageBox.Show("Unable to delete account", "Account Deletion Error");
                }
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                //copy controls to user
                currentUser.Username = txtUsername.Text;
                currentUser.Password = txtPassword.Text;
                currentUser.FirstName = txtFirst.Text;
                currentUser.LastName = txtLast.Text;
                currentUser.PhoneNumber = txtPhoneNumber.Text;
                currentUser.Address = txtAddress.Text;
                currentUser.City = txtCity.Text;
                currentUser.State = txtState.Text;
                currentUser.ProfilePicture = txtUrl.Text;
                currentUser.UserDepartment = (User.Department)cbxDept.SelectedIndex;

                UserCollection.EditUser(currentUser);
                MessageBox.Show("Profile saved.", "Save Profile");
                this.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frmUserProfile_Load(object sender, EventArgs e)
        {
            if (currentUser.ProfilePicture.Length > 0)
            {
                pbxProfile.Load(currentUser.ProfilePicture);
            }
            txtUsername.Text = currentUser.Username;
            txtPassword.Text = currentUser.Password;
            txtFirst.Text = currentUser.FirstName;
            txtLast.Text = currentUser.LastName;
            txtCity.Text = currentUser.City;
            txtAddress.Text = currentUser.Address;
            txtPhoneNumber.Text = currentUser.PhoneNumber;
            txtState.Text = currentUser.State;
            txtUrl.Text = currentUser.ProfilePicture;
            cbxDept.SelectedItem = currentUser.UserDepartment.ToString();
            txtUrl.Text = currentUser.ProfilePicture;
            List<Asset> assets = AssetCollection.LoadMyDevices(currentUser);
            dgvMyAssets.DataSource = assets;

        }

        private void btnViewSelectedAsset_Click(object sender, EventArgs e)
        {
            Asset selectedAsset = (Asset)dgvMyAssets.CurrentRow.DataBoundItem; //gets whole object back
            frmAssetView frm = new frmAssetView();
            frm.currentAsset = selectedAsset;
            frm.ShowDialog();

            //refresh after edits/delete
            AssetCollection.LoadAssets();
            dgvMyAssets.DataSource = AssetCollection.LoadMyDevices(currentUser);
        }
    }
}
