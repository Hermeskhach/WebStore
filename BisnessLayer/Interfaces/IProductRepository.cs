using System;
using System.Collections.Generic;
using System.Text;

namespace BisnessLayer.Interfaces
{
   public interface IProductRepository
    {
        IEnumerable<IProductable> Products { get; }
    }
}
