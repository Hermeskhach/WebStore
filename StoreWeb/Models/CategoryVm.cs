using BisnessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWeb.Models
{
    public class CategoryVm:ICategory
    {

        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
