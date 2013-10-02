using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    class PreviousPriceModel
    {
        private long id;
        public long Id
        {
            get { return id; }
            set { id = value; }
        }


        private String time_start;
        public String Time_Start
        {
            get { return time_start; }
            set { time_start = value; }
        }

        private String time_end;
        public String Time_End
        {
            get { return time_end; }
            set { time_end = value; }
        }




    }
}
