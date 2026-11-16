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
    public partial class frmAssetView : Form
    {
        AssetCollectionController myAssetController = new AssetCollectionController();
        UserCollectionController myUserController = new UserCollectionController();
        internal Asset currentAsset;

        public frmAssetView()
        {
            InitializeComponent();
        }

        private void btnCloseViewAsset_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                Asset.State newState = (Asset.State)cboState.SelectedIndex;

                //updates date ONLY if state change
                if (newState != currentAsset.AssetState)
                {
                    currentAsset.Date = DateTime.Today;
                }

                //copy controls to asset
                currentAsset.AssetState = newState;
                currentAsset.Make = txtMake.Text;
                currentAsset.Model = txtModel.Text;
                currentAsset.Location = txtLocation.Text;
                currentAsset.AssetImage = txtAssetImage.Text;
                currentAsset.CPU = txtCPU.Text;
                currentAsset.Ram = txtRam.Text;
                currentAsset.OS = txtOS.Text;
                currentAsset.Storage = txtStorage.Text;

                //blank or "No Assigned User" = unassigned
                if (txtAssignedUserID.Text == "" || txtAssignedUserID.Text == "No Assigned User")
                {
                    currentAsset.AssignedUserId = 0;
                }
                else
                {
                    int userId = int.Parse(txtAssignedUserID.Text);

                    //ensures a user with that id exists
                    bool found = false;
                    foreach (User user in myUserController.LoadUsers())
                    {
                        if (user.UserID == userId)
                        {
                            found = true;
                        }
                    }

                    if (found == false)
                    {
                        MessageBox.Show("No user with that ID.", "Assign User");
                        return;
                    }
                    currentAsset.AssignedUserId = userId;
                }
                myAssetController.EditAsset(currentAsset);
                MessageBox.Show("Asset saved.", "Save Asset");
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

        private void frmAssetView_Load(object sender, EventArgs e)
        {
            //shows assigned user id if 
            if (currentAsset.AssignedUserId == 0)
            {
                txtAssignedUserID.Text = "No Assigned User";
            }
            else
            {
                txtAssignedUserID.Text = currentAsset.AssignedUserId.ToString();
            }

            // fill controls with selected asset
            txtAssetId.Text = currentAsset.AssetID.ToString();
            txtDateLastStateChange.Text = currentAsset.Date.ToString("yyyy-MM-dd");
            txtMake.Text = currentAsset.Make;
            txtModel.Text = currentAsset.Model;
            txtLocation.Text = currentAsset.Location;
            txtAssetImage.Text = currentAsset.AssetImage;
            txtCPU.Text = currentAsset.CPU;
            txtRam.Text = currentAsset.Ram;
            txtOS.Text = currentAsset.OS;
            txtStorage.Text = currentAsset.Storage;
            cboState.SelectedItem = currentAsset.AssetState.ToString();

            //shows the asset picture if length value is onver 0
            try
            {
                if (currentAsset.AssetImage.Length > 0)
                {
                    pbxProfile.Load(currentAsset.AssetImage);
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Could not load image: " + ex.Message);
            }
        }

        private void lblState_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure?", "Delete Asset", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    myAssetController.DeleteAsset(currentAsset);
                    MessageBox.Show("Asset deleted.", "Delete Asset");
                    this.Close();
                }
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

        private void txtAssetImage_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbxProfile_Validated(object sender, EventArgs e)
        {
            try
            {
                if (txtAssetImage.Text.Length > 0)
                {
                    pbxProfile.Load(txtAssetImage.Text);
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Could not load image: " + ex.Message);
            }
        }
    }
}
