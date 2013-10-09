using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.models.impl
{
    interface ExecuteCommand
    {
        bool add(string[] args);

        string getHelp();

        string getShow();

    }
}
