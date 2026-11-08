using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_3309_Term_Project
{
    internal class User
    {
        public String UserID {  get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Department { get; set; }
        public String ProfilePicture { get; set; }

        public User(String userId, String username, String password, String firstName, String lastName, String department,
            String profilePictureUrl)
        {
            this.UserID = userId;
            this.Username = username;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Department = department;
            this.ProfilePicture = profilePictureUrl;
        }

    }
}
