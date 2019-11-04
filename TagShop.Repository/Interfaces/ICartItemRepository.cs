using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Repository.Interfaces
{
    public interface ICartItemRepository
    {
        CartItem Insert(CartItem obj);
        CartItem ChangeStatus(Guid key);
        List<CartItem> GetAll();
        List<CartItem> GetById(Guid key);

        List<CartItem> GetByCart(Int64 cartId);
    }
}
