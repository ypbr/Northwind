using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Interfaces
{
    [ServiceContract]
    public interface ICategory
    {
        [OperationContract]
        List<Category> GetAll();

        [OperationContract]
        Category GetByID(int id);

        [OperationContract]
        void Add(Category category);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        void Update(Category category);
    }
}
