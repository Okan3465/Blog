﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığını boş geçemezsiniz");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriğini boş geçemezsiniz");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Blog görselini boş geçemezsiniz");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage(" 150 karakterden daha az veri girişi yapınız");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("En az 5 karakterden oluşan veri girişi yapınız ");
        }
    }
}