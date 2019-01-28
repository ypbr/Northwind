using Northwind.Dal.Abstract;
using Northwind.Entities;
using Northwind.Interfaces;
using System.Collections.Generic;

namespace Northwind.Bll.Concrete
{
    public class CustomerManager : ICustomer
    {
        ICustomerDal customerDal;
        public CustomerManager(ICustomerDal _customerDal) => customerDal = _customerDal;

        public void Add(Customer customer) => customerDal.Add(customer);

        public void Delete(string id) => customerDal.Delete(id);

        public List<Customer> GetAll() => customerDal.GetAll();

        public Customer GetByID(string id) => customerDal.GetByID(id);

        public void Update(Customer customer) => customerDal.Update(customer);
    }
}
