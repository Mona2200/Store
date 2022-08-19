using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.ViewModels
{
   public class ProductView
   {
      public string Name { get; set; }
      public string Description { get; set; }
      public string Gender { get; set; }
      public List<Category> Categories { get; set; }
      public string Size { get; set; }
      public uint Price { get; set; }
      public float Rating { get; set; }
      public List<Review> Reviews { get; set; }
   }
}
