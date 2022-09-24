using ProductCatalog.Domain;
using ProductCatalog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.BusinessObject
{
    public class CatalogBrandBO : ICatalogBrandBO
    {
        ICatalogBrandRepository _repository;
        public CatalogBrandBO(ICatalogBrandRepository repository)
        {
            _repository = repository;
        }
        public async Task<CatalogBrand> Add(CatalogBrand item)
        {
            await _repository.Add(item);
            return item;
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }

        public async Task<CatalogBrand> GetCatalogBrandDetails(int id)
        {
            return await _repository.GetDetails(id);

        }

        public async Task<IEnumerable<CatalogBrand>> GetCatalogBrand()
        {
            return await _repository.GetItems();

        }

        public async Task Update(CatalogBrand item)
        {
            await _repository.Update(item);
        }
    }
}
