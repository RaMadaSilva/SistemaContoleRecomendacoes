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

            //Relacionamentos por fazer
            //Membro; Igreja; 
        }
    }
}