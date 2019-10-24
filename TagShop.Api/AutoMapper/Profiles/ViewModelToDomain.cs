using AutoMapper;
using TagShop.Api.ViewModels;
using TagShop.Api.ViewModels.Categories;
using TagShop.Api.ViewModels.Customers;
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
        }


    }
}
