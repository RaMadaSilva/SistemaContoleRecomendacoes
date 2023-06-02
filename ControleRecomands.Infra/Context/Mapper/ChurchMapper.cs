using System.IO.Compression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleRecommads.Domain.Entities.ValueObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleRecomands.Infra.Context.Mapper
{
    public class ChurchMapper : IEntityTypeConfiguration<Church>
    {
        public void Configure(EntityTypeBuilder<Church> builder)
        {
            builder.ToTable("Church");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("Id");

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.Localization)
                .IsRequired()
                .HasColumnName("Localization")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(200);


        }
    }
}