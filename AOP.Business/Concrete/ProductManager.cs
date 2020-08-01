using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOP.Business.Abstract;
using AOP.DataAccess.Abstract;
using AOP.Entities;
using Core.Aspect.Logging;



namespace AOP.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        [LogAspect]
        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product GetId(Product product)
        {
            return _productDal.GetId(product);
        }
    }
}
