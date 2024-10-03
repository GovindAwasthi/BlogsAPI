using Blogs.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Blogs.Data
{
    public class CategoriesDbContext:DbContext
    {
        public CategoriesDbContext(DbContextOptions options) : base(options) { 
        }
                    
        public DbSet<BlogPost> Posts { get; set; }
        public DbSet<Categories> Categories { get; set;}    
    }
}
