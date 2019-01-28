using Northwind.Entities;
using System.Collections.Generic;

namespace Northwind.Dal.Abstract
{
    public interface ICategoryDal
    {
        List<Category> GetAll();
        Category GetByID(int id);
        void Add(Category category);
        void Delete(int id);
        void Update(Category category);
    }
}
