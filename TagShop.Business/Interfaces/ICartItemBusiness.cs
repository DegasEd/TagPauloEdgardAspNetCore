using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Business.Interfaces
{
    public interface ICartItemBusiness
    {
        CartItem Insert(CartItem obj);
        CartItem ChangeStatus(Guid key);
        List<CartItem> GetAll();
        CartItem GetById(Guid key);

        List<CartItem> GetByCart(Guid cartKey);
    }
}
