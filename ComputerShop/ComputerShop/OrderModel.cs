using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    class OrderModel
    {
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        private long summeryPrice;

        public long SummeryPrice
        {
            get { return summeryPrice; }
            set { summeryPrice = value; }
        }


        private long idUser;

        public long IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }



        private List<long> idProducts = new List<long>();

        public List<long> IdProducts
        {
            get { return idProducts; }
            set { idProducts = value; }
        }

        public void addIdProducts(long id)
        {
            idProducts.Add(id);
        }

        public bool removeIdProducts(long id)
        {
            return idProducts.Remove(id);
        }

        private long idDiscount;

        public long IdDiscount
        {
            get { return idDiscount; }
            set { idDiscount = value; }
        }


        private long idCredit;

        public long IdCredit
        {
            get { return idCredit; }
            set { idCredit = value; }
        }

        private long idDelivery;

        public long IdDelivery
        {
            get { return idDelivery; }
            set { idDelivery = value; }
        }


        private List<long> idComputers = new List<long>();

        public List<long> IdComputers
        {
            get { return idComputers; }
            set { idComputers = value; }
        }

        public void addIdComputers(long id)
        {
            idComputers.Add(id);
        }

        public bool removeIdComputers(long id)
        {
            return idComputers.Remove(id);
        }

    }
}
