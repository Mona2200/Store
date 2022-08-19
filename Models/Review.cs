using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
   public class Review
   {
      public Guid ProductId { get; set; }
      public Guid UserId { get; set; }
      public float Rating { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
   }
}
