using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_3309_Term_Project
{
    public partial class frmCreateAsset : Form
    {
        private AssetCollectionController assetController = new AssetCollectionController();
        public frmCreateAsset()
        {
            InitializeComponent();
        }
        private void frmCreateAsset_Load(object sender, EventArgs e)
        {
            // for creation of account link
            if (this.Tag != null)
            {
                lblAssignedUser.Text = "Assigning to User ID: " + this.Tag.ToString();
                cboState.Text = "In_Use";   // if assigning device, locks it to In_Use
                cboState.Enabled = false;
            }
            else
            {
                lblAssignedUser.Text = "";
            }
        }
        private void btnCreateAsset_Click(object sender, EventArgs e)
        {
            // asset ID set to 0, handled by db
            int assetId = 0;
            // 0 = unassigned, unless user passed in through tag, then if
            int assignedUserId = 0;
            if (this.Tag != null)
            {
                assignedUserId = (int)this.Tag;
            }
            Asset newAsset = new Asset(assetId, txtMake.Text, txtModel.Text, DateTime.Now,
            (Asset.State)cboState.SelectedIndex, txtLocation.Text, txtImageURL.Text,
            txtCPU.Text, txtRam.Text, txtOS.Text, txtStorage.Text, assignedUserId);
            if (assetController.AddAsset(newAsset))
            {
                MessageBox.Show("Asset Created", "Asset Created");
                this.Close();
            }
        }
        
    }
}
