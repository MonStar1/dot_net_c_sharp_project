using ComputerShop.commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.models.impl
{
    class HelpCommand : ExecuteCommand
    {
        public const String SPACE = " ";
        public bool add(string[] args)
        {
            throw new NotImplementedException();
        }

        public string getHelp()
        {
            return "List commands: " + CommandHelper.ADD + SPACE + CommandHelper.SHOW + SPACE + CommandHelper.LIST;
        }

        public string getShow()
        {
            throw new NotImplementedException();
        }
    }
}
