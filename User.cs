using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginMenu
{
    public class User
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public User(string username, string password)
        {
            UserName = username;
            PassWord = password;
        }
    }
}
