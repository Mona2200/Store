using FluentValidation;
using Store.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Contracts.Validators
{
   /// <summary>
   /// Реализация валидации принимаемых параметров
   /// </summary>
   public class AddProductRequestValidator : AbstractValidator<AddProductRequest>
   {
      private string[] categories;
      public AddProductRequestValidator()
      {
         categories = new[]
         {
         "Shoes",
         "Top",
         "Pants",
         "Sweater"
         };

         RuleFor(x => x.Name).NotEmpty().Must(BeValidName).WithMessage("Название товара должно состоять более чем из 5 и менее чем из 30 символов.");
         RuleFor(x => x.Description).NotEmpty().Must(BeValidDescription).WithMessage("Описание товара должно состоять более чем из 50 и менее чем из 500 символов.");
         RuleFor(x => x.Gender).NotEmpty().Must(BeValidGender).WithMessage("Доступен выбор гендера male или female.");
         RuleFor(x => x.Categories).NotEmpty().Must(BeValidCategories).WithMessage("Какая-либо из категорий не была найдена.");
         RuleFor(x => x.Size).NotEmpty();
         RuleFor(x => x.Price).NotEmpty();
      }

      private bool BeValidName(string Name)
      {
         if (Name.Length < 5 || Name.Length > 30)
            return false;
         return true;
      }

      private bool BeValidDescription(string Description)
      {
         if (Description.Length < 50 || Description.Length > 500)
            return false;
         return true;
      }

      private bool BeValidGender(string Gender)
      {
         if (Gender != "male" && Gender != "female")
            return false;
         return true;
      }

      private bool BeValidCategories(string[] Categories)
      {
         foreach (var c in Categories)
            if (!categories.Any(x => x == c))
               return false;
         return true;
      }
   }
}
