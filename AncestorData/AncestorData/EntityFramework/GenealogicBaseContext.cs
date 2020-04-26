using AncestorData.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AncestorData.EntityFramework
{
    public class GenealogicBaseContext :IdentityDbContext<User>
    {
        public GenealogicBaseContext(DbContextOptions<GenealogicBaseContext> options) :base(options) 
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Database> Databases { get; set; }
    }
}
