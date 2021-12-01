using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using gui_dos.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;

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
                            v => JsonSerializer.Deserialize<List<GiftBasket>>(v, default),
                            new ValueComparer<List<GiftBasket>>(
                                (g1, g2) => g1.SequenceEqual(g2),
                                g => g.Aggregate(0, (acc, val) => HashCode.Combine(acc, val.GetHashCode())),
                                g => g.ToList()
                            )
                        );

            modelBuilder.Entity<Order>()
                        .Property(e => e.Changelog)
                        .HasConversion
                        (
                            v => JsonSerializer.Serialize<List<Change>>(v, default),
                            v => JsonSerializer.Deserialize<List<Change>>(v, default),
                            new ValueComparer<List<Change>>(
                                (c1, c2) => c1.SequenceEqual(c2),
                                c => c.Aggregate(0, (acc, val) => HashCode.Combine(acc, val.GetHashCode())),
                                c => c.ToList()
                            )
                        );

            modelBuilder.Entity<Product>()
                        .Property(e => e.Changelog)
                        .HasConversion
                        (
                            v => JsonSerializer.Serialize<List<Change>>(v, default),
                            v => JsonSerializer.Deserialize<List<Change>>(v, default),
                            new ValueComparer<List<Change>>(
                                (c1, c2) => c1.SequenceEqual(c2),
                                c => c.Aggregate(0, (acc, val) => HashCode.Combine(acc, val.GetHashCode())),
                                c => c.ToList()
                            )
                        );
        }

        public IsvaerftetDbContext(DbContextOptions<IsvaerftetDbContext> opt) : base(opt) {}
    }
}
