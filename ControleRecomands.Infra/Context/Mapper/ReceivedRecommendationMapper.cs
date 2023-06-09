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
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired();

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

            //Relacionamentos
            builder.HasOne(x => x.Member)
                .WithMany()
                .HasForeignKey("MemberId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Origin)
                .WithMany()
                .HasForeignKey("ChurchId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}