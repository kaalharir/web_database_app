using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Jokeswebpage.Models;

namespace Jokeswebpage.Data
{
    public class AppplicationDbContext : DbContext
    {
        public AppplicationDbContext (DbContextOptions<AppplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Jokeswebpage.Models.Joke> Joke { get; set; } = default!;
    }
}
