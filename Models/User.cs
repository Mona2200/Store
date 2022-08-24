using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
   public class User
   {
      public Guid Id { get; set; }
      public string FirstName { get; set; }
      public string SecondName { get; set; }
      public int Phone { get; set; }
      public Address Address { get; set; }
   }
}
