using BisnessLayer.BisnessModels;
using BisnessLayer.Interfaces;
using StoreWeb.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWeb.Models
{
    public class ProductListView
    {

        public IEnumerable<IProductable> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }

    }
}
