using System.Collections.Generic;
using System.Linq;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TagShop.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseController : ControllerBase
    {
        /// <summary>
        /// Formata e retorna a mensagem de erro, template conforme rfc7807
        /// </summary>
        /// <param name="validationErrors"></param>
        /// <returns></returns>
        protected ActionResult CustomBadRequest(IList<ValidationFailure> validationErrors)
        {
            var errorDetails = new Dictionary<string, string[]>();

            //percorre a lista de erros
            foreach (var error in validationErrors)
            {
                // verifica se a chave existe no dicionario
                if (errorDetails.ContainsKey(error.PropertyName))
                {
                    //altera a chave, adicionando a string de erro
                    errorDetails[error.PropertyName] = errorDetails[error.PropertyName].Append(error.ErrorMessage).ToArray();
                }
                else
                {
                    // adiciona uma nova chave e a mensagem de erro
                    errorDetails.Add(error.PropertyName, new string[] { error.ErrorMessage });
                }
            }
            
            //Monta o objeto de retorno
            var problemDetails = new ValidationProblemDetails(errorDetails)
            {
                Instance =  HttpContext.Request.Path,
                Status = StatusCodes.Status400BadRequest,
                Detail = "Please refer to the errors property for additional details"
            };

            //retorna a msg HTTP
            return new BadRequestObjectResult(problemDetails)
            {
                ContentTypes = { "application/problem+json" }
            };

        }
    }
}