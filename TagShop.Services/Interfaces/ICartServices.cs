using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Services.Interfaces
{
    public interface ICartServices
    {
        Cart Insert(Cart obj);
        Cart Update(Cart obj);
        Cart ChangeStatus(Cart obj);
        List<Cart> GetAll();
        Cart GetById(Guid key);
    }
}
