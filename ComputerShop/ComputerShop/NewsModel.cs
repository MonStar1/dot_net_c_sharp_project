using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    class NewsModel
    {
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        private string shortdescription;

        public string Shortdescription
        {
            get { return shortdescription; }
            set { shortdescription = value; }
        }

        private string longdescription;

        public string Longdescription
        {
            get { return longdescription; }
            set { longdescription = value; }
        }


    }
}
