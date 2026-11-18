using ScottPlot;
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
            Form frm = new frmUserProfile(currentUser, assetCollection);
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
            lblTotalUsersData.Text = userCollection.GetTotalUsers().ToString() + " Managed Users";
            lblTotalAssetsData.Text = assetCollection.GetAssetCount().ToString() + " Managed Assets";

            // Populate Users By Department graph
            Dictionary<String, int> UsersByDept = userCollection.LoadUsersByDept();
            string[] departments = UsersByDept.Keys.ToArray();
            int[] rawCounts = UsersByDept.Values.ToArray();

            double[] xs = new double[rawCounts.Length];
            double[] ys = new double[rawCounts.Length];

            for (int i = 0; i < rawCounts.Length; i++)
            {
                xs[i] = i;
                ys[i] = rawCounts[i];
            }

            fpBarChartUsersByDept.Plot.Clear();
            fpBarChartUsersByDept.Plot.Add.Bars(xs, ys);
            fpBarChartUsersByDept.Plot.Axes.Bottom.SetTicks(xs, departments);
            fpBarChartUsersByDept.Plot.Axes.Margins(bottom: 0);
            fpBarChartUsersByDept.Plot.Axes.AutoScale();
            fpBarChartUsersByDept.Refresh();


            Dictionary<String, int> AssetsByState = assetCollection.GetAssetsByState();
            string[] State = AssetsByState.Keys.ToArray();
            int[] AssetsCount = AssetsByState.Values.ToArray();

            double[] x2 = new double[AssetsCount.Length];
            double[] y2 = new double[AssetsCount.Length];

            for (int i = 0; i < AssetsCount.Length; i++)
            {
                x2[i] = i;
                y2[i] = AssetsCount[i];
            }

            fpBarChartAssetsByState.Plot.Clear();
            fpBarChartAssetsByState.Plot.Add.Bars(x2, y2);
            fpBarChartAssetsByState.Plot.Axes.Bottom.SetTicks(x2, State);
            fpBarChartAssetsByState.Plot.Axes.Margins(bottom: 0);
            fpBarChartUsersByDept.Plot.Axes.AutoScale();
            fpBarChartAssetsByState.Refresh();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm = new frmDashboard(currentUser);
            frm.Show();

        }
    }
}
