using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Store.BLL.ViewModels;
using Store.Contracts.Models;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class ProductController : ControllerBase
   {
      private IOptions<Product> _options;
      private IMapper _mapper;

      public ProductController(IOptions<Product> options, IMapper mapper)
      {
         _options = options;
         _mapper = mapper;
      }

      [HttpGet]
      [Route("")]
      public IActionResult Get()
      {
         return StatusCode(200, "Устройства отсутствуют");
      }

      [HttpPost]
      [Route("Add")]
      public IActionResult Add([FromBody] AddProductRequest request)
      {
         return StatusCode(200, $"Добавление {request.Name} прошло успешно.");
      }
   }
}
