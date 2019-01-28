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
    public interface IProduct
    {
        [OperationContract]
        List<Product> GetAll();

        [OperationContract]
        Product GetByID(int id);

        [OperationContract]
        List<Product> GetByCatID(int CatID);

        [OperationContract]
        void Add(Product product);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        void Update(Product product);
    }
}
