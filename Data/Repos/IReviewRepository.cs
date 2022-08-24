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
   }
}
