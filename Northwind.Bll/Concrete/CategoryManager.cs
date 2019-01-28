using Northwind.Dal.Abstract;
using Northwind.Entities;
using Northwind.Interfaces;
using System.Collections.Generic;

namespace Northwind.Bll.Concrete
{
    public class CategoryManager : ICategory
    {
        ICategoryDal categoryDal;
        public CategoryManager(ICategoryDal _categoryDal) => categoryDal = _categoryDal;

        public void Add(Category category) => categoryDal.Add(category);

        public void Delete(int id) => categoryDal.Delete(id);

        public List<Category> GetAll() => categoryDal.GetAll();

        public Category GetByID(int id) => categoryDal.GetByID(id);
        
        public void Update(Category category) => categoryDal.Update(category);
    }
}
