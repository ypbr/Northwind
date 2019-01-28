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
    public interface ICustomer
    {
        [OperationContract]
        List<Customer> GetAll();

        [OperationContract]
        Customer GetByID(string id);

        [OperationContract]
        void Add(Customer customer);

        [OperationContract]
        void Delete(string id);

        [OperationContract]
        void Update(Customer customer);
    }
}
