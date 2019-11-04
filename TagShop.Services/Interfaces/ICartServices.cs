using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Services.Interfaces
{
    public interface ICartServices
    {
        Cart Insert(Cart obj);
        Cart ChangeStatus(Guid key);
        List<Cart> GetAll();
        Cart GetById(Guid key);
    }
}
