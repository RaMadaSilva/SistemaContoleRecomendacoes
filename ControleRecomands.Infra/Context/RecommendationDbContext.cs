using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.ValueObject;
using Microsoft.EntityFrameworkCore;

namespace ControleRecomands.Infra.Context
{
    public class RecommendationDbContext : DbContext
    {
        public RecommendationDbContext(DbContextOptions<RecommendationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Member> Members { get; set; }
        public DbSet<Church> Churches { get; set; }
        public DbSet<IssuedRecommendation> IssuedRecommendations { get; set; }
        public DbSet<ReceivedRecommendation> ReceivedRecommendations { get; set; }
    }
}