using Northwind.Bll.Concrete;
using Northwind.Dal.Abstract;
using Northwind.Dal.Concrete.EF;
using Northwind.Entities;
using Northwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.WcfLibrary.Concrete
{
    public class ProductService : IProduct
    {
        IProductDal productDal;
        public ProductService(IProductDal _productDal) => productDal = _productDal;
        public void Add(Product product) => productDal.Add(product);

        public void Delete(int id) => productDal.Delete(id);

        public List<Product> GetAll() => productDal.GetAll();

        public Product GetByID(int id) => productDal.GetByID(id);

        public void Update(Product product) => productDal.Update(product);
    }
}
