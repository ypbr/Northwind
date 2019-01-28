using Northwind.Dal.Abstract;
using Northwind.Entities;
using Northwind.Interfaces;
using System.Collections.Generic;

namespace Northwind.Bll.Concrete
{
    public class OrderManager : IOrder
    {
        IOrderDal orderDal;
        public OrderManager(IOrderDal _orderDal) => orderDal = _orderDal;

        public void Add(Order order) => orderDal.Add(order);

        public void Delete(int id) => orderDal.Delete(id);

        public List<Order> GetAll() => orderDal.GetAll();

        public Order GetBeyID(int id) => orderDal.GetByID(id);

        public void Update(Order order) => orderDal.Update(order);
    }
}