using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot_net_c_sharp_project
{
    class ComputerModel
    {
        private long id;

        private String name;

        private double price;

        private MotherboardModel motherboard;

        private ProcessorModel processor;

        private PSUModel psu;

        //-----TODO: add new model of example

        //private VideocardModel video;
        private KeyboardModel keyboard;
        
        private MouseModel mouse;
        //pribate HDDModel hdd;

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

        public MotherboardModel Motherboard
        {
            get { return motherboard; }
            set { motherboard = value; }
        }

        public ProcessorModel Processor
        {
            get { return processor; }
            set { processor = value; }
        }

        public PSUModel Psu
        {
            get { return psu; }
            set { psu = value; }
        }

        public KeyboardModel Keyboard
        {
            get { return keyboard; }
            set { keyboard = value; }
        }

        public MouseModel Mouse
        {
            get { return mouse; }
            set { mouse = value; }
        }

    }
}
