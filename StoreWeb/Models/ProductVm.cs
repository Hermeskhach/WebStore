using BisnessLayer.BisnessModels;
using BisnessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWeb.Models
{
    public class ProductVm //: IProductable
    {
        //public int Id { get ; set ; }
        //public string Name { get ; set ; }
        //public string Category { get ; set ; }
        //public decimal Price { get; set ; }
        //public string Description { get ; set ; }
        //public string PictureUri { get ; set ; }



        public static IEnumerable<IProductable> GetProducts()
        {
          return  Product.GetProducts();
        }


       

    }
}
