﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot_net_c_sharp_project
{
    class PSUModel
    {
        private long id;

        private String name;

        private String madeby;

        private String model;

        private double price;

        private int energy;

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

        public String Madeby
        {
            get { return madeby; }
            set { madeby = value; }
        }

        public String Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Energy
        {
            get { return energy; }
            set { energy = value; }
        }
    }
}