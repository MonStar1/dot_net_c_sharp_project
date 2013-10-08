using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    class DiscountModel
    {

        private long id;
        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        private double percent;
        public double Percent
        {
            get { return percent; }
            set { percent = value; }
        }

        private long time_start;
        public long Time_Start
        {
            get { return time_start; }
            set { time_start = value; }
        }

        private long time_end;
        public long Time_End
        {
            get { return time_end; }
            set { time_end = value; }
        }

    }
}
