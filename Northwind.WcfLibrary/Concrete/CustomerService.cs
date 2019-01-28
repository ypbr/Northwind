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
    public class CustomerService : ICustomer
    {
        //private CustomerManager customerManager = new CustomerManager(new EFCustomerDal());
        ICustomerDal customerDal;
        public CustomerService(ICustomerDal _customerDal) => customerDal = _customerDal;
        public void Add(Customer customer) => customerDal.Add(customer);

        public void Delete(string id) => customerDal.Delete(id);

        public List<Customer> GetAll() => customerDal.GetAll();

        public Customer GetByID(string id) => customerDal.GetByID(id);

        public void Update(Customer customer) => customerDal.Update(customer);
    }
}
