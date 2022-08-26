using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Store.Contracts.Models;
using Store.Data.Repos;
using Store.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class UserController : ControllerBase
   {
      private IUserRepository _users;
      private IMapper _mapper;

      public UserController(IUserRepository users, IMapper mapper)
      {
         _users = users;
         _mapper = mapper;
      }

      [HttpGet]
      [Route("")]
      public async Task<IActionResult> GetUser(string phone, string password)
      {
         var user = await _users.GetUserByRegister(phone, password);
         var resp = _mapper.Map<Data.Models.User, UserView>(user);
         return StatusCode(200, user);
      }

      [HttpPost]
      [Route("")]
      public async Task<IActionResult> Add(AddUserRequest request)
      {
         var user = _mapper.Map<AddUserRequest, Data.Models.User>(request);
         await _users.Save(user);
         return StatusCode(201, $"Пользователь {user.FirstName} {user.SecondName} добавлен.");
      }

      [HttpPatch]
      [Route("{id}")]
      public async Task<IActionResult> Edit([FromRoute] Guid id, [FromBody] EditUserRequest request)
      {
         var user = await _users.GetUserById(id);
         if (user == null)
            return StatusCode(400, "Пользователь не найден.");
         await _users.Update(
         user,
         new Data.Queries.UpdateUserQuery(request.NewFirstName, request.NewSecondName, request.NewPhone, request.NewPassword)
         );

         return StatusCode(200, "Данные пользователя обновлены.");
      }

      [HttpDelete]
      [Route("{id}")]
      public async Task<IActionResult> Delete([FromRoute] Guid id)
      {
         var user = await _users.GetUserById(id);
         if (user == null)
            return StatusCode(400, "Пользователь не найден.");
         await _users.Delete(user);
         return StatusCode(204, "Пользователь удалён.");
      }
   }
}
