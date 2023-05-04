using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Try101LinqSamples;

namespace LINQSampleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> ls = Products.GetAllProducts();
            foreach(Product p in ls)
            {
                Console.WriteLine(p);
            }
        }
    }
}
