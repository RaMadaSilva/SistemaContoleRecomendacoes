using ControleRecommads.Domain.Entities.ValueObject;

namespace ControleRecommads.Domain.IRepositories
{
    public interface IValueObjectRepository<V> where V : ValueObject
    {
        void Add(V valueObject);
    }
}