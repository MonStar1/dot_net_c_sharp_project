using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    class ProductModel
    {
        private float id;

        public float Id
        {
            get { return id; }
            set { id = value; }
        }

        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
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
