using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCompDotNet
{
    class Order
    {
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        private long id_user;

        public long Id_user
        {
            get { return id_user; }
            set { id_user = value; }
        }

        private long id_baskets;

        public long Id_baskets
        {
            get { return id_baskets; }
            set { id_baskets = value; }
        }
 
        private long id_delivery;

        public long Id_delivery
        {
            get { return id_delivery; }
            set { id_delivery = value; }
        }
    }
}
