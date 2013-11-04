using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCompDotNet.callback
{
    class AddCallback
    {
        public delegate void callbackEvent(Product product);
        public static callbackEvent callbackEventHandler;
    }
}
