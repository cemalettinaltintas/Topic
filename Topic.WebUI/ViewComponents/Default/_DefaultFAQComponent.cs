using Microsoft.AspNetCore.Mvc;
using Topic.DTOLayer.Dtos.FAQDtos;

namespace Topic.WebUI.ViewComponents.Default
{
    public class _DefaultFAQComponent:ViewComponent
    {
        private readonly HttpClient _client;

        public _DefaultFAQComponent(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7003/api/");
            _client = client;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultFAQDto>>("FAQs");
            return View(values);
        }
    }
}
