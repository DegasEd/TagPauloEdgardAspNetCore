using System;
using System.Collections.Generic;
using System.Text;
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

        public Cart ChangeStatus(Cart obj)
        {
            throw new NotImplementedException();
        }

        public List<Cart> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Cart> GetById(Guid key)
        {
            throw new NotImplementedException();
        }

        public Cart Insert(Cart obj)
        {
            return _cartRepository.Insert(obj);
        }

        public Cart Update(Cart obj)
        {
            throw new NotImplementedException();
        }
    }
}
