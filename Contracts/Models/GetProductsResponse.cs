using Store.ViewModels;
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
}
