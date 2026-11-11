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
        private UserCollectionController userController = new UserCollectionController();
        private List<User> currentUsers = new List<User>();
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
            User currentUser = userController.ValidateUser(txtUser.Text, txtPassword.Text);
            if (currentUser != null)
            {
                Form frm = new frmDashboard(currentUser);
                frm.ShowDialog();
            } else
            {
                MessageBox.Show("Incorrect Username or Password", "Login Error");
            }
        }

        private void frmLoginCreate_Load(object sender, EventArgs e)
        {
            // Adds all the current users to memory
            currentUsers = userController.LoadUsers();
        }
    }
}
