using ProductCatalog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.BusinessObject
{
    public interface ICatalogTypeBO
    {
        Task<IEnumerable<CatalogType>> GetCatalogType();
        Task<CatalogType> GetCatalogTypeDetails(int id);
        Task<CatalogType> Add(CatalogType item);
        Task Update(CatalogType item);
        Task Delete(int id);
    }
}
