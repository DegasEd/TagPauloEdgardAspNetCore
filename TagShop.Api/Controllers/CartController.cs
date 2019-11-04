using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TagShop.Api.ViewModels;
using TagShop.Api.ViewModels.Carts;
using TagShop.Domain.Models;
using TagShop.Services.Interfaces;

namespace TagShop.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : BaseController
    {
        private readonly ICartServices _cartService;
        private readonly IMapper _mapper;

        public CartController(ICartServices cartService, IMapper mapper)
        {
            _cartService = cartService;
            _mapper = mapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<CartViewModel>> GetAll()
        {
            var resultService = _cartService.GetAll();

            return _mapper.Map<List<CartViewModel>>(resultService);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [HttpGet("{key}")]
        public ActionResult<CartViewModel> Get(Guid key)
        {
            var resultService = _cartService.GetById(key);

            return _mapper.Map<CartViewModel>(resultService);
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cart"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post([FromBody] CreateCartViewModel cart)
        {
            try
            {

                var resultService = _cartService.Insert(_mapper.Map<Cart>(cart));

                return StatusCode(201, new { haserror = false, errormessage = "", data = _mapper.Map<ResultCreateCartViewModel>(resultService) });

            }
            catch (Exception ex)
            {

                return StatusCode(500, new { haserror = true, errormessage = "Erro interno, favor contactar administrador", data = ex.Message });
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [Route("changestatus")]
        [HttpPut]
        public ActionResult<ResultCreateCartViewModel> ChangeStatus(Guid key)
        {
            var resultService = _cartService.ChangeStatus(key);

            return _mapper.Map<ResultCreateCartViewModel>(resultService);
        }

    }
}
