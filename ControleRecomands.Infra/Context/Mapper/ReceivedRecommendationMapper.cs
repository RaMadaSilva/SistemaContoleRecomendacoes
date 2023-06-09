using ControleRecommads.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleRecomands.Infra.Context.Mapper
{
    public class ReceivedRecommendationMapper : IEntityTypeConfiguration<ReceivedRecommendation>
    {
        public void Configure(EntityTypeBuilder<ReceivedRecommendation> builder)
        {
            throw new NotImplementedException();
        }
    }
}