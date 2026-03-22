using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P02_SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Configurations
{
    internal class SaleConfigurations : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasOne(s => s.Product).WithMany(p => p.Sales).HasForeignKey(s => s.ProductId);
            builder.HasOne(s => s.Store).WithMany(p => p.Sales).HasForeignKey(s => s.StoreId);
            builder.HasOne(s => s.Customer).WithMany(p => p.Sales).HasForeignKey(s => s.CustomerId);
            builder.Property(s => s.Date).HasDefaultValueSql("GETDATE()");
        }
    }
}
