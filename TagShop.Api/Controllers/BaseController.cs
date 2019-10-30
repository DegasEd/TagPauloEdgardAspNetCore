using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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

        protected ActionResult CustomBadRequest(IList<ValidationFailure> validationErrors)
        {
            var listErrors = new List<string>();

            foreach (var error in validationErrors)
            {
                listErrors.Add(error.ErrorMessage);
            }

            return BadRequest(listErrors);
        }
    }
}