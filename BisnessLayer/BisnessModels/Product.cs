using BisnessLayer.Interfaces;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BisnessLayer.BisnessModels
{
    public class Product:IProductable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string PictureUri { get; set; }


        public static IEnumerable<IProductable> GetProducts()
        {
           IEnumerable<Product> products =  DataAccessManager.ExexuteSPWithResult<Product>("GetAllProducts");
            return products;
        }


    }
}
