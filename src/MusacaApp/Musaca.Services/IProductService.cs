using Musaca.Models;
using System.Collections.Generic;

namespace Musaca.Services
{
    public interface IProductService
    {
        void Create(string name, decimal price);

        ICollection<Product> GetAllProducts();

        Product GetByName(string name);
    }
}
