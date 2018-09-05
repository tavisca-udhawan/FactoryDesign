using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Product
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Products factory = new ProductsCheck();
            Console.WriteLine("Car----\nAir----");
            Console.WriteLine("Enter Product:");
            string description = Console.ReadLine();
            IProduct product = factory.GetProduct(description);
            product.GetTypeOfProduct();
            product.Book();
            product.Save();
            Console.ReadKey();
        }
       
    }
}
