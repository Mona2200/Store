using Store.Data.Models;
using Store.Data.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Data.Repos
{
   public interface IUserRepository
   {
      Task<User> GetUserById(Guid id);
      Task<User> GetUserByRegister(string phone, string password);
      Task Save(User user);
      Task Update(User user, UpdateUserQuery query);
      Task Delete(User user);
   }
}
