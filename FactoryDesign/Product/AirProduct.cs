using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class AirProduct:IProduct
    {
            public string GetTypeOfProduct()
            {
                return "Air";
            }
            public void Book()
            {
                Console.WriteLine("Booking Air Product");
            }
            public void Save()
            {
                Console.WriteLine("Saving Air Product");
            }
        }
}
