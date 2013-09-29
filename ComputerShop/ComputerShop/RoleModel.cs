using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    class RoleModel
    {
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        private short access;
        public short Access
        {
            get { return access; }
            set { access = value; }
        }
        private List<long> id_rule = new List<long>();
        public List<long> Id_rule
        {
            get { return id_rule; }
            set { id_rule = value; }
        }

        public void addId_rule(long id)
        {
            id_rule.Add(id);
        }

        public bool removeId_rule(long id)
        {
            return id_rule.Remove(id);
        }

    }
}
