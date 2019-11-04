using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TagShop.Api.ViewModels.CartItems;
using TagShop.Domain.Models;
using TagShop.Services.Interfaces;

namespace TagShop.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CartItemController : BaseController
    {

        private readonly ICartItemServices _cartItemServices;
        private readonly IMapper _mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cartItemServices"></param>
        public CartItemController(ICartItemServices cartItemServices, IMapper mapper)
        {
            _cartItemServices = cartItemServices;
            _mapper = mapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public string Get2(int id)
        {
            return "value";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cartItem"></param>
        [HttpPost]
        public ActionResult<CartItemViewModel> Post([FromBody] CreateCartItemViewModel cartItem)
        {
            var resultService = _cartItemServices.Insert(_mapper.Map<CartItem>(cartItem));

            return null;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cartKey"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("getbycartkey")]
        public void GetCartItemsByCartKey(Guid cartKey)
        {

        }
    }
}
