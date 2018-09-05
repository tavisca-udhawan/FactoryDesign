using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class ProductsCheck:Products
    {
        public override IProduct GetProduct(string desc)
        {
            switch (desc)
            {
                case "Car":
                    return new CarProduct();
                case "Air":
                    return new AirProduct();
                default:
                    throw new ApplicationException(string.Format("Product '{0}' cannot be created", desc));

            }
        }
    }
}
