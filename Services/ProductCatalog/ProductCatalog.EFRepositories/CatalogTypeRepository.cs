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
    public class CatalogTypeRepository : GenericRepository<CatalogType>, ICatalogTypeRepository
    {
        public CatalogTypeRepository(ProductCatalogContext context) : base(context)
        {
            _context = context;
        }

        public ProductCatalogContext _context { get; }

      
    }
}
