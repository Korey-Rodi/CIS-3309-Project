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
            Form frm = new frmAsset(currentUser);
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
            fpBarChartUsersByDept.Plot.Add.Bars(xs, ys).Color = Colors.DarkSeaGreen;
            fpBarChartUsersByDept.Plot.Axes.Bottom.SetTicks(xs, departments);
            fpBarChartUsersByDept.Plot.Axes.Margins(bottom: 0);
            fpBarChartUsersByDept.Plot.DataBackground.Color = Colors.White;
            fpBarChartUsersByDept.Plot.FigureBackground.Color = Colors.White;
            fpBarChartUsersByDept.Plot.HideGrid();
            fpBarChartUsersByDept.Plot.Grid.MajorLineColor = Colors.LightGray;
            //fpBarChartUsersByDept.Plot.Title("Users By Department");
            fpBarChartUsersByDept.Plot.Axes.AutoScale();
            fpBarChartUsersByDept.Refresh();


            // Populate Assets by state graph
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
            fpBarChartAssetsByState.Plot.Add.Bars(x2, y2).Color = Colors.YellowGreen;
            fpBarChartAssetsByState.Plot.Axes.Bottom.SetTicks(x2, State);
            fpBarChartAssetsByState.Plot.Axes.Margins(bottom: 0);
            fpBarChartAssetsByState.Plot.DataBackground.Color = Colors.White;
            fpBarChartAssetsByState.Plot.FigureBackground.Color = Colors.White;
            fpBarChartAssetsByState.Plot.HideGrid();
            fpBarChartAssetsByState.Plot.Grid.MajorLineColor = Colors.LightGray;
            //fpBarChartAssetsByState.Plot.Title("Assets By State");
            fpBarChartUsersByDept.Plot.Axes.AutoScale();
            fpBarChartAssetsByState.Refresh();


            // Populate pie chart of assets graph
            fpPieChart.Plot.Clear();

            int totalAssets = assetCollection.GetAssetCount();
            List<PieSlice> slices = new List<PieSlice>
            {
                new PieSlice
                {
                    Value = totalAssets, FillColor = Colors.Orange, Label = "Total Assets " + totalAssets, LegendText = "Total Assets"
                },
                new PieSlice
                {
                    Value = 5, FillColor = Colors.Green, Label = "In Stock", LegendText = "In Stock"
                },
                new PieSlice
                {
                    Value = 8, FillColor = Colors.Blue, Label = "In Use", LegendText = "In Use"
                },
                new PieSlice
                {
                    Value = 12, FillColor = Colors.Yellow, Label = "Broken", LegendText = "Broken"
                },
                new PieSlice
                {
                    Value = 5, FillColor = Colors.Red, Label = "Retired", LegendText = "Retired"
                }
            };

            fpPieChart.Plot.Add.Pie(slices);
            fpPieChart.Plot.Axes.AutoScale();
            fpPieChart.Plot.FigureBackground.Color = Colors.AliceBlue;
            fpPieChart.Plot.Axes.Frameless();
            fpPieChart.Plot.HideGrid();
            fpPieChart.Plot.ShowLegend();
            fpPieChart.Refresh();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm = new frmDashboard(currentUser);
            frm.Show();

        }
    }
}
