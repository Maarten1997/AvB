using Avb.DAL;
using System;

namespace Avb.Logic
{
    public class User
    {
     public string Username { get; private set; }
     public string Password { get; private set; }

        public User()
        {
            
        }
        public bool Login(string username, string password)
        {
            Userdata userdata = new Userdata();
            return userdata.Login(username, password);
        }
    }
}
