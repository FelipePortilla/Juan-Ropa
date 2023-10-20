using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class TallaConfiguration : IEntityTypeConfiguration<Talla>
{
    public void Configure(EntityTypeBuilder<Talla> builder)
    {
        builder.ToTable("talla");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x=>x.Descripcion).IsRequired().HasMaxLength(300);
        builder.HasIndex(x=>x.Descripcion).IsUnique();

    }
}
