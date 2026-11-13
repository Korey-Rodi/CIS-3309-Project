using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_3309_Term_Project
{
    public class UserCollectionController
    {
        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet myDataSet;
        private UserCollection userCollection = new UserCollection();
        public UserCollectionController()
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=Asset.accdb;");
        }
        private UserCollection Users;

        //returns dataset info so we don't have to rewrite this on every sql involved method
        private DataSet UserRunQuery(string strSQL)
        {
            // This works for select statements
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            myDataSet = new DataSet("UserTable");
            myDataAdapter.Fill(myDataSet, "UserTable");

            return myDataSet;
        }
        private void UserExecuteQuery(String strSQL)
        {
            // This works for Update, Insert and Delete statements
            OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
        public bool AddUser(User user)
        {
            UserExecuteQuery("INSERT INTO Users (Username, UserPassword, FirstName, LastName,Department,ProfilePic, PhoneNumber, Address, City, State) VALUES ('"
    + user.Username + "', '" + user.Password + "', '" + user.FirstName + "', '" + user.LastName + "', '" + user.UserDepartment.ToString() + "', '" + user.ProfilePicture + "', '" +
    user.PhoneNumber + "', '" + user.Address + "', '" + user.City + "', '" + user.State + "');");
            LoadUsers(); //have to call this because userID isn't created until its autoassigned in db, prob a better solution for this
            return true;
        }
        public bool DeleteUser(User user)
        {
            String id = user.UserID.ToString();
            UserExecuteQuery("DELETE FROM Users WHERE UserID =" + id + ";");
            return true;
        }
        public bool EditUser()
        {
            return true;
        }
        public List<User> LoadUsers()
        {
            myDataSet = UserRunQuery("SELECT * FROM Users ORDER BY UserID");

            userCollection = new UserCollection();

            foreach (DataRow record in myDataSet.Tables["UserTable"].Rows)
            {

                int userId = int.Parse(record["UserID"].ToString());

                //handling the possibilities for the enum
                User.Department userDepartment;
                if (record["Department"].ToString() == "HR")
                {
                    userDepartment = User.Department.HR;
                }
                else if (record["Department"].ToString() == "Finance")
                {
                    userDepartment = User.Department.Finance;
                }
                else if (record["Department"].ToString() == "Claims")
                {
                    userDepartment = User.Department.Claims;
                }
                else if (record["Department"].ToString() == "Facility")
                {
                    userDepartment = User.Department.Facility;
                }
                else 
                {
                    userDepartment = User.Department.IT;
                }

                //building the asset for dgv
                User user = new User(
                    userId,
                    record["Username"].ToString(),
                    record["UserPassword"].ToString(),
                    record["FirstName"].ToString(),
                    record["LastName"].ToString(),
                    record["PhoneNumber"].ToString(),
                    record["Address"].ToString(),
                    record["City"].ToString(),
                    record["State"].ToString(),
                    userDepartment,
                    record["ProfilePic"].ToString());

                userCollection.Users.Add(user);

            }
            return userCollection.Users;
        }
        public User ValidateUser(String username, String password)
        {
            foreach (User user in userCollection.Users)
            {
                if (user.Username.Equals(username) && user.Password.Equals(password))
                {
                    return user;
                }
            }
            return null;
        }
        public int GetTotalUsers()
        {
            return userCollection.Users.Count();
        }
        public Dictionary<String,int> LoadUsersByDept()
        {
            return null;
        }
        // User Search Interface
        public interface ISearch
        {
            List<User> Search(String search);
        }
        public class SearchByID : ISearch
        {
            public List<User> Search(String search)
            {
                List<User> results = new List<User>();
                return results;
            }
        }
        public class SearchByFirstName : ISearch
        {
            public List<User> Search(String search)
            {
                List<User> results = new List<User>();
                return results;
            }
        }
        public class SearchByLastName : ISearch
        {
            public List<User> Search(String search)
            {
                List<User> results = new List<User>();
                return results;
            }
        }
        public class SearchByUsername : ISearch
        {
            public List<User> Search(String search)
            {
                List<User> results = new List<User>();
                return results;
            }
        }
    }
}
