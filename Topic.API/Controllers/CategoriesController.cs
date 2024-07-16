using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Topic.Business.Abstract;
using Topic.DTOLayer.Dtos.CategoryDto;
using Topic.EntityLayer.Entities;

namespace Topic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var values = _categoryService.TGetList();
            var categories = _mapper.Map<List<ResultCategoryDto>>(values);
            return Ok(categories);
        }
        [HttpGet("{id}")]
        public IActionResult GetCategoryById(int id) 
        {
            var value=_categoryService.TGetById(id);
            var category=_mapper.Map<ResultCategoryDto>(value);
            return Ok(category);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id) 
        {
            _categoryService.TDelete(id);
            return Ok("Kategori başarıyla silindi");
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            var category = _mapper.Map<Category>(createCategoryDto);
            _categoryService.TUpdate(category);
            return Ok("Kategori başarıyla oluşturuldu");
        }
        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            var category=_mapper.Map<Category>(updateCategoryDto);
            _categoryService.TUpdate(category);
            return Ok("Kategori başarıyla güncellendi");
        }

        [HttpGet("GetActivecategories")]
        public IActionResult GetActivecategories()
        {
            var values = _categoryService.TGetActiveCategories();
            var mappedResult=_mapper.Map<List<ResultCategoryDto>>(values);
            return Ok(mappedResult);
        }
    }
}
