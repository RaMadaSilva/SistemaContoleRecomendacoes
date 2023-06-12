using ControleRecomands.Infra.Context;
using ControleRecommads.Domain.Entities.ValueObject;
using ControleRecommads.Domain.IRepositories;

namespace ControleRecomands.Infra.Repositories
{
    public class MembreRepository : IMemberRepository
    {
        private readonly RecommendationDbContext _context;

        public MembreRepository(RecommendationDbContext context)
        {
            _context = context;
        }

        public void AddMembrer(Member member)
        {
            _context.Set<Member>().Add(member);
        }
    }
}