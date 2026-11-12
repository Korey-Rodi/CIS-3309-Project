using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CIS_3309_Term_Project.User;

namespace CIS_3309_Term_Project
{
    public partial class frmCreate : Form
    {
        private UserCollectionController userCollection = new UserCollectionController();
        public frmCreate()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (chkLinkDevice.Checked)
            {
                // Here is where your link device logic and form laucnh can go perhaps?
                // You may need to rewrite this depending on your implementation
                return;
            }
            // User ID sets to 0 and is properly assigned when added to database
            int userId = 0;
            User newUser = new User(userId, txtUsername.Text, txtPassword.Text, txtFirst.Text,
                txtLast.Text, txtPhoneNumber.Text, txtAddress.Text, txtCity.Text, txtState.Text, (Department)cbxDept.SelectedIndex, txtUrl.Text);
            if (userCollection.AddUser(newUser))
            {
                MessageBox.Show("User account Created", "Account Created");
            }
            
        }
    }
}
