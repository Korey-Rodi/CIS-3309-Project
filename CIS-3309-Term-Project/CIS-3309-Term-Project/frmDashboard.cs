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
    public partial class frmDashboard : Form
    {
        private UserCollectionController userCollection = new UserCollectionController();
        private AssetCollectionController assetCollection = new AssetCollectionController();
        private User currentUser;


        public frmDashboard(User user)
        {
            currentUser = user;
            InitializeComponent();
        }

        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmUserProfile(currentUser);
            frm.ShowDialog();
        }
        //asset form
        private void viewAssetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAsset();
            frm.ShowDialog();
        }
        //user form 
        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmUser();
            frm.ShowDialog();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            userCollection.LoadUsers();
            assetCollection.LoadAssets();
            lblTotalUsersData.Text = userCollection.GetTotalUsers().ToString();
            lblTotalAssetsData.Text = assetCollection.GetAssetCount().ToString();
        }
    }
}
