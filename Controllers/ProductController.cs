﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Store.ViewModels;
using Store.Contracts.Models;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Data.Repos;

namespace Store.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class ProductController : ControllerBase
   {
      private IProductRepository _products;
      private IReviewRepository _reviews;
      private IMapper _mapper;

      public ProductController(IProductRepository products, IReviewRepository reviews, IMapper mapper)
      {
         _products = products;
         _reviews = reviews;
         _mapper = mapper;
      }

      [HttpGet]
      [Route("")]
      public async Task<IActionResult> GetProducts()
      {
         var products = await _products.GetProducts();

         var resp = new GetProductsResponse
         {
            ProductAmount = products.Length,
            Products = _mapper.Map<Data.Models.Product[], ProductView[]>(products)
         };

         return StatusCode(200, resp);
      }

      [HttpGet]
      [Route("{id}")]
      public async Task<IActionResult> GetAboutProduct([FromRoute] Guid id)
      {
         var product = await _products.GetAboutProductById(id);
         var reviews = await _reviews.GetReviewsByIdProduct(id);

         var resp = new GetAboutProductResponse
         {
            Product = _mapper.Map<Data.Models.Product, ProductView>(product),
            Reviews = _mapper.Map<Data.Models.Review[], ReviewView[]>(reviews)
         };

         return StatusCode(200, resp);
      }

      [HttpPost]
      [Route("")]
      public async Task<IActionResult> Add(AddProductRequest request)
      {
         var product = _mapper.Map<AddProductRequest, Data.Models.Product>(request);
         await _products.SaveProduct(product);
         return StatusCode(201, $"Добавление {request.Name} прошло успешно");
      }

      [HttpPatch]
      [Route("{id}")]
      public async Task<IActionResult> Edit([FromRoute] Guid id, [FromBody] EditProductRequest request)
      {
         var product = await _products.GetProductById(id);
         if (product == null)
            return StatusCode(400, $"Ошибка: Товар с идентификатором {id} не существует");

         await _products.UpdateProduct(
         product,
         new Data.Queries.UpdateProductQuery(request.NewName, request.NewDescription, request.NewCategories, request.NewSize, request.NewPrice)
         );

         return StatusCode(200, $"Товар {product.Name} обновлён");
      }

      [HttpDelete]
      [Route("{id}")]
      public async Task<IActionResult> Delete([FromRoute] Guid id)
      {
         var product = await _products.GetProductById(id);
         if (product == null)
            return StatusCode(400, $"Ошибка: Товар с идентификатором {id} не существует");

         await _products.DeleteProduct(product);

         return StatusCode(204, "Товар удалён");
      }
   }
}
