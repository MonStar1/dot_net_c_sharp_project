using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCompDotNet
{
    class Computer
    {
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private String description;
        public String Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
