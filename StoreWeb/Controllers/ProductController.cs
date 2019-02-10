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
        public IActionResult Index()
        {
            return View();
        }

       public IActionResult ListProducts()
        {

            IEnumerable<IProductable> products = ProductVm.GetProducts();

            return View(products);
        }
        
    }
}