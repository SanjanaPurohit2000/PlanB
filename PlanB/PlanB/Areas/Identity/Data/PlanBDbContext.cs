﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PlanB.Areas.Identity.Data;
using PlanB.Models;

namespace PlanB.Data
{
    public class PlanBDbContext : IdentityDbContext<ApplicationUser>
    {
        public PlanBDbContext(DbContextOptions<PlanBDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Product> products { get; set; }
        public DbSet<WishList> wishLists { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }

    }
}
