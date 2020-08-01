using AOP.Business.Concrete;
using AOP.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager _productManager = new ProductManager(new EfProductDal());

            foreach (var product in _productManager.GetAll())
            {
                Console.WriteLine(product.Name);
            }

            Console.ReadLine();
        }
    }
}
