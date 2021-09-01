using GeneralStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace GeneralStoreAPI.Controllers
{
    public class ProductController : ApiController
    {
        private readonly GeneralStoreDbContext _context = new GeneralStoreDbContext();

        // C
        [HttpPost]
        public async Task<IHttpActionResult> PostProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                // This adds the product to the C# representation of the database, not the actual database
                _context.Products.Add(product);
                // This translates our changes to SQL and then executes them
                await _context.SaveChangesAsync();
                return Ok();
            }

            return BadRequest(ModelState);
        }
        // R
        [HttpGet]
        public async Task<IHttpActionResult> GetAllProducts()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return Ok(products);
        }
        // U
        // D
    }
}
