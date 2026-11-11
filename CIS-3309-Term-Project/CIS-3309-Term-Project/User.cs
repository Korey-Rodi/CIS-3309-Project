using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_3309_Term_Project
{
    public class User
    {
        public int UserID {  get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String PhoneNumber {get; set;}
        public String Address {get; set;}
        public String City {get; set;}
        public String State {get; set;}
        public enum Department
        {
            // when creating a user convert the department with ToString()
            // before passing to the database
            IT,HR,Finance,Claims,Facility
        }
        public Department UserDepartment {get; set;}
        public String ProfilePicture { get; set; }

        public User(int userId, String username, String password, String firstName, String lastName, 
        String phoneNumber,String address, String city, String state,Department userDepartment, String profilePictureUrl)
        {
            this.UserID = userId;
            this.Username = username;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.UserDepartment = userDepartment;
            this.ProfilePicture = profilePictureUrl;
        }

    }
}
