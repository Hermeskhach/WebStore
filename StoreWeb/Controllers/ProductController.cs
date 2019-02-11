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

        private IProductRepository repository;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

       public IActionResult ListProducts()
        {
            return View(new ProductVm {
                Products=repository.Products
                .OrderBy(p=>p.Id)
            });
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
            IProductable prod = repository.Products.Where(p => p.Id == productId).FirstOrDefault();
            return View(prod);
        }

        
    }
}