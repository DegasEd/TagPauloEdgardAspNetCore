using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Business.Interfaces;
using TagShop.Domain.Models;
using TagShop.Services.Interfaces;

namespace TagShop.Services
{
    class ProductServices : IProductServices
    {
        private readonly IProductBusiness _productBusiness;

        public ProductServices(IProductBusiness productBusiness)
        {
            _productBusiness = productBusiness;
        }

        public Product ChangePrice(Product obj, long newprice)
        {
            return _productBusiness.ChangePrice(obj, newprice);
        }

        public Product ChangeStatus(Product obj)
        {
            return _productBusiness.ChangeStatus(obj);
        }

        public Product DecreaseStock(Product obj, int subtract)
        {
            return _productBusiness.DecreaseStock(obj, subtract);
        }

        public List<Product> GetAll()
        {
            return _productBusiness.GetAll();
        }

        public List<Product> GetByCategoryKey(Guid key)
        {
            return _productBusiness.GetByCategoryKey(key);
        }

        public List<Product> GetById(Guid key)
        {
            return _productBusiness.GetById(key);
        }

        public Product IncreaseStock(Product obj, int add)
        {
            return _productBusiness.IncreaseStock(obj, add);
        }

        public Product Insert(Product obj)
        {
            return _productBusiness.Insert(obj);
        }

        public Product Update(Product obj)
        {
            return _productBusiness.Update(obj);
        }
    }
}
