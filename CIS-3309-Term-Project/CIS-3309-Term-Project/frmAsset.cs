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
    public partial class frmAsset : Form
    {
        AssetCollectionController myAssetController;
        AssetCollection assetCollection = new AssetCollection();
        User currentUser;
        // Bring the current user from the dashboard form
        //BindingSource myBindingSource;


        public frmAsset(User user)
        {
            currentUser = user;
            InitializeComponent();
        }
        private void frmAsset_Load(object sender, EventArgs e)
        {

            try
            {
                myAssetController = new AssetCollectionController();
                dgvAsset.DataSource = myAssetController.LoadAssets();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void dgvAsset_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // I think this may have been added my mistake lets touch base and see if we can remove this

        }

        private void btnCreateAsset_Click(object sender, EventArgs e)
        {
            Form frm = new frmCreateAsset();
            frm.ShowDialog();
        }

        private void btnViewAsset_Click(object sender, EventArgs e)
        {
            Asset selectedAsset = (Asset)dgvAsset.CurrentRow.DataBoundItem; //gets whole object back
            frmAssetView frm = new frmAssetView();
            frm.currentAsset = selectedAsset;
            frm.ShowDialog();
            dgvAsset.DataSource = myAssetController.LoadAssets(); // has torefresh after edits

            // See if this actually works on the call for the searches blah blah blah
            //assetCollection.Assets;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure?", "Delete Asset", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Asset selectedAsset = (Asset)dgvAsset.CurrentRow.DataBoundItem;
                    myAssetController.DeleteAsset(selectedAsset);
                    dgvAsset.DataSource = myAssetController.LoadAssets();
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

        private void btnLoadInUse_Click(object sender, EventArgs e)
        {
            dgvAsset.DataSource = myAssetController.LoadInUse();
        }

        private void btnInStock_Click(object sender, EventArgs e)
        {
            dgvAsset.DataSource = myAssetController.LoadAvailable();
        }

        private void btnLoadAssets_Click(object sender, EventArgs e)
        {
            dgvAsset.DataSource = myAssetController.LoadAssets();
        }

        private void btnRecent_Click(object sender, EventArgs e)
        {
            dgvAsset.DataSource = myAssetController.LoadRecentAsset();

        }

        private void btnSearchAsset_Click(object sender, EventArgs e)
        {
            if (cboSearchAsset.Text == "")
            {
                MessageBox.Show("Please select a category.");
                return;
            }
            if (txtSearchAsset.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a value to search for.");
                return;
            }

            try
            {
                assetCollection.Assets = myAssetController.LoadAssets();

                AssetCollectionController.ISearch searcher;

                //room to add more searches later, just add another else if
                if (cboSearchAsset.Text == "ID")
                {
                    searcher = new AssetCollectionController.SearchByID();
                }
                else if (cboSearchAsset.Text == "Make")
                {
                    searcher = new AssetCollectionController.SearchByMake();
                }
                else if (cboSearchAsset.Text == "Model")
                {
                    searcher = new AssetCollectionController.SearchByModel();
                }
                else
                {
                    MessageBox.Show("Invalid Search Category");
                    return;
                }

                // searches based on teh collection
                List<Asset> results = searcher.Search(txtSearchAsset.Text.Trim(), assetCollection);

                if (results.Count == 0)
                {
                    MessageBox.Show("No record found!");
                }

                dgvAsset.DataSource = results;
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

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            Asset selectedAsset = (Asset)dgvAsset.CurrentRow.DataBoundItem;
            if (myAssetController.CheckInAsset(selectedAsset))
            {
                MessageBox.Show("Successfully checked in user device");
            } else
            {
                MessageBox.Show("Error checking in user device");
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Asset selectedAsset = (Asset)dgvAsset.CurrentRow.DataBoundItem;
            if (myAssetController.CheckOutAsset(selectedAsset, currentUser))
            {
                MessageBox.Show("Successfully checked out device");
            } else
            {
                MessageBox.Show("Error checking out device");
            }

        }
    }
}
