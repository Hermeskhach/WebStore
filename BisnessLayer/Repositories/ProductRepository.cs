using BisnessLayer.BisnessModels;
using BisnessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BisnessLayer.Repositories
{
   public class ProductRepository : IProductRepository
    {
        public IEnumerable<IProductable> Products { get; set; }

        public ProductRepository()
        {
            Products = Product.GetProducts();
        }

    }
}
