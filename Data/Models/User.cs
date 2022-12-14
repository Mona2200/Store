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
      public Guid Id { get; set; } = Guid.NewGuid();
      public string FirstName { get; set; }
      public string SecondName { get; set; }
      public string Phone { get; set; }
      public string Password { get; set; }
   }
}
