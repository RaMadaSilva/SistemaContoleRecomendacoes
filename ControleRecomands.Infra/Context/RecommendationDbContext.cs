using ControleRecomands.Infra.Context.Mapper;
using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.ValueObject;
using Flunt.Notifications;
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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Ignore<Notification>();
            mb.Entity<Recommendation>().HasKey(r => r.Id);
            mb.Entity<ReceivedRecommendation>().HasBaseType<Recommendation>();
            mb.Entity<IssuedRecommendation>().HasBaseType<Recommendation>();

            mb.ApplyConfiguration(new MemberMapper());
            mb.ApplyConfiguration(new ChurchMapper());
            mb.ApplyConfiguration(new ReceivedRecommendationMapper());
            mb.ApplyConfiguration(new IssuedRecommendationMapper());

            base.OnModelCreating(mb);
        }
    }
}