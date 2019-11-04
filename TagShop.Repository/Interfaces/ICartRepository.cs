using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Repository.Interfaces
{
    public interface ICartRepository
    {
        Cart Insert(Cart obj);
        Cart ChangeStatus(Guid key);
        List<Cart> GetAll();
        List<Cart> GetById(Guid key);
    }
}
