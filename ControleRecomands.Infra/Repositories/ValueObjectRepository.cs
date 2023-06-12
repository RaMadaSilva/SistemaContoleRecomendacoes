using ControleRecomands.Infra.Context;
using ControleRecommads.Domain.Entities.ValueObject;
using ControleRecommads.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace ControleRecomands.Infra.Repositories
{
    public class ValueObjectRepository<V> : IValueObjectRepository<V> where V : ValueObject
    {
        private readonly RecommendationDbContext _context;
        private readonly DbSet<V> _dbSet;

        public ValueObjectRepository(RecommendationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<V>();

        }

        public void Add(V valueObject)
        {
            _dbSet.Add(valueObject);
        }
    }
}