using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class TipoEstadoConfiguration : IEntityTypeConfiguration<TipoEstado>
{
    public void Configure(EntityTypeBuilder<TipoEstado> builder)
    {
        builder.ToTable("tipoestado");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x=>x.Descripcion).IsRequired().HasMaxLength(50);
    }
}
