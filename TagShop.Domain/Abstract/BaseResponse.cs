using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;

namespace TagShop.Domain.Abstract
{
    /// <summary>
    ///  Classe que contem atributos que irão verificar se o objeto é valido ou não - Fluent Validation
    /// </summary>
    public class BaseResponse
    {
        public BaseResponse()
        {
            ValidationResult = new ValidationResult();
        }

        [Computed]
        public ValidationResult ValidationResult { get; set; }

        [Computed]
        public bool Valid => ValidationResult.IsValid;
    }
}
