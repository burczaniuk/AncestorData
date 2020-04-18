using AncestorData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AncestorData.EntityFramework
{
    public class GenealogicBaseContext :DbContext
    {
        public GenealogicBaseContext(DbContextOptions<GenealogicBaseContext> options) :base(options) 
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Database> Databases { get; set; }
    }
}
