using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stance_George_Lab2.Models;

namespace Stance_George_Lab2.Data
{
    public class Stance_George_Lab2Context : DbContext
    {
        public Stance_George_Lab2Context (DbContextOptions<Stance_George_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Stance_George_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Stance_George_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Stance_George_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
