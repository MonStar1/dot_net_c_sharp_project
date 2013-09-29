using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    class ComputerModel
    {
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        private List<long> id_products = new List<long>();
        public List<long> Id_products
        {
            get { return id_products; }
            set { id_products = value; }
        }

        public void addId_products(long id)
        {
            id_products.Add(id);
        }

        public bool removeId_products(long id)
        {
            return id_products.Remove(id);
        }
        private String description;
        public String Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
