using Northwind.Dal.Abstract;
using Northwind.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Northwind.Dal.Concrete.EF
{
    public class EFProductDal : IProductDal
    {
        private NorthwindContext db;
        public EFProductDal(NorthwindContext _db) => db = _db;

        public void Add(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Products.Remove(db.Products.FirstOrDefault(w => w.ProductID == id));
            db.SaveChanges();
        }

        public List<Product> GetAll() =>
            db.Products.ToList();

        public List<Product> GetByCatID(int CatID) => 
            db.Products.Where(w => w.CategoryID == CatID).ToList();

        public Product GetByID(int id) => 
            db.Products.FirstOrDefault(f => f.ProductID == id);

        public void Update(Product product)
        {
            Product oProduct = db.Products.FirstOrDefault(w => w.ProductID == product.ProductID);

            oProduct.CategoryID = product.CategoryID;
            oProduct.ProductName = product.ProductName;
            oProduct.UnitPrice = product.UnitPrice;
            oProduct.UnitsInstock = product.UnitsInstock;
            db.SaveChanges();
        }
    }
}
