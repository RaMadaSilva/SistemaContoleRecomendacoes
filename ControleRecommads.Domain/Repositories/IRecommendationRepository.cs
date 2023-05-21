using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.Enums;
using ControleRecommads.Domain.Entities.ValueObject;

namespace ControleRecommads.Domain.Repositories
{
    public interface IRecommendationRepository<T> where T : Recommendation
    {
        IList<T> GetAllReceivedRecommendation();
        IList<T> GetAllReceivedRecommendationWithState(ERecommendationState state);
        T GetRecommendation(Guid id);
        T GetRecommendationValid(Member member);
        void Save(T recommendation);
        void UpdateRecommendation(T recommendation);
    }
}