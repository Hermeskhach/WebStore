using BisnessLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.DataAccessTools;
using System.Collections.Generic;

namespace BisnessLayer.BisnessModels
{
   public class Product : DataAccessManager, IProductable
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string PictureUri { get; set; }


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
                new SPParam("category", product.Category),
                new SPParam("price", product.Price),
                new SPParam("description", product.Description),
                new SPParam("pictureUri", product.PictureUri==null?"Not Specified":product.PictureUri),
            };

            ExecuteSpNonQuery("AddProduct", parameters);
        }


        public void EditProduct()
        {
            List<SPParam> parameters = new List<SPParam>()
            {
                new SPParam("id", this.Id),
                new SPParam("name", this.Name),
                new SPParam("category", this.Category),
                new SPParam("drice", this.Price),
                new SPParam("description", this.Description),
                new SPParam("pictureUri", this.PictureUri==null?"Not Specified":PictureUri),
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
