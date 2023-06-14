using ControleRecomands.Infra.Context;
using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.ValueObject;
using ControleRecommads.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace ControleRecomands.Infra.Repositories
{
    public class EntityRepository<E> : IEntityRepository<E> where E : Entity
    {
        private readonly RecommendationDbContext _context;
        private readonly DbSet<E> _dbSet;

        public EntityRepository(RecommendationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<E>();

        }


        public void Create(E entity)
        {
            _dbSet.Add(entity);
        }
    }
}