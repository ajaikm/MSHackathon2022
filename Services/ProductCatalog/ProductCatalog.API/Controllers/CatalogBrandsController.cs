using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCatalog.BusinessObject;
using ProductCatalog.Domain;
using ProductCatalog.EFRepositories;

namespace ProductCatalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogBrandsController : ControllerBase
    {
     
        private readonly ICatalogBrandBO _catalogBrandBO;

        public CatalogBrandsController(ICatalogBrandBO catalogBrand)
        {
            _catalogBrandBO = catalogBrand;
        }

        // GET: api/CatalogBrands
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogBrand>>> GetCatalogBrands()
        {
            return Ok(await _catalogBrandBO.GetCatalogBrand());
        }

        // GET: api/CatalogItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogItem>> GetCatalogBrand(int id)
        {
            return Ok(await _catalogBrandBO.GetCatalogBrandDetails(id));
        }

        // PUT: api/CatalogBrands/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCatalogBrand(int id, CatalogBrand catalogBrand)
        {
            await _catalogBrandBO.Update(catalogBrand);
            return NoContent();
        }

        // POST: api/CatalogBrands
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CatalogBrand>> PostCatalogBrand(CatalogBrand catalogBrand)
        {
            return await _catalogBrandBO.Add(catalogBrand);
        }

        // DELETE: api/CatalogBrands/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCatalogBrand(int id)
        {
            await _catalogBrandBO.Delete(id);
            return NoContent();
        }
    }
}
