using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.models.impl
{
    class ListCommand : ExecuteCommand
    {
        public bool add(string[] args)
        {
            throw new NotImplementedException();
        }

        public string getHelp()
        {
            return ":";
        }

        public string getShow()
        {
            throw new NotImplementedException();
        }
    }
}
