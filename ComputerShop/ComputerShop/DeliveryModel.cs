using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    class DeliveryModel
    {
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        private String address;

        public String Address
        {
            get { return address; }
            set { address = value; }
        }

        private long price;

        public long Price
        {
            get { return price; }
            set { price = value; }
        }

        private long time;

        public long Time
        {
            get { return time; }
            set { time = value; }
        }

        private String timeAsString;

        public String TimeAsString
        {
            get { return timeAsString; }
            set { timeAsString = value; }
        }


    }
}
