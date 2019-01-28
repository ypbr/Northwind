using Northwind.Entities;
using System.Collections.Generic;

namespace Northwind.Dal.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        Product GetByID(int id);
        List<Product> GetByCatID(int CatID);
        void Add(Product product);
        void Delete(int id);
        void Update(Product product);
    }
}
