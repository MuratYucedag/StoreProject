using FluentValidation;
using StoreProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.BusinessLayer.ValidationRules.CategoryValidationRules
{
    public class CategoryAddValidator:AbstractValidator<Category>
    {
        public CategoryAddValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori açıklamasını boş geçemezsiniz");
            RuleFor(x => x.CategoryName).MinimumLength(5).WithMessage("Kategori adı en az 5 karakter olmalıdır");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Kategori adı en fazla 50 karakter olmalıdır");
        }
    }
}
/*
 Docker
 PostgreSQL
 SQLLite
 DbVeawer
 MongoDB
 Postman
 
 */