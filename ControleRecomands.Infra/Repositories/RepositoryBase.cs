using System.Linq.Expressions;
using ControleRecomands.Infra.Context;
using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.Enums;
using ControleRecommads.Domain.Entities.ValueObject;
using ControleRecommads.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace ControleRecomands.Infra.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : Recommendation
    {
        private readonly RecommendationDbContext _context;
        private readonly DbSet<T> _dbSet;
        public RepositoryBase(RecommendationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Create(T recommendation)
        {
            _dbSet.Add(recommendation);
        }
        public IEnumerable<T> GetAllRecommendation()
        {
            return _dbSet.AsNoTracking();
        }
        public IEnumerable<T> GetAllRecommendationWithState(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }
        public T GetRecommendation(Guid id)
        {
            var recommendation = _dbSet.Find(id);
            if (recommendation is null)
                return null;
            return recommendation;
        }
        public T GetRecommendationValid(Member member)
        {
            var recommendation = _dbSet.Find(member);
            if (recommendation is null || recommendation.State != ERecommendationState.valido)
                return null;
            return recommendation;
        }

        public void UpdateRecommendation(T recommendation)
        {
            _context.Entry(recommendation).State = EntityState.Modified;
        }
    }
}