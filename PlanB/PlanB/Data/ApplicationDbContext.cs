using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PlanB.Models;

namespace PlanB.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<WishList> WishList { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

    }
}
