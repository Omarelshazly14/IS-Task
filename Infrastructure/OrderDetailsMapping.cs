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
    public class OrderDetailsMapping : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            builder.ToTable("OrderDetails");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.ItemDescription).HasMaxLength(250).IsRequired();
            builder.Property(p => p.ItemPrice);
            builder.Property(p => p.ItemNo);
            builder.HasOne(p => p.Order).WithMany(c => c.OrderDetails).HasForeignKey(p => p.OrderID);
        }
    }
}
