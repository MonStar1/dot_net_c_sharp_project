using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot_net_c_sharp_project
{
    class Moderator
    {
        private long id;
        private String login;
        private String password;
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
    }
}
