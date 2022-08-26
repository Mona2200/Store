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
         CreateMap<Data.Models.Product, ProductView>();
         CreateMap<Data.Models.Review, ReviewView>();
         CreateMap<Data.Models.User, UserView>();
         CreateMap<AddProductRequest, Data.Models.Product>();
         CreateMap<AddReviewRequest, Data.Models.Review>();
         CreateMap<AddUserRequest, Data.Models.User>();
      }
   }
}
