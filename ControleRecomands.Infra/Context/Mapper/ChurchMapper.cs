using System.Security.Cryptography.X509Certificates;
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

            builder.OwnsOne(x => x.Name)
                .Property(x => x.NameComplete)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.OwnsOne(x => x.Adress)
                .Property(x => x.City)
                .IsRequired()
                .HasColumnName("City")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(200);

            builder.OwnsOne(x => x.Adress)
                .Property(x => x.Reference)
                .IsRequired()
                .HasColumnName("Reference")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(200);

        }
    }
}