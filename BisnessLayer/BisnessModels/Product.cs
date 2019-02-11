using BisnessLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.DataAccessTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BisnessLayer.BisnessModels
{
    public class Product:IProductable
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string PictureUri { get; set; }


        public static IEnumerable<IProductable> GetProducts()
        {
           IEnumerable<Product> products =  DataAccessManager.ExexuteSPWithResult<Product>("GetAllProducts");
            return products;
        }


       

        public void AddProduct()
        {
            List<StoredProcedureParameters> parameters = new List<StoredProcedureParameters>()
        {
            
            new StoredProcedureParameters("@Name", this.Name),
            new StoredProcedureParameters("@Category", this.Category),
            new StoredProcedureParameters("@Price", this.Price),
            new StoredProcedureParameters("@Description", this.Description),
            new StoredProcedureParameters("@PictureUri", this.PictureUri),
        };

            DataAccessManager.ExecuteSpNonQuery("AddProduct", parameters);
        }


        public void EditProduct()
        {
            List<StoredProcedureParameters> parameters = new List<StoredProcedureParameters>()
        {
                new StoredProcedureParameters(@"Id", this.Id),
            new StoredProcedureParameters("@Name", this.Name),
            new StoredProcedureParameters("@Category", this.Category),
            new StoredProcedureParameters("@Price", this.Price),
            new StoredProcedureParameters("@Description", this.Description),
            new StoredProcedureParameters("@PictureUri", this.PictureUri),
        };

            DataAccessManager.ExecuteSpNonQuery("EditProduct", parameters);
        }


        public void DeleteProduct()
        {
            List<StoredProcedureParameters> parameters = new List<StoredProcedureParameters>()
            {
                new StoredProcedureParameters("@Id", this.Id )
            };

            DataAccessManager.ExecuteSpNonQuery("DeleteProduct", parameters);

        }
    }
}
