using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuharjoCore.Models;

namespace SuharjoCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            new ModelMap(builder.Entity<Category>());
            new ModelMap(builder.Entity<Item>());
        }
        public DbSet<SuharjoCore.Models.Category> Categories { get; set; }
        public DbSet<SuharjoCore.Models.Item> Items { get; set; }



    }
}
