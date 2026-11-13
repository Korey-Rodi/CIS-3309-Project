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
        public frmAsset()
        {
            InitializeComponent();
        }
        private void frmAsset_Load(object sender, EventArgs e)
        {
            try
            {
                //creating obj to connect to access database
                myAssetController = new AssetCollectionController();
                //links the loaded assets method to the grid
                dgvAsset.DataSource = myAssetController.LoadAssets();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvAsset_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCreateAsset_Click(object sender, EventArgs e)
        {
            Form frm = new frmCreateAsset();
            frm.ShowDialog();
        }

        private void btnViewAsset_Click(object sender, EventArgs e)
        {
            Form frm = new frmAssetView();
            frm.ShowDialog();
        }
    }
}
