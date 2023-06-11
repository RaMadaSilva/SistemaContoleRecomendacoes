using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.Enums;
using ControleRecommads.Domain.Entities.ValueObject;

namespace ControleRecommads.Domain.IRepositories
{
    public interface IRepositoryBase<T> where T : Recommendation
    {
        IEnumerable<T> GetAllRecommendation();
        IEnumerable<T> GetAllRecommendationWithState(ERecommendationState state);
        T GetRecommendation(Guid id);
        T GetRecommendationValid(Member member);
        void Create(T recommendation);
        void UpdateRecommendation(T recommendation);
    }
}