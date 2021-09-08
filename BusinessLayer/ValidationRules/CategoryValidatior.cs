using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class CategoryValidatior:AbstractValidator<Category>
    {
        public CategoryValidatior()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategory adını boş bırakma gardaş");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açılamayı boş geçme gardaş");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("3 den fazla gir gardaş");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("20 den fazla girme gardaş");
        }
    }
}
