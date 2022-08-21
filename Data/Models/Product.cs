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
      public List<string> Categories { get; set; }
      public List<string> Size { get; set; }
      public uint Price { get; set; }
      public float Rating { get; set; }
      public Review[] Reviews{ get; set; }
   }
}
