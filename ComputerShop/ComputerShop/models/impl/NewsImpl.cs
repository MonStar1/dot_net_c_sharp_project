using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.models.impl
{
    class NewsImpl : ExecuteCommand
    {
        public const string COMMAND = "news";
        List<NewsModel> listModels = new List<NewsModel>();
        private static NewsImpl instance;

        private NewsImpl()
        {
        }

        public static NewsImpl getInstance()
        {
            if (instance == null)
            {
                instance = new NewsImpl();
            }
            return instance;
        }

        public bool add(string[] args)
        {
            NewsModel model = new NewsModel();
            model.Shortdescription = args[0];
            model.Longdescription = args[1];
            listModels.Add(model);
            return true;
        }

        public string getHelp()
        {
            return "/add " + COMMAND + " [SHORT DESCRIPTION] [LONG DESCRIPTION]";
        }

        public string getShow()
        {
           String str = "";
           foreach(NewsModel model in listModels){
               str += model.ToString() + " \n";
           }
           return str;
        }
    }
}
