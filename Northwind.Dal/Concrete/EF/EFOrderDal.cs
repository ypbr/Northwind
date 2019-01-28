using Northwind.Dal.Abstract;
using Northwind.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Northwind.Dal.Concrete.EF
{
    public class EFOrderDal : IOrderDal
    {
        private NorthwindContext db;
        public EFOrderDal(NorthwindContext _db) => db = _db;
        public void Add(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Orders.Remove(db.Orders.FirstOrDefault(w => w.OrderID == id));
            db.SaveChanges();
        }

        public List<Order> GetAll() => db.Orders.ToList();

        public Order GetByID(int id) => db.Orders.FirstOrDefault(f => f.OrderID == id);

        public void Update(Order order)
        {
            Order oOrder = db.Orders.FirstOrDefault(f => f.OrderID == order.OrderID);

            oOrder.OrderDate = order.OrderDate;
            oOrder.ShipCity = order.ShipCity;
            oOrder.ShipCountry = order.ShipCountry;
            db.SaveChanges();
        }
    }
}
