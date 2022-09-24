using Microsoft.AspNetCore.Mvc.Rendering;
using MVCWebApp.Models;
using Newtonsoft.Json;

namespace MVCWebApp.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly string _remoteServiceBaseUrl;

        public CatalogService(IConfiguration config)
        {
            
            
            _remoteServiceBaseUrl = config["CatalogUrl"];
        }
        public async Task<IEnumerable<SelectListItem>> GetBrands()
        {
            var client = new HttpClient();
            var result = await client.GetAsync(_remoteServiceBaseUrl + "/api/CatalogBrand");
            var dataString = await result.Content.ReadAsStringAsync();
            var catalogBrands = JsonConvert.DeserializeObject<IEnumerable<CatalogItem>>(dataString);
            return new SelectList(catalogBrands, "Id", "Brand");
        }

        public async Task<IEnumerable<CatalogItem>> GetCatalogItems(int brand=0, int type = 0)
        {
            var client = new HttpClient();
            var result = await client.GetAsync(_remoteServiceBaseUrl + "/api/CatalogItems");
            var dataString = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<CatalogItem>>(dataString);
        }

        public async Task<CatalogItem> GetItemDetails(int id)
        {
            HttpClient client = new HttpClient();
            string strjson = await client.GetStringAsync(_remoteServiceBaseUrl + "/api/CatalogItems/" + id);
            CatalogItem items = JsonConvert.DeserializeObject<CatalogItem>(strjson);
            return items;

        }

        public async Task<IEnumerable<SelectListItem>> GetTypes()
        {
            var client = new HttpClient();
            var result = await client.GetAsync(_remoteServiceBaseUrl + "/api/CatalogType");
            var dataString = await result.Content.ReadAsStringAsync();
            var catalogTypes = JsonConvert.DeserializeObject<IEnumerable<CatalogItem>>(dataString);
            return new SelectList(catalogTypes, "Id", "Type");
        }
    }
}
