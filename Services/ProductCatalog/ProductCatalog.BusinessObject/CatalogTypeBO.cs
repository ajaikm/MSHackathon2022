using ProductCatalog.Domain;
using ProductCatalog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.BusinessObject
{
    public class CatalogTypeBO : ICatalogTypeBO
    {
        ICatalogTypeRepository _repository;
        public CatalogTypeBO(ICatalogTypeRepository repository)
        {
            _repository = repository;
        }
        public async Task<CatalogType> Add(CatalogType item)
        {
            await _repository.Add(item);
            return item;
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }

        public async Task<CatalogType> GetCatalogTypeDetails(int id)
        {
            return await _repository.GetDetails(id);

        }

        public async Task<IEnumerable<CatalogType>> GetCatalogType()
        {
            return await _repository.GetItems();

        }

        public async Task Update(CatalogType item)
        {
            await _repository.Update(item);
        }
    }
}
