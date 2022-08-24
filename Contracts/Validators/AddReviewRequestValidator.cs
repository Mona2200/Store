using FluentValidation;
using Store.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Contracts.Validators
{
   public class AddReviewRequestValidator : AbstractValidator<AddReviewRequest>
   {
      public AddReviewRequestValidator()
      {
         RuleFor(x => x.Rating).NotEmpty().InclusiveBetween(0, 5).WithMessage("Рейтинг должен принимать значение от 0 до 5.");
         RuleFor(x => x.Description).Must(BeValidDescription).WithMessage("Комментарий должен содержать от 10 до 500 символов");
      }

      private bool BeValidDescription(string Description)
      {
         if (Description.Length < 10 || Description.Length > 500)
            return false;
         return true;
      }
   }
}
