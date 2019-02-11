using BisnessLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.DataAccessTools;
using System.Collections.Generic;

namespace BisnessLayer.BisnessModels
{
    internal class Product : DataAccessManager, IProductable
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string PictureUri { get; set; }


        public static IEnumerable<IProductable> GetProducts()
        {
            IEnumerable<Product> products = ExexuteSPWithResult<Product>("GetAllProducts");
            return products;
        }




        public void AddProduct()
        {
            List<SPParam> parameters = new List<SPParam>
            {
                new SPParam("Name", this.Name),
                new SPParam("Category", this.Category),
                new SPParam("Price", this.Price),
                new SPParam("Description", this.Description),
                new SPParam("PictureUri", this.PictureUri),
            };

            ExecuteSpNonQuery("AddProduct", parameters);
        }


        public void EditProduct()
        {
            List<SPParam> parameters = new List<SPParam>()
            {
                new SPParam("Id", this.Id),
                new SPParam("Name", this.Name),
                new SPParam("Category", this.Category),
                new SPParam("Price", this.Price),
                new SPParam("Description", this.Description),
                new SPParam("PictureUri", this.PictureUri),
            };

            ExecuteSpNonQuery("EditProduct", parameters);
        }


        public void DeleteProduct()
        {
            List<SPParam> parameters = new List<SPParam>()
            {
                new SPParam("Id", this.Id )
            };

            ExecuteSpNonQuery("DeleteProduct", parameters);
        }
    }
}
