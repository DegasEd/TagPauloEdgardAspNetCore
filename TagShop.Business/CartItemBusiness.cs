using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TagShop.Business.Interfaces;
using TagShop.Domain.Models;
using TagShop.Repository.Interfaces;

namespace TagShop.Business
{
    public class CartItemBusiness : ICartItemBusiness
    {
        private readonly ICartItemRepository _cartItemRepository;
        private readonly ICartRepository _cartRepository;
        public CartItemBusiness(ICartItemRepository cartItemRepository, ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
            _cartItemRepository = cartItemRepository;

        }
        public CartItem ChangeStatus(Guid key)
        {
            return _cartItemRepository.ChangeStatus(key);
        }

        public List<CartItem> GetAll()
        {
            return _cartItemRepository.GetAll();
        }

        public List<CartItem> GetByCart(Guid cartKey)
        {
            var cartId = _cartRepository.GetById(cartKey).ToList().FirstOrDefault().Id;

            var result = _cartItemRepository.GetByCart(cartId);

            return result;
        }

        public CartItem GetById(Guid key)
        {
            return _cartItemRepository.GetById(key).ToList().FirstOrDefault();
        }

        public CartItem Insert(CartItem obj)
        {
            return _cartItemRepository.Insert(obj);
        }
    }
}
