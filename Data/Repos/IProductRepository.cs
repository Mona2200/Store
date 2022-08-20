using Store.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Data.Repos
{
   /// <summary>
   /// Интерфейс определяет методы для доступа к объектам типа Product в базе
   /// </summary>
   public interface IProductRepository
   {
      Task<Product[]> GetProducts();
      Task<Product> GetProductById(Guid id);
      Task<Product[]> GetProductsByName(string name);
      Task SaveProduct(Product product);
      Task UpdateProduct(Product product);
      Task DeleteProduct(Product product);
   }
}
