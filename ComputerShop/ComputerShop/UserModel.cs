using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    class UserModel
    {
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        private String firstName;

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private String lastName;

        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private String login;
        public String Login
        {
            get { return login; }
            set { login = value; }
        }
        private String password;
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        private long id_role;
        public long Id_role
        {
            get { return id_role; }
            set { id_role = value; }
        }
        }
}
