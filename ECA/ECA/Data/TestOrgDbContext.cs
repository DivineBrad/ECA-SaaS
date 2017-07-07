using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ECA.Models;

namespace ECA.Data
{
    //Test Scenario - BB
    public class TestOrgDbContext :DbContext
    {

        public TestOrgDbContext(DbContextOptions<TestOrgDbContext> options) : base(options)
        {
        }

        // Test Scenario --BB
        public DbSet<Test> Tests { get; set; }
        public DbSet<CusInteraction> CusInteractions { get; set; }
        public DbSet<SupInteraction> SupInteractions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>().ToTable("Test");
            modelBuilder.Entity<CusInteraction>().ToTable("CusInteraction");
            modelBuilder.Entity<SupInteraction>().ToTable("SupInteraction");

        }

        




    }
}
