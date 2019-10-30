using FluentValidation;
using TagShop.Domain.Models;

namespace TagShop.Domain.Validations
{
    public class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleFor(x => x.Cpf)
            .NotEmpty()
            .WithMessage("CPF não é valido.");
        }
    }
}
