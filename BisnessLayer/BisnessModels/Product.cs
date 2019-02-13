using BisnessLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.DataAccessTools;
using System.Collections.Generic;
using System.Linq;

namespace BisnessLayer.BisnessModels
{
    public class Product : DataAccessManager, IProductable
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string PictureUri { get; set; }
        public Category Category { get; set; }


        public static IEnumerable<Product> GetProducts()
        {
            IEnumerable<Product> products = ExexuteSPWithResult<Product>("GetAllProducts");
            return products;
        }




        public static void AddProduct(IProductable product)
        {
            List<SPParam> parameters = new List<SPParam>
            {
                new SPParam("name", product.Name),
                new SPParam("categoryId", product.CategoryId),
                new SPParam("price", product.Price),
                new SPParam("description", product.Description),
                new SPParam("pictureUri", product.PictureUri??"Not Specified"),
            };

            ExecuteSpNonQuery("AddProduct", parameters);
        }


        public void EditProduct()
        {
            List<SPParam> parameters = new List<SPParam>()
            {
                new SPParam("id", this.Id),
                new SPParam("name", this.Name),
                new SPParam("categoryId", this.CategoryId),
                new SPParam("drice", this.Price),
                new SPParam("description", this.Description),
                new SPParam("pictureUri", this.PictureUri??"Not Specified")
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
