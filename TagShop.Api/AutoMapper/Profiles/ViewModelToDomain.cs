using AutoMapper;
using TagShop.Api.ViewModels;
using TagShop.Api.ViewModels.CartItems;
using TagShop.Api.ViewModels.Carts;
using TagShop.Api.ViewModels.Categories;
using TagShop.Api.ViewModels.Customers;
using TagShop.Api.ViewModels.Products;
using TagShop.Domain.Models;

namespace TagShop.Api.AutoMapper.Profiles
{
    public class ViewModelToDomain : Profile
    {
        /// <summary>
        /// 
        /// </summary>
        public ViewModelToDomain()
        {
            #region Mapeamento Category

            CreateMap<CategoryViewModel, Category>();
            CreateMap<CreateCategoryViewModel, Category>().ForMember(c => c.Description, d => d.MapFrom(map => map.Description));


            #endregion

            #region Mapeamento Client

            CreateMap<ClientViewModel, Client>();
            CreateMap<CreateClientViewModel, Client>()
                .ForMember(c => c.Cpf, d => d.MapFrom(map => map.Cpf))
                .ForMember(c => c.Name, d => d.MapFrom(map => map.Name))
                .ForMember(c => c.BirthDate, d => d.MapFrom(map => map.BirthDate))
                .ForMember(c => c.Email, d => d.MapFrom(map => map.Email))
                .ForMember(c => c.Password, d => d.MapFrom(map => map.Password))
                .ForMember(c => c.Address, d => d.MapFrom(map => map.Address))
                .ForMember(c => c.City, d => d.MapFrom(map => map.City))
                .ForMember(c => c.State, d => d.MapFrom(map => map.State))
                .ForMember(c => c.ZipCode, d => d.MapFrom(map => map.ZipCode))
                .ForMember(c => c.Phone, d => d.MapFrom(map => map.Phone));
            #endregion

            CreateMap<ProductViewModel, Product>();
            CreateMap<CreateProductViewModel, Product>().ForMember(c => c.Description, d => d.MapFrom(map => map.Description))
                                                        .ForMember(c => c.Detail, d => d.MapFrom(map => map.Detail))
                                                        .ForMember(c => c.StockAmount, d => d.MapFrom(map => map.StockAmount))
                                                        .ForMember(c => c.Price, d => d.MapFrom(map => map.Price))
                                                        .ForMember(c => c.CategoryId, d => d.MapFrom(map => map.CategoryId));
            #region Mapeamento Cart

            CreateMap<CartViewModel, Cart>();
            CreateMap<CreateCartViewModel, Cart>()
                .ForMember(c => c.ClientId, d => d.MapFrom(map => map.ClientId));

            #endregion

            #region Mapeamento CartItem

            CreateMap<CreateCartItemViewModel, CartItem>().ForMember(c => c.Product.Key, d => d.MapFrom(map => map.Productkey))
                                                          .ForMember(c => c.Amount, d => d.MapFrom(map => map.Amount))
                                                          .ForMember(c => c.Key, d => d.MapFrom(map => map.Cartkey));

            #endregion
        }


    }
}
