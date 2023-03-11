using Blogie.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Blogie.Web.Data
{
    public class BlogieDBContext : DbContext
    {
        public BlogieDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BlogPost> BlogPosts { get; set; } 
        public DbSet<Tag> Tags { get; set; }   
    }
}
