using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BisnessLayer;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StoreWeb.Controllers
{
    public class HomeController : Controller
    {
        private LayerConfig config;
        public HomeController(LayerConfig conf)
        {
            config = conf;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
