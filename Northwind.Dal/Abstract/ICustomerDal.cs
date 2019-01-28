using Northwind.Entities;
using System.Collections.Generic;

namespace Northwind.Dal.Abstract
{
    public interface ICustomerDal
    {
        List<Customer> GetAll();
        Customer GetByID(string id);
        void Add(Customer customer);
        void Delete(string id);
        void Update(Customer customer);
    }
}
