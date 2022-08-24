using Store.Data.Models;
using Store.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Contracts.Models
{
   public class GetAboutProductResponse
   {
      public ProductView Product { get; set; }
      public ReviewView[] Reviews { get; set; }
   }
}
