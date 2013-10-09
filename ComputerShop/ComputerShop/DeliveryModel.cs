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

        private long time_max;

        public long Time_max
        {
            get { return time_max; }
            set { time_max = value; }
        }

    }
}
