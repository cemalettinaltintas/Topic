using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Topic.Business.Abstract;
using Topic.DTOLayer.Dtos.ContactDtos;

namespace Topic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactsController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ContactList() {
            var values=_contactService.TGetList();
            var contacts=_mapper.Map<List<ResultContactDto>>(values);
            return Ok(contacts);
        }
    }
}
