using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Business.Interfaces;
using TagShop.Domain.Models;
using TagShop.Services.Interfaces;

namespace TagShop.Services
{
    public class ClientServices : IClientServices
    {
        private readonly IClientBusiness _clientBusiness;

        public ClientServices(IClientBusiness clientBusiness)
        {
            _clientBusiness = clientBusiness;
        }

        public Client ChangeStatus(Guid key)
        {
            return _clientBusiness.ChangeStatus(key);
        }

        public List<Client> GetAll()
        {
            return _clientBusiness.GetAll();
        }

        public Client GetById(Guid key)
        {
            return _clientBusiness.GetById(key);
        }

        public Client Insert(Client obj)
        {
            return _clientBusiness.Insert(obj);
        }

        public Client Update(Client obj)
        {
            return _clientBusiness.Update(obj);
        }
    }
}
