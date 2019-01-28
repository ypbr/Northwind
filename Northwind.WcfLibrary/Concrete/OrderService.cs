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
    public class OrderService : IOrder
    {
        IOrderDal orderDal;
        public OrderService(IOrderDal _orderDal) => orderDal = _orderDal;
        public void Add(Order order) => orderDal.Add(order);

        public void Delete(int id) => orderDal.Delete(id);

        public List<Order> GetAll() => orderDal.GetAll();

        public Order GetBeyID(int id) => orderDal.GetBeyID(id);

        public void Update(Order order) => orderDal.Update(order);
    }
}
