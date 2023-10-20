using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
{
    public void Configure(EntityTypeBuilder<Empleado> builder)
    {
        builder.ToTable("empleado");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.IdEmpleado).HasColumnType("int");
        builder.HasIndex(x=>x.IdEmpleado).IsUnique();
        builder.Property(x=>x.NombreEmpleado).IsRequired().HasMaxLength(80);
        builder.Property(x => x.FechaIngreso).HasColumnType("date");
        

        builder.HasOne(x => x.Cargos).WithMany(x => x.Empleados).HasForeignKey(x => x.IdCargoFk);
        builder.HasOne(x => x.Municipios).WithMany(x => x.Empleados).HasForeignKey(x => x.IdMunicipioFk);
    }
}
