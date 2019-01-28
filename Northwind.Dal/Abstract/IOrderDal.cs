using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Abstract
{
    public interface IOrderDal
    {
        List<Order> GetAll();
        Order GetByID(int id);
        void Add(Order order);
        void Delete(int id);
        void Update(Order order);
    }
}
