using Microsoft.EntityFrameworkCore;
using Store.Data.Models;
using Store.Data.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Data.Repos
{
   /// <summary>
   /// Репозиторий для операций с объектами типа "Product" в базе
   /// </summary>
   public class ProductRepository : IProductRepository
   {
      private readonly StoreContext _context;

      public ProductRepository(StoreContext context)
      {
         _context = context;
      }

      /// <summary>
      /// Выгрузить все товары
      /// </summary>
      public async Task<Product[]> GetProducts()
      {
         return await _context.Products.ToArrayAsync();
      }

      /// <summary>
      /// Найти товар по идентификатору
      /// </summary>
      public async Task<Product> GetProductById(Guid id)
      {
         return await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
      }

      /// <summary>
      /// Найти товары по названию
      /// </summary>
      public async Task<Product[]> GetProductsByName(string name)
      {
         return await _context.Products.Where(p => p.Name == name).ToArrayAsync();
      }

      /// <summary>
      /// Найти товары по категории
      /// </summary>
      public async Task<Product[]> GetProductsByCategory(string category)
      {
         return await _context.Products.Where(p => p.Categories.Contains(category)).ToArrayAsync();
      }

      /// <summary>
      /// Добавить товар
      /// </summary>
      public async Task SaveProduct(Product product)
      {
         var entry = _context.Entry(product);
         if (entry.State == EntityState.Detached)
            await _context.Products.AddAsync(product);
         await _context.SaveChangesAsync();
      }

      /// <summary>
      /// Обновить товар
      /// </summary>
      public async Task UpdateProduct(Product product, UpdateProductQuery updateProduct)
      {
         if (!string.IsNullOrEmpty(updateProduct.NewName))
            product.Name = updateProduct.NewName;
         if (!string.IsNullOrEmpty(updateProduct.NewDescription))
            product.Description = updateProduct.NewDescription;
         if (updateProduct.NewCategories.Length != 0)
            product.Categories = updateProduct.NewCategories;
         if (updateProduct.NewSize.Length != 0)
            product.Size = updateProduct.NewSize;
         if (updateProduct.NewPrice != 0)
            product.Price = updateProduct.NewPrice;

         var entry = _context.Entry(product);
         if (entry.State == EntityState.Detached)
            _context.Products.Update(product);

         await _context.SaveChangesAsync();
      }

      /// <summary>
      /// Удалить товар
      /// </summary>
      public async Task DeleteProduct(Product product)
      {
         _context.Products.Remove(product);
         await _context.SaveChangesAsync();
      }
   }
}
