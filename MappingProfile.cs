using AutoMapper;
using Store.ViewModels;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store
{
   /// <summary>
   /// Настройки маппинга всех сущностей приложения
   /// </summary>
   public class MappingProfile : Profile
   {
      public MappingProfile()
      {
         CreateMap<Product, ProductView>();
      }
   }
}
