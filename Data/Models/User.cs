using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Data.Models
{
   [Table("Users")]
   public class User
   {
      public Guid Id { get; set; }
      public string FirstName { get; set; }
      public string SecondName { get; set; }
      public uint Phone { get; set; }
      public string Region { get; set; }
      public string Town { get; set; }
      public string Outside { get; set; }
      public string House { get; set; }
      public uint Flat { get; set; }
      public uint Postcode { get; set; }
   }
}
