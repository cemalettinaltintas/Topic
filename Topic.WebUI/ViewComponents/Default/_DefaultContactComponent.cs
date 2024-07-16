using Microsoft.AspNetCore.Mvc;
using Topic.DTOLayer.Dtos.ContactDtos;

namespace Topic.WebUI.ViewComponents.Default
{
    public class _DefaultContactComponent:ViewComponent
    {
        private readonly HttpClient _client;

        public _DefaultContactComponent(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7003/api/");
            _client = client;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values =await _client.GetFromJsonAsync<List<ResultContactDto>>("contacts");
            return View(values);
        }
    }
}
