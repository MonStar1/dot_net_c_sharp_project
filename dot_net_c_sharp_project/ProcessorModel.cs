using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot_net_c_sharp_project
{
    class ProcessorModel
    {
        private long id;

        private String name;

        private String manufacturer;

        private String model;

        private double price;

        private double cpuSpeed;

        private double cache;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public String Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public String Model
        {
            get { return model; }
            set { model = value; }
        }
    }
}
