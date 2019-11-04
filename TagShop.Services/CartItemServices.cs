using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Business.Interfaces;
using TagShop.Domain.Models;
using TagShop.Services.Interfaces;

namespace TagShop.Services
{
    public class CartItemServices : ICartItemServices
    {
        private readonly ICartItemBusiness _cartItemBusiness;

        public CartItemServices(ICartItemBusiness cartItemBusiness)
        {
            _cartItemBusiness = cartItemBusiness;
        }

        public CartItem ChangeStatus(Guid key)
        {
            return _cartItemBusiness.ChangeStatus(key);
        }

        public List<CartItem> GetAll()
        {
            return _cartItemBusiness.GetAll();
        }

        public CartItem GetById(Guid key)
        {
            return _cartItemBusiness.GetById(key);
        }

        public CartItem Insert(CartItem obj)
        {
            return _cartItemBusiness.Insert(obj);
        }
    }
}
