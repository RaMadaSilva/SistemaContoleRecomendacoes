using ControleRecomands.Infra.Context;
using ControleRecommads.Domain.Entities.ValueObject;
using ControleRecommads.Domain.IRepositories;

namespace ControleRecomands.Infra.Repositories
{
    public class ValueObjectRepository<V> : IValueObjectRepository<V> where V : ValueObject
    {
        private readonly RecommendationDbContext _context;

        public ValueObjectRepository(RecommendationDbContext context)
        {
            _context = context;
        }

        public void Add(V valueObject)
        {
            _context.Set<V>().Add(valueObject);
        }
    }
}