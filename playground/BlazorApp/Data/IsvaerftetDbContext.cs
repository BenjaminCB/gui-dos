using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BlazorApp.Models;

namespace BlazorApp.Data
{
    public class IsvaerftetDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public static readonly string IsvaerftetDb = nameof(IsvaerftetDb).ToLower();

        public IsvaerftetDbContext(DbContextOptions<IsvaerftetDbContext> opt) : base(opt) {}
    }
}
