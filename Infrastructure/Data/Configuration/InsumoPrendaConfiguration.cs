using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class InsumoPrendaConfiguration : IEntityTypeConfiguration<InsumoPrenda>
{
    public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
    {
        builder.ToTable("insumoprenda");

        builder.HasKey(x => new{x.IdInsumoFk,x.IdPrendaFk});

        builder.Property(x => x.Cantidad).HasColumnType("int");
        

        builder.HasOne(x => x.Insumos).WithMany(x => x.InsumoPrendas).HasForeignKey(x => x.IdInsumoFk);
        builder.HasOne(x => x.Prendas).WithMany(x => x.InsumoPrendas).HasForeignKey(x => x.IdPrendaFk);
    }
}
