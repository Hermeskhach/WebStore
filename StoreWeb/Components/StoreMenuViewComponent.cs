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
            var data = RouteData?.Values["category"];
            int number;
            if (data != null)
            {
                bool success = Int32.TryParse(data.ToString(), out number);
                if (success)
                {
                    ViewBag.SelectedCategory = number;
                }
                else
                {
                    ViewBag.SelectedCategory = null;
                }
            }


            return View(repository.Сotegories);
            
            
        }
    }
}
