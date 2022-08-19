using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Contracts.Models
{
   public class AddProductRequest
   {
      [Required]
      public string Name { get; set; }
      [Required]
      public string Description { get; set; }
      [Required]
      public string Gender { get; set; }
      [Required]
      public string[] Categories { get; set; }
      [Required]
      public string Size { get; set; }
      [Required]
      public uint Price { get; set; }
   }
}
