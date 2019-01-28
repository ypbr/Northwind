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
    public interface IOrder
    {
        [OperationContract]
        List<Order> GetAll();

        [OperationContract]
        Order GetBeyID(int id);

        [OperationContract]
        void Add(Order order);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        void Update(Order order);
    }
}
