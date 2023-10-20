using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
{
    public void Configure(EntityTypeBuilder<Orden> builder)
    {
        builder.ToTable("orden");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.Fecha).HasColumnType("date");
        

        builder.HasOne(x => x.Empleados).WithMany(x => x.Ordenes).HasForeignKey(x => x.IdEmpleadoFk);
        builder.HasOne(x => x.Clientes).WithMany(x => x.Ordenes).HasForeignKey(x => x.IdClienteFk);
        builder.HasOne(x => x.Estados).WithMany(x => x.Ordenes).HasForeignKey(x => x.IdEstadoFk);
    }
}
