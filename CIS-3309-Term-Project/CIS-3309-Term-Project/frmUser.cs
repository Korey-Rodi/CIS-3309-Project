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
    }
}
