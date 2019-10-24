using AutoMapper;
using TagShop.Api.ViewModels;
using TagShop.Api.ViewModels.Categories;
using TagShop.Domain.Models;

namespace TagShop.Api.AutoMapper.Profiles
{
    public class ViewModelToDomain : Profile
    {
        public ViewModelToDomain()
        {
            CreateMap<CategoryViewModel, Category>();
            CreateMap<CreateCategoryViewModel, Category>().ForMember(c => c.Description, d => d.MapFrom(map => map.Description));

        }


    }
}
