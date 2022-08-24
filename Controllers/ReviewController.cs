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
   public class ReviewController : ControllerBase
   {
      private IReviewRepository _reviews;
      private IMapper _mapper;

      public ReviewController(IReviewRepository reviews, IMapper mapper)
      {
         _reviews = reviews;
         _mapper = mapper;
      }

      [HttpGet]
      [Route("{idProduct}")]
      public async Task<IActionResult> GetByIdProduct([FromRoute] Guid idProduct)
      {
         var revires = await _reviews.GetReviewsByIdProduct(idProduct);
         var resp = _mapper.Map<Data.Models.Review[], ReviewView>(revires);
         return StatusCode(200, resp);
      }

      [HttpGet]
      [Route("{idUser}")]
      public async Task<IActionResult> GetByIdUser([FromRoute] Guid idUser)
      {
         var revires = await _reviews.GetReviewsByIdUser(idUser);
         var resp = _mapper.Map<Data.Models.Review[], ReviewView>(revires);
         return StatusCode(200, resp);
      }

      [HttpPost]
      [Route("{idUser}")]
      public async Task<IActionResult> Add([FromRoute] Guid idUser, [FromQuery] Guid idProduct, [FromBody] AddReviewRequest request)
      {
         var review = _mapper.Map<AddReviewRequest, Data.Models.Review>(request);
         review.UserId = idUser;
         review.ProductId = idProduct;
         await _reviews.Save(review);
         return StatusCode(201, $"Комментарий добавлен");
      }

      [HttpDelete]
      [Route("{idUser}")]
      public async Task<IActionResult> Delete ([FromRoute] Guid idUser, [FromQuery] Guid idProduct)
      {
         var review = await _reviews.GetReviewByIdUserAndIdProduct(idUser, idProduct);
         if (review == null)
            return StatusCode(400, "Ошибка: Комментарий не найден");
         await _reviews.Delete(review);
         return StatusCode(204, "Комментарий удалён");
      }
   }
}
