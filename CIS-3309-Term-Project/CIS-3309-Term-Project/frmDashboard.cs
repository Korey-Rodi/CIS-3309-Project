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
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmUserProfile();
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
    }
}
