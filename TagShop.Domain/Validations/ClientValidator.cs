using FluentValidation;
using TagShop.Domain.Models;

namespace TagShop.Domain.Validations
{
    public class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleFor(x => x.Cpf).NotEmpty();
            RuleFor(x => x.Cpf).NotNull();
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Name).NotNull();

        }
    }
}
