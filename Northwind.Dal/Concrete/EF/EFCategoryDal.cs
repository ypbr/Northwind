using Northwind.Dal.Abstract;
using Northwind.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Northwind.Dal.Concrete.EF
{
    public class EFCategoryDal : ICategoryDal
    {
        private NorthwindContext db;
        public EFCategoryDal(NorthwindContext _db) => db = _db;
        public void Add(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Categories.Remove(db.Categories.FirstOrDefault(w => w.CategoryID == id));
            db.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public Category GetByID(int id)
        {
            return db.Categories.FirstOrDefault(w => w.CategoryID == id);
        }

        public void Update(Category category)
        {
            Category oCategory = db.Categories.FirstOrDefault(f => f.CategoryID == category.CategoryID);
            oCategory.CategoryName = category.CategoryName;
            db.SaveChanges();
        }
    }
}
