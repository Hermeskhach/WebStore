using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BisnessLayer;
using BisnessLayer.BisnessModels;
using BisnessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using StoreWeb.Models;
using StoreWeb.Models.ViewModels;

namespace StoreWeb.Controllers
{
    public class ProductController : Controller
    {
       
        private IProductRepository repository;

        public int PageSize = 1;

        public ProductController(IProductRepository repo)
        {
            
            repository = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListProducts(int? category, int productPage=1)

        {
            return View(new ProductListView
            {
                Products = repository.Products
                .Where(p => category == null || p.CategoryId == category)
                .OrderBy(p => p.Id)
                .Skip((productPage - 1) * PageSize).Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Count()
                },
                CurrentCategory = category
            });
        }

        public IActionResult AddProduct()
        {

            return View("CreateProduct", new ProductViewModel());
        }

        [HttpPost]
        public IActionResult AddProduct(ProductViewModel product)
        {
            Product.AddProduct((IProductable)product);


            return RedirectToAction("ListProducts");

        }


        public IActionResult EditProduct(int? productId)
        {

            return View();
        }


    }
}