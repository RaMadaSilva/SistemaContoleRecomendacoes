using ControleRecommads.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleRecomands.Infra.Context.Mapper
{
    public class MemberMapper : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.ToTable("Member");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
            .IsRequired()
            .HasColumnName("Id");

            builder.OwnsOne(x => x.Name)
                .Property(x => x.NameComplete)
                .IsRequired()
                .HasColumnName("NameComplete")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.Phone)
                .IsRequired()
                .HasColumnName("PhoneNumber")
                .HasColumnType("INT");

            builder.OwnsOne(x => x.Adress)
                .Property(x => x.City)
                .IsRequired()
                .HasColumnName("City")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

            builder.OwnsOne(x => x.Adress)
                .Property(x => x.Reference)
                .IsRequired()
                .HasColumnName("Reference")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);
        }
    }
}