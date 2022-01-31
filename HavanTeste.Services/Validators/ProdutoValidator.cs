using FluentValidation;
using HavanTeste.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavanTeste.Services.Validators
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe um Nome.")
                .NotNull().WithMessage("Por favor informe um Nome.");

            RuleFor(c => c.IdFamilia)
                .NotEmpty().WithMessage("Por favor informe a Familia.")
                .NotNull().WithMessage("Por favor informe a Familia.");
        }
    }
}
