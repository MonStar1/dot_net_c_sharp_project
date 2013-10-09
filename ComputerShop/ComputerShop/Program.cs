using ComputerShop.commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandHelper ch = new CommandHelper();

            args = new string[4];
            args[0] = "/add";
            args[1] = "news";
            args[2] = "1";
            args[3] = "two";
            ch.executeCommand(args);

            args = new string[4];
            args[0] = "/add";
            args[1] = "news";
            args[2] = "2";
            args[3] = "3";
            ch.executeCommand(args);

            args = new string[2];
            args[0] = "/show";
            args[1] = "news";
            ch.executeCommand(args);

            Console.ReadKey();
        }
    }
}
