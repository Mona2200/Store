using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Contracts.Models
{
   public class GetProductsResponse
   {
      public int ProductAmount { get; set; }
      public ProductView[] Products { get; set; }
   }

   public class ProductView
   {
      public string Name { get; set; }
      public string Description { get; set; }
      public bool Gender { get; set; }
      public string Categories { get; set; }
      public string Size { get; set; }
      public int Price { get; set; }
      public double Rating { get; set; }
   }
}
