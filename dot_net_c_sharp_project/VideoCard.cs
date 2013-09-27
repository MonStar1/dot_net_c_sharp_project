using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dot_net_c_sharp_project
{
    class VideoCard
    {
private long id;

        private String name;

        private String graphicsprocessor;

        private double price;

        private int frequency;

        private int videomemory;

        private int gpuclock;

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


        public String GraphicsProcessor
        {
            get { return graphicsprocessor; }
            set { graphicsprocessor = value; }
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

        public int VideoMemory
        {
            get { return videomemory; }
            set { videomemory = value; }
        }

        public int GPUClock
        {
            get {return gpuclock; }
            set {gpuclock = value; }
        }
    }
}

