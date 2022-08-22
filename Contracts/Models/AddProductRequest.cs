using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Contracts.Models
{
   public class AddProductRequest
   {
      public string Name { get; set; }
      public string Description { get; set; }
      public bool Gender { get; set; }
      public string Categories { get; set; }
      public string Size { get; set; }
      public int Price { get; set; }
   }
}
