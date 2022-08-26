using Microsoft.EntityFrameworkCore;
using Store.Data.Models;
using Store.Data.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Data.Repos
{
   public class UserRepository : IUserRepository
   {
      private readonly StoreContext _context;

      public UserRepository(StoreContext context)
      {
         _context = context;
      }

      public async Task<User> GetUserById(Guid id)
      {
         return await _context.Users.Where(u => u.Id == id).FirstOrDefaultAsync();
      }

      public async Task<User> GetUserByRegister(string phone, string password)
      {
         return await _context.Users.Where(u => u.Phone == phone && u.Password == password).FirstOrDefaultAsync();
      }

      public async Task Save(User user)
      {
         var entry = _context.Entry(user);
         if (entry.State == EntityState.Detached)
            await _context.Users.AddAsync(user);
         await _context.SaveChangesAsync();
      }

      public async Task Update (User user, UpdateUserQuery query)
      {
         if (!string.IsNullOrEmpty(query.FirstName))
            user.FirstName = query.FirstName;
         if (!string.IsNullOrEmpty(query.SecondName))
            user.SecondName = query.SecondName;
         if (!string.IsNullOrEmpty(query.Phone))
            user.Phone = query.Phone;
         if (!string.IsNullOrEmpty(query.Password))
            user.Password = query.Password;

         var entry = _context.Entry(user);
         if (entry.State == EntityState.Detached)
            _context.Users.Update(user);
         await _context.SaveChangesAsync();
      }

      public async Task Delete(User user)
      {
         _context.Users.Remove(user);
         await _context.SaveChangesAsync();
      }
   }
}
