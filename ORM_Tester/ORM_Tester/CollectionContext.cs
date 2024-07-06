using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;

namespace ORM_Tester
{
    internal class CollectionContext:DbContext
    {
        public DbSet<Users> user { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            String coStr = "Server=localhost;port=3306;User=root;Password=Shiv@1234;Database=apnidukaan";
            optionsBuilder.UseMySQL(coStr);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.name).IsRequired();
                entity.Property(e =>e.email).IsRequired();
                entity.Property(e => e.password).IsRequired();
                entity.Property(e => e.contactNo).IsRequired();
            });
        }
    }
}
