﻿using E002.AbstractFactory.AbstractClass.Product;
using E002.AbstractFactory.AbstractClass.SubProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E002.AbstractFactory.AbstractClass.Factory
{
    public class Gen2_Factory : BaseFactory
    {
        public override BaseProduct GetProduct()
        {
            return new Gen2_Product();
        }

        public override BaseSubProduct GetSubProduct()
        {
            return new Gen2_SubProduct();
        }
    }
}
