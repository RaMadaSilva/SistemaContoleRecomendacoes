using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.Enums;
using ControleRecommads.Domain.Entities.ValueObject;

namespace ControleRecommads.Domain.Repositories
{
    public interface IRecommendationRepository<T> where T : Recommendation
    {
        IList<T> GetAllReceivedRecommendation();
        IList<T> GetAllReceivedRecommendationWithState(ERecommendationState state);
        T GetReceivedRecommendation(Guid id);
        bool RecommendationValid(Member membro, Church church);

        void Save(T recommendation);
    }
}