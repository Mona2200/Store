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

      public async Task<Review[]> GetReviewsByIdUser(Guid id)
      {
         return await _context.Reviews.Where(r => r.UserId == id).ToArrayAsync();
      }

      public async Task<Review> GetReviewByIdUserAndIdProduct(Guid idUser, Guid idProduct)
      {
         return await _context.Reviews.Where(r => r.UserId == idUser && r.ProductId == idProduct).FirstOrDefaultAsync();
      }

      public async Task Save(Review review)
      {
         var entry = _context.Entry(review);
         if (entry.State == EntityState.Detached)
            await _context.Reviews.AddAsync(review);
         await _context.SaveChangesAsync();
      }

      public async Task Delete(Review review)
      {
         _context.Reviews.Remove(review);
         await _context.SaveChangesAsync();
      }
   }
}
