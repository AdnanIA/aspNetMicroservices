using Catalog.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Api.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>>GetProducts();
        Task<Product> GetProduct(string id);
    }
}
