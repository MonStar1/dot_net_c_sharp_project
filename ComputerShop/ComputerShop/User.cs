using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    class User
    {
        private long id;
        public long Id
        {
            get { return id; }
            set { id = value; }
        }


        private string login;
        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string firstname;
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        private string secondname;
        public string Secondname
        {
            get { return secondname; }
            set { secondname = value; }
        }

    }
}
