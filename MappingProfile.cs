using AutoMapper;
using Store.ViewModels;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Store.Contracts.Models;

namespace Store
{
   /// <summary>
   /// Настройки маппинга всех сущностей приложения
   /// </summary>
   public class MappingProfile : Profile
   {
      public MappingProfile()
      {
         CreateMap<Data.Models.Product, Contracts.Models.ProductView>();

         CreateMap<AddProductRequest, Data.Models.Product>();
      }
   }
}
