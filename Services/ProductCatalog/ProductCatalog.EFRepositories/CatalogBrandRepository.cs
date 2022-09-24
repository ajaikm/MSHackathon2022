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
    public class CatalogBrandRepository : GenericRepository<CatalogBrand>, ICatalogBrandRepository
    {
        private ProductCatalogContext _context { get; }
        public CatalogBrandRepository(ProductCatalogContext context): base(context)
        {
            _context = context;
        }
      
    }
}
