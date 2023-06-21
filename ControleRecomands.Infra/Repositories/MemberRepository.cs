using ControleRecomands.Infra.Context;
using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.ValueObject;
using ControleRecommads.Domain.IRepositories;

namespace ControleRecomands.Infra.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private readonly RecommendationDbContext _context;

        public MemberRepository(RecommendationDbContext context)
        {
            _context = context;
        }

        public Member GetMember(Name name, uint phone, Adress adress)
        {
            var member = _context.Members
                .Where(x=>x.Name ==name)
                .Where(x=>x.Phone==phone)
                .Where(x=>x.Adress==adress)
                .FirstOrDefault();
            return member; 
        }
    }
}
