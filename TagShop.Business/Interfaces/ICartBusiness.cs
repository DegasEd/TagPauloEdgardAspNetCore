using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Business.Interfaces
{
    public interface ICartBusiness
    {
        Cart Insert(Cart obj);
        Cart Update(Cart obj);
        Cart ChangeStatus(Cart obj);
        List<Cart> GetAll();
        List<Cart> GetById(Guid key);
    }
}
