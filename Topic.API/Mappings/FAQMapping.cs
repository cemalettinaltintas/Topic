using AutoMapper;
using Topic.DTOLayer.Dtos.FAQDtos;
using Topic.EntityLayer.Entities;

namespace Topic.API.Mappings
{
    public class FAQMapping:Profile
    {
        public FAQMapping()
        {
            CreateMap<FAQ, ResultFAQDto>().ReverseMap();  
        }
    }
}
