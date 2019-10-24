using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Business.Interfaces;
using TagShop.Domain.Models;
using TagShop.Repository;
using TagShop.Repository.Interfaces;

namespace TagShop.Business
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly IProductRepository _productRepository;

        public ProductBusiness(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product ChangePrice(Product obj, long newprice)
        {
            obj.Price = newprice;
            return _productRepository.ChangePrice(obj);
        }

        public Product ChangeStatus(Product obj)
        {
            obj.ChangeStatus();
            obj.SetUpdateDate();
            return _productRepository.ChangePrice(obj);
        }

        public Product DecreaseStock(Product obj, int subtract)
        {
            obj.SetUpdateDate();
            obj.StockAmount -= subtract;
            return _productRepository.ChangeStock(obj);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public List<Product> GetByCategoryKey(Guid key)
        {
            return _productRepository.GetByCategoryKey(key);
        }

        public List<Product> GetById(Guid key)
        {
            return _productRepository.GetById(key);
        }

        public Product IncreaseStock(Product obj, int add)
        {
            obj.SetUpdateDate();
            obj.StockAmount += add;
            return _productRepository.ChangeStock(obj);
        }

        public Product Insert(Product obj)
        {
            return _productRepository.Insert(obj);
        }

        public Product Update(Product obj)
        {
            return _productRepository.Update(obj);
        }
    }
}
