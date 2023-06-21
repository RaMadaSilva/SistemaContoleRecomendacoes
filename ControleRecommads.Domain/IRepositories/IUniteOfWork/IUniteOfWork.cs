using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.ValueObject;

namespace ControleRecommads.Domain.IRepositories.IUniteOfWork;

public interface IUniteOfWork
{
    IReceivedRecommendationRepository ReceivedRecommendationRepository { get; }
    IRepositoryBase<IssuedRecommendation> IssuedRecommendationRepository { get; }
    IEntityRepository<Member> MemberRepository { get; }
    IEntityRepository<Church> ChurchRepository { get; }

    void Commit();
}
