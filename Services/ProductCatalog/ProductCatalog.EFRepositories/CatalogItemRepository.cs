using Microsoft.EntityFrameworkCore;
using ProductCatalog.Domain;
using ProductCatalog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.EFRepositories
{
    public class CatalogItemRepository : GenericRepository<CatalogItem>,ICatalogItemRepository
    {
        public CatalogItemRepository(ProductCatalogContext context) : base(context)
        {
            _context = context;
        }

        public ProductCatalogContext _context { get; }

     
        public async override Task<CatalogItem> GetDetails(int id)
        {
            var catalogItem =  await _context.CatalogItems.Include("CatalogType").Include("CatalogBrand").Where(item => item.Id == id).FirstOrDefaultAsync();

            if (catalogItem == null)
            {
                throw new ApplicationException("No item found");
            }
            return catalogItem;
        }

        public async override Task<IEnumerable<CatalogItem>> GetItems()
        {
            return await _context.CatalogItems.Include("CatalogType").Include("CatalogBrand").ToListAsync();
        }

     
    }
}
