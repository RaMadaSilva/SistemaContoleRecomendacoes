using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleRecommads.Domain.Entities.ValueObject;
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
            .HasColumnName("MemberId");

            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasColumnName("FistName")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(50);

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasColumnName("LastName")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(50);

            builder.Property(x => x.TelefoneNumber)
                .IsRequired()
                .HasColumnName("PhoneNumber")
                .HasColumnType("INT");

            builder.Property(x => x.Residence)
                .HasColumnName("Residence")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(200);


        }
    }
}