using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureWebApp
{
    public class BloggingContext : DbContext
    {
        public BloggingContext()
        { }

        public BloggingContext(DbContextOptions<BloggingContext> options)
            : base(options)
        {
        }
        
        public DbSet<Blog> Blogs { get; set; }
    }
}
