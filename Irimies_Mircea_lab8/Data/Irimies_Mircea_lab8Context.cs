using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Irimies_Mircea_lab8.Models;

namespace Irimies_Mircea_lab8.Data
{
    public class Irimies_Mircea_lab8Context : DbContext
    {
        public Irimies_Mircea_lab8Context (DbContextOptions<Irimies_Mircea_lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Irimies_Mircea_lab8.Models.Book> Book { get; set; }

        public DbSet<Irimies_Mircea_lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Irimies_Mircea_lab8.Models.Category> Category { get; set; }
    }
}
