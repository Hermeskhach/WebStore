using BisnessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWeb.Components
{
    public class StoreMenuViewComponent : ViewComponent
    {
        private ICategoryRepository repository;

        public StoreMenuViewComponent(ICategoryRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory =Convert.ToInt32( RouteData?.Values["category"]);
            return View(repository.Сotegories);
        }
    }
}
