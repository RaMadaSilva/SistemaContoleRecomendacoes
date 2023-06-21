using ControleRecomands.Infra.Context;
using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.Enums;
using ControleRecommads.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleRecomands.Infra.Repositories
{
    public  class ReceivedRecommendationRepository : RepositoryBase<ReceivedRecommendation>,IReceivedRecommendationRepository
    {
        private readonly RecommendationDbContext _context;

        public ReceivedRecommendationRepository(RecommendationDbContext context)
            : base(context)
        {
            _context = context;
        }

        public ReceivedRecommendation GetReceivedRecommendationValid(Member member)
        {
            var recommendation = _context.ReceivedRecommendations
                                    .Where(x => x.Member.Equals(member))
                                    .FirstOrDefault(x => x.State == ERecommendationState.valido);
            return recommendation??=recommendation; 
        }
    }
}
