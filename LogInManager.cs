using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginMenu
{
    public class LoginManager
    {
        private List<User> _users;
        public LoginManager()
        {
            _users = new List<User>();
            //Fylla på några users.
            _users.Add(new User("Jana", "Jana123"));
            _users.Add(new User("Micke", "Micke.123"));
            _users.Add(new User("Loke", "Loke0006"));
        }
        public bool Login(string username, string password)
        {
            foreach(var user in _users)
            {
                if (user.UserName == username && user.PassWord == password) 
                {
                    return true;
                }
            }
            return false;
        }
    }
}
