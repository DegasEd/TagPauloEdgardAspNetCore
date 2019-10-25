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

        public CartServices(ICartBusiness cartBusiness)
        {
            _cartBusiness = cartBusiness;
        }
        public Cart ChangeStatus(Cart obj)
        {
            throw new NotImplementedException();
        }

        public List<Cart> GetAll()
        {
            throw new NotImplementedException();
        }

        public Cart GetById(Guid key)
        {
            throw new NotImplementedException();
        }

        public Cart Insert(Cart obj)
        {
            return _cartBusiness.Insert(obj);
        }

        public Cart Update(Cart obj)
        {
            throw new NotImplementedException();
        }
    }
}
