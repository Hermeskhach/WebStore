using System;
using System.Collections.Generic;
using System.Text;

namespace BisnessLayer.Interfaces
{
    public interface IProductable
    {
        int? Id { get; set; }
        string Name { get; set; }
        string Category { get; set; }
        float Price { get; set; }
        string Description { get; set; }
        string PictureUri { get; set; }
    }
}
