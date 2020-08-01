using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOP.DataAccess.Abstract;
using AOP.Entities;

namespace AOP.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product{Id = 1,Name = "Televizyon"},
                new Product{Id = 2,Name = "Bilgisayar"},
            };
        }
        public Product GetId(Product product)
        {
            return new Product { Id = 2, Name = "Bilgisayar" };
        }
    }
}
