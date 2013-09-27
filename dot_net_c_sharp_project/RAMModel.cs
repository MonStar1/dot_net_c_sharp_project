using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dot_net_c_sharp_project
{
    class RAMModel
    {
        private long id;

        private String name;

        private String memorytype;

        private double price;

        private int frequency;

        private int size;

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


        public String MemoryType
        {
            get { return memorytype; }
            set { memorytype = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Frequency
        {
            get { return frequency; }
            set { frequency = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }
    }
}


