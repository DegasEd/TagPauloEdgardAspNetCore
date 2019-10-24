using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TagShop.Api.ViewModels.Categories;
using TagShop.Domain.Models;

namespace TagShop.Api.AutoMapper.Profiles
{
    public class DomainToViewModel : Profile
    {
        public DomainToViewModel()
        {
            CreateMap<Category, CategoryViewModel>();
            CreateMap<Category, CreateCategoryViewModel>();
        }
    }
}
