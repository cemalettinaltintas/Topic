﻿using Microsoft.AspNetCore.Mvc;
using Topic.DTOLayer.Dtos.ManuelDtos;

namespace Topic.WebUI.ViewComponents.Default
{
    public class _DefaultManuelComponent:ViewComponent
    {
        private readonly HttpClient _client;

        public _DefaultManuelComponent(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7003/api/");
            _client = client;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultManuelDto>>("manuels");
            return View(values);
        }
    }
}
