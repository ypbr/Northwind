using Northwind.Dal.Abstract;
using Northwind.Entities;
using Northwind.Interfaces;
using System.Collections.Generic;

namespace Northwind.Bll.Concrete
{
    public class ProductManager : IProduct
    {
        private IProductDal productDal;
        public ProductManager(IProductDal _productDal) => productDal = _productDal;

        public void Add(Product product) => productDal.Add(product);

        public void Delete(int id) => productDal.Delete(id);

        public List<Product> GetAll() => productDal.GetAll();

        public List<Product> GetByCatID(int CatID) => productDal.GetByCatID(CatID);
        public Product GetByID(int id) => productDal.GetByID(id);

        public void Update(Product product) => productDal.Update(product);
    }
}
