using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Models
{
[Table("Reviews")]
   public class Review
   {
      public Guid Id { get; set; } = Guid.NewGuid();
      public float Rating { get; set; }
      public string Description { get; set; }
      public Guid ProductId { get; set; }
      public Guid UserId { get; set; }
      public User User { get; set; }
   }
}
