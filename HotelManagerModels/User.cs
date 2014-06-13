using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagerModels
{
    public class User
    {
        public User() { }
        public User(int userId, string username, string mobile, string email,string password)
        {
            this.Id = userId;
            this.Name = username;
            this.Mobile = mobile;
            this.Email = email;
            this.Password = password;
        }
        public User(int userId, string username, string mobile, string email)
        {
            this.Id = userId;
            this.Name = username;
            this.Mobile = mobile;
            this.Email = email;

        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }



        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string mobile;
        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
      
      
    }
}
