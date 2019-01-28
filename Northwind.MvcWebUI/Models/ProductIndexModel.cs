using Northwind.Entities;
using System.Collections.Generic;

namespace Northwind.MvcWebUI.Models
{
    public class ProductIndexModel
    {
        public List<Product> products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public List<Category> categories { get; internal set; }
        public string currentCategoryName { get; internal set; }
    }
}
