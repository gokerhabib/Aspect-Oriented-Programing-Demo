using AOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP.DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();

        Product GetId(Product product);
    }
}
