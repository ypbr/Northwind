using Northwind.Dal.Abstract;
using Northwind.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Northwind.Dal.Concrete.EF
{
    public class EFCustomerDal : ICustomerDal
    {
        private NorthwindContext db;
        public EFCustomerDal(NorthwindContext _db) => db = _db;
        public void Add(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
        }

        public void Delete(string id)
        {
            db.Customers.Remove(db.Customers.FirstOrDefault(w => w.CustomerID == id));
            db.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            return db.Customers.ToList();
        }

        public Customer GetByID(string id)
        {
            return db.Customers.FirstOrDefault(f => f.CustomerID == id);
        }

        public void Update(Customer customer)
        {
            Customer oCustomer = db.Customers.FirstOrDefault(f => f.CustomerID == customer.CustomerID);
            oCustomer.City = customer.City;
            oCustomer.CompanyName = customer.CompanyName;
            oCustomer.ContactName = customer.ContactName;
            oCustomer.Country = customer.Country;
            db.SaveChanges();

        }
    }
}
