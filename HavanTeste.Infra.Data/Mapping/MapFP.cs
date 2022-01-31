using HavanTeste.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavanTeste.Infra.Data.Mapping
{
    public class MapFP : IEntityTypeConfiguration<FamiliaProduto>
    {
        public void Configure(EntityTypeBuilder<FamiliaProduto> builder)
        {
            builder.ToTable("familiaproduto");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("nome")
                .HasColumnType("varchar(120)");

        }
    }
}
