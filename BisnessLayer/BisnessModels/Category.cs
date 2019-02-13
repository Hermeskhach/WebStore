using BisnessLayer.Interfaces;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BisnessLayer.BisnessModels
{
   public class Category: DataAccessManager,ICategory
    {
        public int? Id { get; set; }
        public string Name { get; set; }




        public static IEnumerable<ICategory> GetCategories()
        {
            return ExexuteSPWithResult<Category>("GetAllCategories");
           
        }
    }


    

}
