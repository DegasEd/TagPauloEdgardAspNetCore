using AutoMapper;
using TagShop.Domain.Models;
using TagShop.Api.ViewModels.Carts;
using TagShop.Api.ViewModels.Categories;
using TagShop.Api.ViewModels.Customers;
using TagShop.Api.ViewModels.Products;
using TagShop.Api.ViewModels.Sales;
using TagShop.Api.ViewModels.SalesItem;
using TagShop.Api.ViewModels.Images;

namespace TagShop.Api.AutoMapper.Profiles
{
    /// <summary>
    /// 
    /// </summary>
    public class DomainToViewModel : Profile
    {
        public DomainToViewModel()
        {
            #region Mapeamento Category

            CreateMap<Category, CategoryViewModel>();


            #endregion

            #region Mapeamento Client

            CreateMap<Client, ClientViewModel>();

            #endregion

            CreateMap<Product,  ProductViewModel>();

            CreateMap<Cart, CartViewModel>();
            CreateMap<Cart, ResultCreateCartViewModel>()
              .ForMember(c => c.Key, d => d.MapFrom(map => map.Key))
              .ForMember(c => c.CreatedDate, d => d.MapFrom(map => map.CreatedDate))
              .ForMember(c => c.UpdatedDate, d => d.MapFrom(map => map.UpdatedDate))
              .ForMember(c => c.IsActive, d => d.MapFrom(map => map.IsActive));

            CreateMap<Sale, SaleViewModel>();
            CreateMap<SaleItem, SaleItemViewModel>();
            CreateMap<Image, ImageViewModel>();
        }
    }
}
