

using ControleRecommads.Domain.Entities;

namespace ControleRecommads.Domain.IRepositories
{
    public interface IEntityRepository<E> where E : Entity
    {
        void Create(E entity);
    }
}