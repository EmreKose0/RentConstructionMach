using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentConstructionMach.Dto.BlogDtos;

namespace RentConstructionMach.WebUI.ViewComponents.DefaultViewComponents
{
    public class _GetBlogsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _GetBlogsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responsemsg = await client.GetAsync("https://localhost:7053/api/Blogs");
            if (responsemsg.IsSuccessStatusCode)
            {
                var jsonData = await responsemsg.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBlogDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
