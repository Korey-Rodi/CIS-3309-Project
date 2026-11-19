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
    public partial class frmUser : Form
    {
        UserCollectionController myUserController;
        UserCollection userCollection = new UserCollection();

        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            try
            {
                //creating obj to connect to access database
                myUserController = new UserCollectionController();
                //links the loaded users method to the grid
                dgvUser.DataSource = myUserController.LoadUsers();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            Form frm = new frmCreate();
            frm.ShowDialog();
            dgvUser.DataSource = myUserController.LoadUsers();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            User selectedUser = (User)dgvUser.CurrentRow.DataBoundItem;

            AssetCollectionController myAssetController = new AssetCollectionController();
            myAssetController.LoadAssets();

            Form frm = new frmUserProfile(selectedUser, myAssetController);
            frm.ShowDialog();
            dgvUser.DataSource = myUserController.LoadUsers(); 
        }

        private void btnLoadUsers_Click(object sender, EventArgs e)
        {
            dgvUser.DataSource = myUserController.LoadUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure?", "Delete Asset", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    User selectedAsset = (User)dgvUser.CurrentRow.DataBoundItem;
                    AssetCollectionController myAssetController = new AssetCollectionController();
                    myAssetController.LoadAssets();
                    if (myAssetController.LoadMyDevices(selectedAsset).Count > 0)
                    {
                        MessageBox.Show("You Cannot Delete Account with Assets Assigned", "Database Error");
                        return;
                    }
                    myUserController.DeleteUser(selectedAsset);
                    dgvUser.DataSource = myUserController.LoadUsers();
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

        private void btnSearchAsset_Click(object sender, EventArgs e)
        {
            if (cboSearchUser.Text == "")
            {
                MessageBox.Show("Please select a category.");
                return;
            }
            if (txtSearchUser.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a value to search for.");
                return;
            }

            try
            {
                userCollection.Users = myUserController.LoadUsers();

                UserCollectionController.ISearch searcher;

                //room to add more searches later, just add another else if
                if (cboSearchUser.Text == "ID")
                {
                    searcher = new UserCollectionController.SearchByID();
                }
                else if (cboSearchUser.Text == "First Name")
                {
                    searcher = new UserCollectionController.SearchByFirstName();
                }
                else if (cboSearchUser.Text == "Last Name")
                {
                    searcher = new UserCollectionController.SearchByLastName();
                }
                else if (cboSearchUser.Text == "Username")
                {
                    searcher = new UserCollectionController.SearchByUsername();
                }
                else
                {
                    MessageBox.Show("Invalid Search Category");
                    return;
                }

                // searches based on teh collection
                List<User> results = searcher.Search(txtSearchUser.Text.Trim(), userCollection);

                if (results.Count == 0)
                {
                    MessageBox.Show("No record found!");
                }

                dgvUser.DataSource = results;
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
    }
}
