using BisnessLayer.BisnessModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BisnessLayer.Interfaces
{
   public interface ICategoryRepository
    {
        IEnumerable<ICategory> Сotegories { get; }
    }
}
