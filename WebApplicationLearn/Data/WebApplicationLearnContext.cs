using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationLearn.Models;

namespace WebApplicationLearn.Data
{
    public class WebApplicationLearnContext : DbContext
    {
        public WebApplicationLearnContext (DbContextOptions<WebApplicationLearnContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationLearn.Models.Movie> Movie { get; set; } = default!;
    }
}
