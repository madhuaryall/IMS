using IMS.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Infrastructure.Entity_Configuration
{
   public class StoreConfiguration:IEntityTypeConfiguration<StoreInfo>

    {
        public void Configure(EntityTypeBuilder<StoreInfo> builder)
        {

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Storename).IsUnicode(true);
            builder.Property(e => e.Address).IsUnicode(true);
            builder.Property(e => e.PhoneNumber).IsUnicode(true);
            builder.Property(e => e.RegistrationNumber).IsUnicode(true);
            builder.Property(e => e.PanNo).IsUnicode(true);
            //builder.Property(e => e.IsActive).HasDefaultValue(true);
           
           builder.Property(e => e.CreatedBy).IsUnicode(true);
            //builder.Property(e => e.CreatedDate).HasDefaultSql("GETDATE()");
            builder.Property(e => e.LastModifiedDate).IsUnicode(true);

        }

    }
}
