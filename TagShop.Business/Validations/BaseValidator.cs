using FluentValidation;
using FluentValidation.Results;

namespace TagShop.Business.Validations
{
    public abstract class BaseValidator<T>
    {
        public ValidationResult Validate(T obj, AbstractValidator<T> validator)
        {
            return validator.Validate(obj);
        }
    }
}
