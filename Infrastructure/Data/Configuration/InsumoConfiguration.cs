using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class InsumoConfiguration : IEntityTypeConfiguration<Insumo>
{
    public void Configure(EntityTypeBuilder<Insumo> builder)
    {
        builder.ToTable("insumo");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x=>x.NombreInsumo).IsRequired().HasMaxLength(50);
        builder.HasIndex(x=>x.NombreInsumo).IsUnique();        
        builder.Property(x=>x.ValorUnit).HasColumnType("double");
        builder.Property(x=>x.StockMin).HasColumnType("int");
        builder.Property(x=>x.StockMax).HasColumnType("int");

    }
}
