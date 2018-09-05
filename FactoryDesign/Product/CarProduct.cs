using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class CarProduct:IProduct
    {
        public string GetTypeOfProduct()
        {
            return "Car";
        }
        public void Book()
        {
            Console.WriteLine("Booking Car Product");
        }
        public void Save()
        {
            Console.WriteLine("Saving Car Product");
        }
    }
}
