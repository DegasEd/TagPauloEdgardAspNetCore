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
            CreateMap<ResultCategoryViewModel, Category>();
            CreateMap<CreateCategoryViewModel, Category>();

        }

        
    }
}
