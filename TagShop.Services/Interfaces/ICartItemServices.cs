using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Services.Interfaces
{
    public interface ICartItemServices
    {
        CartItem Insert(CartItem obj);
        CartItem ChangeStatus(Guid key);
        List<CartItem> GetAll();
        CartItem GetById(Guid key);
    }
}
