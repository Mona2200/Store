using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Store.BLL.ViewModels;
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
      [Route("info")]
      public IActionResult Info()
      {
         var infoResponse = _mapper.Map<Product, ProductView>(_options.Value);

         return StatusCode(200, infoResponse);
      }
   }
}
