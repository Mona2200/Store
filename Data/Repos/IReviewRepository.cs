using Store.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Data.Repos
{
   public interface IReviewRepository
   {
      Task<Review[]> GetReviewsByIdProduct(Guid id);
      Task<Review[]> GetReviewsByIdUser(Guid id);
      Task<Review> GetReviewByIdUserAndIdProduct(Guid idUser, Guid idProduct);
      Task Save(Review review);
      Task Delete(Review review);
   }
}
