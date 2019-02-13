using BisnessLayer.BisnessModels;
using BisnessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BisnessLayer.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<ICategory> Сotegories { get;private set; }

        public CategoryRepository()
        {
            Сotegories = Category.GetCategories();
        }
    }
}
