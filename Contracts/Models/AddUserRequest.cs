using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Contracts.Models
{
   public class AddUserRequest
   {
      public string FirstName { get; set; }
      public string SecondName { get; set; }
      public string Phone { get; set; }
      public string Password { get; set; }
   }
}
