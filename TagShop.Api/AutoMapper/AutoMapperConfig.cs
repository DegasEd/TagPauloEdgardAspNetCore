using AutoMapper;
using System.Diagnostics.CodeAnalysis;
using TagShop.Api.AutoMapper.Profiles;

namespace TagShop.Api.AutoMapper
{
    [ExcludeFromCodeCoverage]
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(ps =>
            {
                ps.AddProfile(new DomainToViewModel());
                ps.AddProfile(new ViewModelToDomain());
            });
        }

    }
}
