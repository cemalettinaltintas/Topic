using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Topic.Business.Abstract;
using Topic.DTOLayer.Dtos.FAQDtos;

namespace Topic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FAQsController : ControllerBase
    {
        private readonly IFAQService _faqService;
        private readonly IMapper _mapper;

        public FAQsController(IFAQService faqService, IMapper mapper)
        {
            _faqService = faqService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult FAQlist()
        {
            var values=_faqService.TGetList();
            var faqs = _mapper.Map<List<ResultFAQDto>>(values);
            return Ok(faqs);
        }
    }
}
