﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCompDotNet
{
    public class Product
    {
        public virtual int Id
        {
            get;
            set;
        }

        public virtual string Name
        {
            get;
            set;
        }


        public virtual int Price
        {
            get;
            set;
        }

        public virtual string Description
        {
            get;
            set;
        }

    }
}
