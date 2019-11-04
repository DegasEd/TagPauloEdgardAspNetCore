using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Business.Interfaces;
using TagShop.Domain.Models;
using TagShop.Services.Interfaces;

namespace TagShop.Services
{
    public class CartServices : ICartServices
    {

        private readonly ICartBusiness _cartBusiness;
        private readonly IClientBusiness _clientBusinee;

        public CartServices(ICartBusiness cartBusiness)
        {
            _cartBusiness = cartBusiness;
        }
        public Cart ChangeStatus(Guid key)
        {
            return _cartBusiness.ChangeStatus(key);
        }

        public List<Cart> GetAll()
        {
            var resultBusiness = _cartBusiness.GetAll();

            return _cartBusiness.GetAll();
        }

        public Cart GetById(Guid key)
        {
            return _cartBusiness.GetById(key);
        }

        public Cart Insert(Cart obj)
        {
            return _cartBusiness.Insert(obj);
        }

        
    }
}
