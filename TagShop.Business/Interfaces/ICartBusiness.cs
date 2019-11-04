using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Business.Interfaces
{
    public interface ICartBusiness
    {
        Cart Insert(Cart obj);
        Cart ChangeStatus(Guid key);
        List<Cart> GetAll();
        Cart GetById(Guid key);
    }
}
