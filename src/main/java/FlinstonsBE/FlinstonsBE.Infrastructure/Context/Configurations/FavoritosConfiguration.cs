using FlinstonsBE.Data.Favoritos.DataTransfer;
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
    internal class FavoritosConfiguration : IEntityTypeConfiguration<FavoritoDataTransfer>
    {
        public void Configure(EntityTypeBuilder<FavoritoDataTransfer> builder)
        {
            builder.ToTable("TBL_FAVORITOS");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("FAV_ID");
            builder.Property(t => t.ItemId).HasColumnName("FAV_ITEMID").IsRequired();
            builder.Property(t => t.modelo).HasColumnName("FAV_MODELO").IsRequired().HasMaxLength(400);
            builder.Property(t => t.desc).HasColumnName("FAV_DESC").IsRequired().HasMaxLength(1000);
            builder.Property(t => t.img).HasColumnName("FAV_IMG").IsRequired().HasMaxLength(10000);
            builder.Property(t => t.link).HasColumnName("FAV_LINK").IsRequired().HasMaxLength(10000);
            builder.Property(t => t.preco).HasColumnName("FAV_PRECO").IsRequired();
        }
    }
}
