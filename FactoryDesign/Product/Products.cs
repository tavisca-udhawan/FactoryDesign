﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public abstract class Products
    {
        public abstract IProduct GetProduct(string desc);
    }
}
