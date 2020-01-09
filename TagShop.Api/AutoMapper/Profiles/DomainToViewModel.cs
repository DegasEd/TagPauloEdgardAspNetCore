using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TagShop.Api.ViewModels;
using TagShop.Api.ViewModels.Carts;
using TagShop.Api.ViewModels.Categories;
using TagShop.Api.ViewModels.Customers;
using TagShop.Domain.Models;
using TagShop.Api.ViewModels.Products;
using TagShop.Api.ViewModels.CartItems;

namespace TagShop.Api.AutoMapper.Profiles
{
    /// <summary>
    /// 
    /// </summary>
    public class DomainToViewModel : Profile
    {
        ///<sumary>
        ///
        ///</sumary>
        public DomainToViewModel()
        {
            #region Mapeamento Category

            CreateMap<Category, CategoryViewModel>();


            #endregion

            #region Mapeamento Client

            CreateMap<Client, ClientViewModel>();

            #endregion

            #region Mapeamento Product

            CreateMap<Product, ProductViewModel>();

            #endregion

            #region Mapeamento Cart

            CreateMap<Cart, CartViewModel>();
            CreateMap<Cart, ResultCreateCartViewModel>()
              .ForMember(c => c.Key, d => d.MapFrom(map => map.Key))
              .ForMember(c => c.CreatedDate, d => d.MapFrom(map => map.CreatedDate))
              .ForMember(c => c.UpdatedDate, d => d.MapFrom(map => map.UpdatedDate))
              .ForMember(c => c.IsActive, d => d.MapFrom(map => map.IsActive));

            #endregion

            CreateMap<CartItem, CartItemViewModel>()
                .ForMember(c => c.Key, d => d.MapFrom(map => map.Key));
                




        }
    }
}
