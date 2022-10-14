using FlinstonsBE.Data.Users.DataTransfer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlinstonsBE.Infrastructure.Context.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<UserDataTransfer>
    {
        public void Configure(EntityTypeBuilder<UserDataTransfer> builder)
        {
            builder.ToTable("TBL_USERS");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("ENT_ID");
            builder.Property(t => t.Name).HasColumnName("ENT_NAME").IsRequired().HasMaxLength(100);
            builder.Property(t => t.Email).HasColumnName("ENT_EMAIL").IsRequired().HasMaxLength(100);
        }

    }
}
