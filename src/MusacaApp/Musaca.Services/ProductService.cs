using System.Collections.Generic;
using System.Linq;
using Musaca.Data;
using Musaca.Models;

namespace Musaca.Services
{
    public class ProductService : IProductService
    {
        private readonly MusacaAppDb context;

        public ProductService(MusacaAppDb appDb)
        {
            this.context = appDb;
        }

        public void Create(string name, decimal price)
        {
            var product = new Product { Name = name, Price = price };

            this.context.Products.Add(product);
            this.context.SaveChanges();
        }

        public ICollection<Product> GetAllProducts()
        {
            return this.context.Products.ToList();
        }

        public Product GetByName(string name)
        {
            return this.context.Products.SingleOrDefault(x => x.Name == name);
        }
    }
}
