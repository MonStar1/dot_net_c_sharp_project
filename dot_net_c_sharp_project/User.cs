using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot_net_c_sharp_project
{
    class User
    {
        private long id;
        private String login;
        private String password;
        private DateTime dateOfRegistration;
        private String email;
        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Login
        {
            get { return login; }
            set { login = value; }
        }
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        public DateTime DateOfRegistration
        {
            get { return dateOfRegistration; }
            set { dateOfRegistration = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
