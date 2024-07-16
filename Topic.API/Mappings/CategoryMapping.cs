using AutoMapper;
using Topic.DTOLayer.Dtos.CategoryDto;
using Topic.EntityLayer.Entities;

namespace Topic.API.Mappings
{
    public class CategoryMapping: Profile
    {
        public CategoryMapping()
        {
            CreateMap<ResultCategoryDto,Category>().ReverseMap();
            CreateMap<CreateCategoryDto,Category>().ReverseMap();
            CreateMap<UpdateCategoryDto,Category>().ReverseMap();
        }
    }
}
