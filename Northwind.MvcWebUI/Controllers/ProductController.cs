using Microsoft.AspNetCore.Mvc;
using Northwind.Entities;
using Northwind.Interfaces;
using Northwind.MvcWebUI.Models;
using System.Collections.Generic;
using System.Linq;

namespace Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProduct productManager;
        private ICategory categoryManager;
        public ProductController(IProduct _product, ICategory _category)
        {
            productManager = _product;
            categoryManager = _category;
        }

        private int pageSize = 10;
        public ViewResult Index(int p = 1, int c = 0)
        {
            int _skip = (p - 1) * pageSize;
            List<Product> _products = c== 0 ? productManager.GetAll() : productManager.GetByCatID(c);
            List<Category> _categories = categoryManager.GetAll();
            ProductIndexModel model = new ProductIndexModel()
            {
                products = _products.Skip(_skip).Take(pageSize).ToList(),
                categories = _categories,
                currentCategoryName = _categories.Where(w => w.CategoryID == c).Select(s => s.CategoryName).FirstOrDefault(),
                PagingInfo = new PagingInfo()
                {
                    currentPage = p,
                    totalProductCount = _products.Count(),
                    pageSize = pageSize,
                    currentCategory = c
                }
            };
            return View(model);
        }

    }
}