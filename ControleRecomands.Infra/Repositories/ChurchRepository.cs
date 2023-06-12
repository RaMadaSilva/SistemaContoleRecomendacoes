using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleRecomands.Infra.Context;
using ControleRecommads.Domain.Entities.ValueObject;
using ControleRecommads.Domain.IRepositories;

namespace ControleRecomands.Infra.Repositories
{
    public class ChurchRepository : IChurchRepository
    {
        private readonly RecommendationDbContext _context;

        public ChurchRepository(RecommendationDbContext context)
        {
            _context = context;
        }

        public void AddChurch(Church church)
        {
            _context.Set<Church>().Add(church);
        }
    }
}