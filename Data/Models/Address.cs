using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Data.Models
{
   [Table("Addresses")]
   public class Address
   {
      public Guid Id { get; set; } = Guid.NewGuid();
      public string Region { get; set; }
      public string Town { get; set; }
      public string Outside { get; set; }
      public string House { get; set; }
      public int Flat { get; set; }
      public int Postcode { get; set; }
      public Guid UserId { get; set; }
   }
}
