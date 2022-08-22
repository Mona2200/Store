using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Contracts.Models
{
   public class EditProductRequest
   {
      public string NewName { get; set; }
      public string NewDescription { get; set; }
      public string NewCategories { get; set; }
      public string NewSize { get; set; }
      public int NewPrice { get; set; }
   }
}
