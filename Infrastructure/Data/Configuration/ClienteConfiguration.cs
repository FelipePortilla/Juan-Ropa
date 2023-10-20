using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("cliente");

        builder.HasKey(x=>x.Id);
        builder.Property(x=>x.Id);

        builder.Property(x=>x.IdCliente).IsRequired().HasMaxLength(50);
        builder.HasIndex(x=>x.IdCliente).IsUnique();
        
        builder.Property(x=>x.NombreCliente).IsRequired().HasMaxLength(50);
        builder.Property(x=>x.FechaRegistro).HasColumnType("date");
        builder.HasOne(x=>x.TipoPersonas).WithMany(x=>x.Clientes).HasForeignKey(x=>x.IdTipoPersonaFk);
        builder.HasOne(x=>x.Municipios).WithMany(x=>x.Clientes).HasForeignKey(x=>x.IdMunicipioFk);
    }
}
