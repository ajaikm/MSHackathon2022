using Microsoft.AspNetCore.Mvc.Rendering;
using MVCWebApp.Models;

namespace MVCWebApp.Services
{
    public interface ICatalogService
    {
        Task<IEnumerable<CatalogItem>> GetCatalogItems(int brand= 0, int type=0);
        Task<CatalogItem> GetItemDetails(int id);
        Task<IEnumerable<SelectListItem>> GetBrands();
        Task<IEnumerable<SelectListItem>> GetTypes();
    }
}
