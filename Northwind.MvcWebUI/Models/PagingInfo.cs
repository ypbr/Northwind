using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.MvcWebUI.Models
{
    public class PagingInfo
    {
        public int currentPage { get; set; }
        public int pageSize { get; set; }
        public int totalProductCount { get; set; }
        public int currentCategory { get; internal set; }
    }
}
