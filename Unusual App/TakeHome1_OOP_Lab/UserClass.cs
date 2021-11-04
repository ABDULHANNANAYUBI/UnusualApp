using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHome1_OOP_Lab
{

    class UserClass
    {
        private UserClass() { }

        private static UserClass instance = null;
        public static UserClass Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserClass();
                }
                return instance;
            }
        }
        private List<string> usernames = new List<string>();
        private List<string> passwords = new List<string>();
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public List<string> Usernames { get => usernames; set => usernames = value; }
        public List<string> Passwords { get => passwords; set => passwords = value; }

        public void Add(string username, string password)
        {
            this.Usernames.Add(username) ;
            this.Passwords.Add(password);
        }

    }
}
