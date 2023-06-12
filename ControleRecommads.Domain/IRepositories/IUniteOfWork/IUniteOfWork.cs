using ControleRecommads.Domain.Entities;

namespace ControleRecommads.Domain.IRepositories.IUniteOfWork;

public interface IUniteOfWork
{
    IRepositoryBase<ReceivedRecommendation> ReceivedRecommendationRepository { get; }
    IRepositoryBase<IssuedRecommendation> IssuedRecommendationRepository { get; }
    IMemberRepository MemberRepository { get; }
    IChurchRepository ChurchRepository { get; }

    void Commit();
}
