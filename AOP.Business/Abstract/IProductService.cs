using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOP.Entities;

namespace AOP.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetId(Product product);
    }
}
