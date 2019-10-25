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
            return new List<CartViewModel>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<CartViewModel> Get(int id)
        {
            return new CartViewModel();
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

                return StatusCode(500, new {haserror = true, errormessage = "Erro interno, favor contactar administrador", data = ex.Message });
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cart"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("update")]
        public ActionResult<CartViewModel> Put([FromBody] CartViewModel cart)
        {
            return new CartViewModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [Route("changestatus")]
        [HttpPut]
        public ActionResult<CartViewModel> ChangeStatus(Guid key)
        {
            return new CartViewModel();
        }

    }
}
