using Blogs.Data;
using Blogs.Models;
using Blogs.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blogs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatagoriesController : ControllerBase
    {
        private readonly CategoriesDbContext dbContext;

        public CatagoriesController(CategoriesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoriesRequestDto request)
        {
            var Category = new Categories
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle,

            };

            await dbContext.Categories.AddAsync(Category);
            await dbContext.SaveChangesAsync();

            return Ok(Category);
                
        }

        
    }
}
