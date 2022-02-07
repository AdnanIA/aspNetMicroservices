using Catalog.Api.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Api.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                  new Product
                  {
                     Id="602d2149",
                     Name="Laptop",
                     Summary="This Phone is company Phone",
                     Description="test description",
                     ImageFile="testImage.png",
                     Price=950.00M,
                     Category="Smart Phone"

                  },
                  new Product
                  {
                     Id="602d2149",
                     Name="Laptop",
                     Summary="This Phone is company Phone",
                     Description="test description",
                     ImageFile="testImage.png",
                     Price=950.00M,
                     Category="Smart Phone"

                  },
                   new Product
                  {
                     Id="602d2149",
                     Name="Laptop",
                     Summary="This Phone is company Phone",
                     Description="test description",
                     ImageFile="testImage.png",
                     Price=950.00M,
                     Category="Smart Phone"

                  },
                  new Product
                  {
                     Id="602d2149",
                     Name="Laptop",
                     Summary="This Phone is company Phone",
                     Description="test description",
                     ImageFile="testImage.png",
                     Price=950.00M,
                     Category="Smart Phone"

                  },
                  new Product
                  {
                     Id="602d2149",
                     Name="Laptop",
                     Summary="This Phone is company Phone",
                     Description="test description",
                     ImageFile="testImage.png",
                     Price=950.00M,
                     Category="Smart Phone"

                  },
                  new Product
                  {
                     Id="602d2149",
                     Name="Laptop",
                     Summary="This Phone is company Phone",
                     Description="test description",
                     ImageFile="testImage.png",
                     Price=950.00M,
                     Category="Smart Phone"

                  }


            };
        }
    }
}
