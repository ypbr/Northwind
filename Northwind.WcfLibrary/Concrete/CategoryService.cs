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
    public class CategoryService : ICategory
    {
        //private CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
        ICategoryDal categoryDal;
        public CategoryService(ICategoryDal _categoryDal) => categoryDal = _categoryDal;
        public void Add(Category category) => categoryDal.Add(category);

        public void Delete(int id) => categoryDal.Delete(id);

        public List<Category> GetAll() => categoryDal.GetAll();

        public Category GetByID(int id) => categoryDal.GetByID(id);

        public void Update(Category category) => categoryDal.Update(category);
    }
}
