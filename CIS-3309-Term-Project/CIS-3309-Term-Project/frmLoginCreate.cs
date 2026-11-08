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
    public partial class frmLoginCreate : Form
    {
        public frmLoginCreate()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Form frm = new frmCreate();
            frm.ShowDialog();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Add login logic here I think we should load the collection of users and then search the collection
            // for a matching password and username and then it can launch the form for now it just does it auto
            Form frm = new frmDashboard();
            frm.ShowDialog();
        }
    }
}
