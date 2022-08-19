using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
   public class Product
   {
      public Guid Id { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
      public enum Gender
      {
         male,
         female
      }
      public List<Category> Categories { get; set; }
      public string Size { get; set; }
      public uint Price { get; set; }
      public float Rating { get; set; }
      public List<Review> Reviews { get; set; }
   }
}
