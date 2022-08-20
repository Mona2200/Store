using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
   public class Review
   {
      public Guid Id { get; set; }
      public float Rating { get; set; }
      public string Description { get; set; }
      public Product Product { get; set; }
      public User User { get; set; }
   }
}
