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
 
        public  IEnumerable<IProductable> Products { get; set; }
       

    }
}
