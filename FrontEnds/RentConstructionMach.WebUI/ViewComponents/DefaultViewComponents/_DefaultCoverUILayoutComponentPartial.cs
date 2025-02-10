using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentConstructionMach.Dto.BannerDtos;

namespace RentConstructionMach.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultCoverUILayoutComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultCoverUILayoutComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responsemsg = await client.GetAsync("https://localhost:7053/api/Banners");
            if (responsemsg.IsSuccessStatusCode)
            {
                var jsonData = await responsemsg.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBannerDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
