using FluentValidation;
using System;
using System.Collections.Generic;
using TagShop.Business.Interfaces;
using TagShop.Business.Validations;
using TagShop.Domain.Models;
using TagShop.Repository.Interfaces;

namespace TagShop.Business
{
    public class ClientBusiness : BaseValidator<Client> , IClientBusiness
    {
        private readonly IClientRepository _clientRepository;

        public ClientBusiness(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public Client ChangeStatus(Guid key)
        {
            return _clientRepository.ChangeStatus(key);
        }

        public List<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }

        public Client GetById(Guid key)
        {
            return _clientRepository.GetById(key);
        }

        public Client Insert(Client obj)
        {
            obj.ValidationResult = Validate(obj, Activator.CreateInstance<ClientValidator>());

            if (!obj.Valid)
            {
                return obj;
            }
            
            return _clientRepository.Insert(obj);
        }

        public Client Update(Client obj)
        {
            Validate(obj, Activator.CreateInstance<ClientValidator>());

            if (!obj.Valid)
            {
                return obj;
            }

            return _clientRepository.Update(obj);
        }
    }
}
