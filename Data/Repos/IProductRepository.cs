using Store.Data.Models;
using Store.Data.Queries;
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
      Task<Product[]> GetProductsByCategory(string category);
      Task SaveProduct(Product product);
      Task UpdateProduct(Product product, UpdateProductQuery updateProduct);
      Task DeleteProduct(Product product);
   }
}
