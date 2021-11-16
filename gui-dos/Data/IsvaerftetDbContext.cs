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

        public static readonly string IsvaerftetDb = nameof(IsvaerftetDb).ToLower();

        // sqlite cannot store a list of things thus we have to specify how to convert our lists
        // this is really annoying
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                        .Property(e => e.GiftBaskets)
                        .HasConversion
                        (
                            v => JsonSerializer.Serialize<List<GiftBasket>>(v, default),
                            v => JsonSerializer.Deserialize<List<GiftBasket>>(v, default)
                        );

            modelBuilder.Entity<Order>()
                        .Property(e => e.Changelog)
                        .HasConversion
                        (
                            v => JsonSerializer.Serialize<List<Change>>(v, default),
                            v => JsonSerializer.Deserialize<List<Change>>(v, default)
                        );

            modelBuilder.Entity<Product>()
                        .Property(e => e.Changelog)
                        .HasConversion
                        (
                            v => JsonSerializer.Serialize<List<Change>>(v, default),
                            v => JsonSerializer.Deserialize<List<Change>>(v, default)
                        );
        }

        public IsvaerftetDbContext(DbContextOptions<IsvaerftetDbContext> opt) : base(opt) {}
    }
}
