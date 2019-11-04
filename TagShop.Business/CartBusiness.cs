using System;
using System.Collections.Generic;
using System.Linq;
using TagShop.Business.Interfaces;
using TagShop.Domain.Models;
using TagShop.Repository.Interfaces;

namespace TagShop.Business
{
    public class CartBusiness : ICartBusiness
    {

        private readonly ICartRepository _cartRepository;

        public CartBusiness(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public Cart ChangeStatus(Guid key)
        {
            return _cartRepository.ChangeStatus(key);
        }

        public List<Cart> GetAll()
        {
            return _cartRepository.GetAll();
        }

        public Cart GetById(Guid key)
        {
            return _cartRepository.GetById(key).ToList().FirstOrDefault();
        }

        public Cart Insert(Cart obj)
        {
            return _cartRepository.Insert(obj);
        }
    }
}
