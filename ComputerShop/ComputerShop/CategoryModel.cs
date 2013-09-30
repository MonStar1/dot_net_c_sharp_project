using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    class CategoryModel
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
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

        private long id_computer;

        public long Id_Computer
        {
            get { return id_computer; }
            set { id_computer = value; }
        }
    }
}
