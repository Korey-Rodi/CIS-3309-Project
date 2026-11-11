using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_3309_Term_Project
{
    internal class UserCollectionController
    {
        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet myDataSet;
        private UserCollection userCollection = new UserCollection();
        internal UserCollectionController()
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=Asset.accdb;");
        }
        private UserCollection Users;

        //returns dataset info so we don't have to rewrite this on every sql involved method
        private DataSet UserRunQuery(string strSQL)
        {
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            myDataSet = new DataSet("UserTable");
            myDataAdapter.Fill(myDataSet, "UserTable");

            return myDataSet;
        }
        public bool AddUser()
        {
            return true;
        }
        public bool DeleteUser()
        {
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
            return null;
        }
        public int GetTotalUsers()
        {
            // Place holder code
            return 0;
        }
        public List<User> LoadUsersByDept()
        {
            return null;
        }
        // Search Interface
        public interface ISearch
        {
            List<User> Search(String search);
        }
        public class SearchByID : ISearch
        {
            public List<User> Search(String search)
            {
                List<User> Results = new List<User>();
                return Results;
            }
        }
    }
}
