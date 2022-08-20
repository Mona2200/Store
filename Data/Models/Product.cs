using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Models
{
   [Table("Products")]
   public class Product
   {
      public Guid Id { get; set; } = Guid.NewGuid();
      public string Name { get; set; }
      public string Description { get; set; }
      public bool Gender { get; set; }
      public string Categories { get; set; }
      public string Size { get; set; }
      public uint Price { get; set; }
      public float Rating { get; set; }
   }
}
