using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
{
    public void Configure(EntityTypeBuilder<Proveedor> builder)
    {
        builder.ToTable("proveedor");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x=>x.NitProveedor).IsRequired().HasMaxLength(50);
        builder.HasIndex(x=>x.NitProveedor).IsUnique();
        builder.Property(x=>x.NombreProveedor).IsRequired().HasMaxLength(80);

        builder.HasOne(x => x.TipoPersonas).WithMany(x => x.Proveedors).HasForeignKey(x => x.IdTipoPersonaFK);
        builder.HasOne(x => x.Municipios).WithMany(x => x.Proveedores).HasForeignKey(x => x.IdMunicipioFK);
    }
}
