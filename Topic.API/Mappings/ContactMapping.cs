using AutoMapper;
using Topic.DTOLayer.Dtos.ContactDtos;
using Topic.EntityLayer.Entities;

namespace Topic.API.Mappings
{
    public class ContactMapping:Profile
    {
        public ContactMapping()
        {
            CreateMap<ResultContactDto,Contact>().ReverseMap();
        }
    }
}
