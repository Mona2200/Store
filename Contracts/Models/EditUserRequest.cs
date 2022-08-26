using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Contracts.Models
{
   public class EditUserRequest
   {
      public string NewFirstName { get; set; }
      public string NewSecondName { get; set; }
      public string NewPhone { get; set; }
      public string NewPassword { get; set; }
   }
}
