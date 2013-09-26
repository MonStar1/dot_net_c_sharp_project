using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dot_net_c_sharp_project
{
    class Order
    {
 private long id;

        private String login;

        private String hardware;

        private double price;
        
        public long Id
        {
            get {return id; }
            set {id = value; }
        }

        public String Login
        {
            get {return login; }
            set {login = value; }
        }

        public String Hardware
        {
            get {return hardware; }
            set {hardware = value; }
        }

        public double Price
        {
            get {return price; }
            set {price = value; }
        }
    }
}

