using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentConstructionMach.Dto.MachineDtos;

namespace RentConstructionMach.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultLast5CarsWithBrandComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultLast5CarsWithBrandComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responsemsg = await client.GetAsync("https://localhost:7053/api/MachinePricings");
            if (responsemsg.IsSuccessStatusCode)
            {
                var jsonData = await responsemsg.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast5CarsWithBrandsDtos>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
