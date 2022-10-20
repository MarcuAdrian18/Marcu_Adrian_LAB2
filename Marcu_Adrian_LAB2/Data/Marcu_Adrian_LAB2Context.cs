using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Marcu_Adrian_LAB2.Models;

namespace Marcu_Adrian_LAB2.Data
{
    public class Marcu_Adrian_LAB2Context : DbContext
    {
        public Marcu_Adrian_LAB2Context (DbContextOptions<Marcu_Adrian_LAB2Context> options)
            : base(options)
        {
        }

        public DbSet<Marcu_Adrian_LAB2.Models.Book> Book { get; set; } = default!;

        public DbSet<Marcu_Adrian_LAB2.Models.Publisher> Publisher { get; set; }

        public DbSet<Marcu_Adrian_LAB2.Models.Author> Author { get; set; }
    }
}
