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

        private long percent;
        public long Percent
        {
            get { return percent; }
            set { percent = value; }
        }

    }
}
