using ControleRecommads.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleRecomands.Infra.Context.Mapper
{
    public class IssuedRecommendationMapper : IEntityTypeConfiguration<IssuedRecommendation>
    {
        public void Configure(EntityTypeBuilder<IssuedRecommendation> builder)
        {
            builder.ToTable("IssuedRecommendation");
            builder.HasKey(x => x.Id);

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
                .HasColumnName("DevolutionDate");

            builder.Property<string?>(x => x.RecommendationGeneratedUrl)
                .HasColumnName("RecommendationGenerateUrl")
                .HasMaxLength(300);

            //Relacionamentos por fazer
            //Membro; Igreja; 
        }
    }
}