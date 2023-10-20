using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
{
    public void Configure(EntityTypeBuilder<Cargo> builder)
    {
        builder.ToTable("cargo");

        builder.HasKey(x=>x.Id);
        builder.Property(x=>x.Id);

        builder.Property(x=>x.Descripcion).IsRequired().HasMaxLength(300);
        builder.Property(x=>x.SuledoBase).HasColumnType("int");

    }
}
