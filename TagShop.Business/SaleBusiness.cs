using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TagShop.Business.Interfaces;
using TagShop.Domain.Models;
using TagShop.Repository.Interfaces;

namespace TagShop.Business
{
    public class SaleBusiness : ISaleBusiness
    {
        private readonly ISaleRepository _saleRepository;

        public SaleBusiness(ISaleRepository saleRepository)
        {
            _saleRepository = saleRepository;
        }

        public Sale ChangeStatus(Guid key)
        {
            var obj = GetById(key).ToList().FirstOrDefault();
            obj.ChangeStatus();
            obj.SetUpdateDate();
            return _saleRepository.ChangeStatus(obj);

        }

        public List<Sale> GetAll()
        {
            return _saleRepository.GetAll();

        }

        public List<Sale> GetById(Guid key)
        {
            return _saleRepository.GetById(key);

        }

        public Sale Insert(Sale obj)
        {
            return _saleRepository.Insert(obj);

        }
    }
}
