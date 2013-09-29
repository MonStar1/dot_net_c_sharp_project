using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    class ProductModel
    {
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private String madeBy;

        public String MadeBy
        {
            get { return madeBy; }
            set { madeBy = value; }
        }

        private long price;

        public long Price
        {
            get { return price; }
            set { price = value; }
        }

        private String description;

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        private List<long> idAttributes = new List<long>();

        public List<long> IdAttributes
        {
            get { return idAttributes; }
            set { idAttributes = value; }
        }

        public void addIdAttribute(long id)
        {
            idAttributes.Add(id);
        }

        public bool removeIdAttribute(long id)
        {
            return idAttributes.Remove(id);
        }
    }
}
