using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Data.Queries
{
   public class UpdateUserQuery
   {
      public string FirstName { get; set; }
      public string SecondName { get; set; }
      public string Phone { get; set; }
      public string Password { get; set; }

      public UpdateUserQuery(string firstName = null, string secondName = null, string phone = null, string password = null)
      {
         FirstName = firstName;
         SecondName = secondName;
         Phone = phone;
         Password = password;
      }
   }
}
