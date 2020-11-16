using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;

namespace Project_4._0
{
     public static class Users
    {

        private readonly static List<User> _users;




        static Users()
        {
            _users = new List<User>();
            AddDafaultUsers(_users);
        }
            private static void AddDafaultUsers(List<User> users)
        {
            users.AddRange(new List<User>
            {
                   new User  {Name = "Ali", Surname = "Rahimzada", Age = 8, Email = "rol@gmail.com", Password = "rol50", UserRole = UserRole.User},    //("Ali", "Rahimzada", 8, "alirahimzada12@mail.ru", "Aliwka2012"),
            new User {Name = "Ulviyye", Surname = "Rahimova", Age = 30, Email = "rob@hotmail.com", Password = "rob90", UserRole = UserRole.User}, //("Ulviyye", "Rahimova", 30, "U_orucova@hotmail.com", "Ulviyye1989"),
            new User{Email = "admin", Password = "admin", UserRole = UserRole.Admin},

            }) ;
        }
    

        public static void AddUser(User user)
        {
            if (user != null)
            {
                if (!_users.Contains(user))
                {
                    _users.Add(user);
                }

            }
        }

        public static bool HasUser(User user)
        {
            bool userExists = false;
            if (user != null)
            {
                if (user != null)
                {
                    if (_users.Contains(user))
                    {
                        userExists = _users.Contains(user) ? true : false;

                    }

                }

            }
            return userExists;
        }
        public static bool HasUser(String email, string password)
        {
            bool userExists = false;
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {

                foreach (User u in _users)
                {
                    if (u != null)
                    {


                        if (u.Email == email && u.Password == password)
                        {
                            userExists = true;
                            break;
                        }
                    }
                }
            }
            return userExists;
        }

        public static User GetUser(String email, string password) 
        {
            User user = null;
            if (HasUser(email, password))
            {
                foreach (User _user in _users)
                {
                    if (_user.Email == email && _user.Password == password)
                    {
                        user = _user;
                        break;
                    }
                }
            }
            return user;
        }
        public static List<User> GetUsers()
        {
            return _users;
        }
    }
}

