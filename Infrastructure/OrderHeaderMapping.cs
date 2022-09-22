using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class OrderHeaderMapping : IEntityTypeConfiguration<OrderHeader>
    {
        public void Configure(EntityTypeBuilder<OrderHeader> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.CustomerName).HasMaxLength(250).IsRequired();
            builder.Property(c => c.Date).HasDefaultValueSql("getdate()");
            builder.Property(c => c.Address);
            builder.Property(c => c.Phone);
            builder.Property(c => c.TotalCost);
            builder.Property(c => c.OrderNo);

            builder.HasMany(c => c.OrderDetails).WithOne(p => p.Order).HasForeignKey(p => p.OrderID);
        }
    }
}
