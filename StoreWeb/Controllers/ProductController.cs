using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BisnessLayer.BisnessModels;
using BisnessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using StoreWeb.Models;

namespace StoreWeb.Controllers
{
    public class ProductController : Controller
    {

        private IEnumerable<IProductable> products;

        public IActionResult Index()
        {
            return View();
        }

       public IActionResult ListProducts()
        {

             products= ProductVm.GetProducts();

            return View(products);
        }

        public IActionResult AddProduct()
        {
            return View(new Product());
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            product.AddProduct();
            return RedirectToAction("ListProducts");

        }


        public IActionResult EditProduct(int? productId)
        {
            IProductable prod = products.Where(p => p.Id == productId).FirstOrDefault();
            return View(prod);
        }

        
    }
}