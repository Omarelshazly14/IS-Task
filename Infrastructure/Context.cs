using Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Context : IdentityDbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here
            modelBuilder.ApplyConfiguration(new OrderHeaderMapping());
            modelBuilder.ApplyConfiguration(new OrderDetailsMapping());
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<OrderHeader> Orders { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
    }
}
