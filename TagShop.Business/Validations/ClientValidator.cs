using FluentValidation;
using TagShop.Domain.Models;

namespace TagShop.Business.Validations
{
    public class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleFor(x => x.Cpf).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}
