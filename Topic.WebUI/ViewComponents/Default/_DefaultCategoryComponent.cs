﻿using Microsoft.AspNetCore.Mvc;
using Topic.WebUI.Dtos.CategoryDtos;

namespace Topic.WebUI.ViewComponents.Default
{
    public class _DefaultCategoryComponent:ViewComponent
    {
        private readonly HttpClient _client;

        public _DefaultCategoryComponent(HttpClient client)
        {
            _client = client;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values =await _client.GetFromJsonAsync<List<ResultCategoryDto>>("https://localhost:7003/api/categories/GetActivecategories");
            return View(values);
        }
    }
}
