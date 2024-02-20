using Mango.Services.ProductAPI.Data;
using Mango.Services.ProductAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.ProductAPI.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {
        private readonly AppDbContext _db;

        public ProductAPIController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public object Get()
        {
            try
            {
                IEnumerable<Product> objList = _db.Products.ToList();
                return objList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
