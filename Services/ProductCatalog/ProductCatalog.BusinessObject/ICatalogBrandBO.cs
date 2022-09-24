using ProductCatalog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.BusinessObject
{
    public interface ICatalogBrandBO
    {
        Task<IEnumerable<CatalogBrand>> GetCatalogBrand();
        Task<CatalogBrand> GetCatalogBrandDetails(int id);
        Task<CatalogBrand> Add(CatalogBrand item);
        Task Update(CatalogBrand item);
        Task Delete(int id);
    }
}
