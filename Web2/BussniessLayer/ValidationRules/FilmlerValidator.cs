using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussniessLayer.ValidationRules
{
    public class FilmlerValidator : AbstractValidator<Filmler>
    {
        public FilmlerValidator()
        {
            RuleFor(x => x.FilmAd).NotEmpty().WithMessage("Film Adı Boş!");
            RuleFor(x => x.FilmAciklama).NotEmpty().WithMessage("Film Açıklaması Boş!");
        }

    }
}
