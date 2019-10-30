using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TagShop.Api.ViewModels.Customers;
using TagShop.Domain.Models;
using TagShop.Services.Interfaces;

namespace TagShop.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : BaseController
    {
        private readonly IClientServices _clientServices;
        private readonly IMapper _mapper;

        /// <summary>
        /// Método construtor da Client Controller
        /// </summary>
        /// <param name="clientServices">Interface de Serviço de Cliente</param>
        /// <param name="mapper">Utilizado para o AutoMapper</param>
        public ClientController(IClientServices clientServices, IMapper mapper)
        {
            _clientServices = clientServices;
            _mapper = mapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<ClientViewModel> GetAll()
        {
            var resultService = _clientServices.GetAll();

            return _mapper.Map<List<ClientViewModel>>(resultService);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{key}")]
        public ClientViewModel Get(Guid key)
        {
            var resultService = _clientServices.GetById(key);

            return _mapper.Map<ClientViewModel>(resultService);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public ActionResult<ClientViewModel> Post([FromBody] CreateClientViewModel client)
        {
            try
            {
                var resultServices = _clientServices.Insert(_mapper.Map<Client>(client));

                if(!resultServices.Valid)
                {
                    return CustomBadRequest(resultServices.ValidationResult.Errors);
                }

                return Ok(_mapper.Map<ClientViewModel>(resultServices));
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        [Route("update")]
        [HttpPut]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        [Route("changestatus")]
        [HttpPut]
        public ActionResult<ClientViewModel> ChangeStatus(Guid key)
        {
            var resultService = _clientServices.ChangeStatus(key);

            return _mapper.Map<ClientViewModel>(resultService);
        }
    }
}
