using FluentValidation;
using Store.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Contracts.Validators
{
   /// <summary>
   /// Реализация валидации принимаемых параметров при изменении товара
   /// </summary>
   public class EditProductRequestValidator : AbstractValidator<EditProductRequest>
   {
      public EditProductRequestValidator()
      {
         RuleFor(x => x.NewName).NotEmpty().Must(BeValidName).WithMessage("Название товара должно состоять более чем из 5 и менее чем из 30 символов.");
         RuleFor(x => x.NewDescription).NotEmpty().Must(BeValidDescription).WithMessage("Описание товара должно состоять более чем из 50 и менее чем из 500 символов.");
         RuleFor(x => x.NewCategories).NotEmpty().Must(BeValidCategories).WithMessage("Какая-либо из категорий не была найдена.");
         RuleFor(x => x.NewSize).NotEmpty();
         RuleFor(x => x.NewPrice).NotEmpty();
      }

      private bool BeValidName(string Name)
      {
         if (Name.Length < 5 || Name.Length > 50)
            return false;
         return true;
      }

      private bool BeValidDescription(string Description)
      {
         if (Description.Length < 50 || Description.Length > 500)
            return false;
         return true;
      }

      private bool BeValidCategories(string[] Categories)
      {
         foreach (var c in Categories)
            if (!Values.ValidCategories.Any(x => x == c))
               return false;
         return true;
      }
   }
}
