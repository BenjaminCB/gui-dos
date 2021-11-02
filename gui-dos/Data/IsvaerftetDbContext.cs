using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using gui_dos.Models;

namespace gui_dos.Data
{
    public class IsvaerftetDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<DummyModel> Dummys { get; set; }

        public static readonly string IsvaerftetDb = nameof(IsvaerftetDb).ToLower();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DummyModel>()
                        .Property(e => e.Images)
                        .HasConversion
                        (
                            v => JsonSerializer.Serialize<List<String>>(v, default),
                            v => JsonSerializer.Deserialize<List<string>>(v, default)
                        );
        }

        public IsvaerftetDbContext(DbContextOptions<IsvaerftetDbContext> opt) : base(opt) {}
    }
}
