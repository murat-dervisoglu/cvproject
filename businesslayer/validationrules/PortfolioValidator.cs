using entitylayer.concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace businesslayer.validationrules
{
    public class PortfolioValidator: AbstractValidator<portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x=>x.name).NotEmpty().WithMessage("Proje adı boş bırakılamaz");
            RuleFor(x => x.imageUrl).NotEmpty().WithMessage("Birinci görsel alanı boş bırakılamaz");
            RuleFor(x => x.imageUrl2).NotEmpty().WithMessage("İkinci görsel boş bırakılamaz");
            RuleFor(x => x.price).NotEmpty().WithMessage("Proje ücreti alanı boş bırakılamaz");
            RuleFor(x => x.name).MinimumLength(4).WithMessage("Proje adı en az beş karakter olmalıdır");
            RuleFor(x => x.name).MaximumLength(50).WithMessage("Proje adı en fazla elli karakter olmalıdır");
        }
    }
}
