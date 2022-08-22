using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Data.Queries
{
   /// <summary>
   /// Класс для передачи дополнительных параметров при обновлении товара
   /// </summary>
   public class UpdateProductQuery
   {
      public string NewName { get; set; }
      public string NewDescription { get; set; }
      public string NewCategories { get; set; }
      public string NewSize { get; set; }
      public int NewPrice { get; set; }

      public UpdateProductQuery(string newName = null, string newDescription = null, string newCategories = null, string newSize = null, int newPrice = 0)
      {
         NewName = newName;
         NewDescription = newDescription;
         NewCategories = newCategories;
         NewSize = newSize;
         NewPrice = newPrice;
      }
   }
}
