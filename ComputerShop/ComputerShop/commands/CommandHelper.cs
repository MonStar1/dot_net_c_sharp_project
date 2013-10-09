using ComputerShop.models.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.commands
{
    
    class CommandHelper
    {
        public const String ADD  = "/add";
        public const String HELP = "/?";
        public const String SHOW = "/show";
        public const String LIST = "/listmodels";

        public const String ATTRIBUTE = "attr";
        public const String NEWS = "news";

        public void executeCommand(string[] args)
        {
            if (args == null || args.Length < 1)
            {
                return;
            }
            switch (args[0])
            {
                case HELP:
                    {
                        Console.WriteLine(new HelpCommand().getHelp());
                        break;
                    }
                case SHOW:
                    {
                        ExecuteCommand cm = getCommandImpl(args[1]);
                        Console.WriteLine(cm.getShow());
                        break;
                    }
                case LIST:
                    {
                        Console.WriteLine("Models: " + NewsImpl.COMMAND);
                        break;
                    }
                case ADD:
                    {
                        ExecuteCommand cm = getCommandImpl(args[1]);
                        if (args.Length == 2)
                        {
                            Console.WriteLine(cm.getHelp());
                            break;
                        }

                        string[] param = new string[args.Length - 2];
                        for (int i = 2; i < args.Length; i++)
                        {
                            param[i - 2] = args[i];
                        }
                        cm.add(param);
                        break;
                    }
            }
        }

        private ExecuteCommand getCommandImpl(string name)
        {
            switch (name)
            {
                case ATTRIBUTE:
                    {
                        break;
                    }
                case NEWS:
                    {
                        return NewsImpl.getInstance();
                    }
            }
            return null;
        }
    }
}
