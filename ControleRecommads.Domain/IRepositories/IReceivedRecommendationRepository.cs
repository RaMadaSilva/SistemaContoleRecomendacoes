using ControleRecommads.Domain.Entities;

namespace ControleRecommads.Domain.IRepositories
{
    public interface IReceivedRecommendationRepository: IRepositoryBase<ReceivedRecommendation>
    {
        ReceivedRecommendation GetReceivedRecommendationValid(Member member); 
    }
}
