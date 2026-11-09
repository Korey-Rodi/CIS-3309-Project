using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_3309_Term_Project
{
    internal class UserCollectionController
    {
        private UserCollection Users; 
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
            
        }
        public List<User> LoadUsers()
        {

        }
        public User ValidateUser(String username, String password)
        {
            
        }
        public int GetTotalUsers()
        {
            // Place holder code
            return 0;
        }
        public List<User> LoadUsersByDept()
        {

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
