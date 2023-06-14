using ControleRecommads.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleRecomands.Infra.Context.Mapper
{
    public class ReceivedRecommendationMapper : IEntityTypeConfiguration<ReceivedRecommendation>
    {
        public void Configure(EntityTypeBuilder<ReceivedRecommendation> builder)
        {
            builder.ToTable("ReceivedRecommendation");

            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("Id");

            builder.Property(x => x.State)
                .IsRequired()
                .HasColumnName("StateRecommendation");

            builder.Property<DateTime>(x => x.EntryDate)
                .IsRequired()
                .HasColumnName("EntryDate");

            builder.Property<DateTime>(x => x.RecommendationDate)
                .IsRequired()
                .HasColumnName("RecommendationDate");

            builder.Property<DateTime>(x => x.ValidateDate)
                .IsRequired()
                .HasColumnName("ValidateDate");

            builder.Property<DateTime?>(x => x.DevolutionDate)
                .HasColumnName("RetornDate");

            builder.Property<string?>(x => x.AttachmentRecommendationUrl)
                .HasColumnName("AttachmentRecommendationUrl")
                .HasMaxLength(300);

            //Relacionamento com membro
            builder.HasOne(r => r.Member)
                .WithMany()
                .HasForeignKey("")
                .OnDelete(DeleteBehavior.Cascade);

            //Relacionamento com A Igreja 
            builder.HasOne(r => r.Church)
                .WithMany()
                .HasForeignKey("ChurchId")
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}