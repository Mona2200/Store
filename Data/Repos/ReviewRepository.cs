using Microsoft.EntityFrameworkCore;
using Store.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Data.Repos
{
   public class ReviewRepository : IReviewRepository
   {
      private readonly StoreContext _context;

      public ReviewRepository(StoreContext context)
      {
         _context = context;
      }

      public async Task<Review[]> GetReviewsByIdProduct(Guid id)
      {
         return await _context.Reviews.Where(r => r.ProductId == id).ToArrayAsync();
      }
   }
}
