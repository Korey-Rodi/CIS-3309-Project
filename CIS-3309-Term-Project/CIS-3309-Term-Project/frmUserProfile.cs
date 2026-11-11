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
    public partial class frmUserProfile : Form
    {
        private User currentUser;
        private AssetCollectionController assetCollection;
        public frmUserProfile(User user)
        {
            currentUser = user;
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

        }

        private void frmUserProfile_Load(object sender, EventArgs e)
        {
            if (currentUser.ProfilePicture.Length > 0)
            {
                pbxProfile.Load(currentUser.ProfilePicture);
            }
            txtUsername.Text = currentUser.Username;
            txtPassword.Text = currentUser.Password;
            txtFirst.Text = currentUser.FirstName;
            txtLast.Text = currentUser.LastName;
            txtCity.Text = currentUser.City;
            txtAddress.Text = currentUser.Address;
            txtPhoneNumber.Text = currentUser.PhoneNumber;
            txtState.Text = currentUser.State;
            txtUrl.Text = currentUser.ProfilePicture;
            cbxDept.SelectedItem = currentUser.UserDepartment.ToString();
            txtUrl.Text = currentUser.ProfilePicture;
            // Call the method to fill in the devices associated with the users

        }
    }
}
