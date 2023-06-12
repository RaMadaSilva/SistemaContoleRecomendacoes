using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.ValueObject;

namespace ControleRecommads.Domain.IRepositories.IUniteOfWork;

public interface IUniteOfWork
{
    IRepositoryBase<ReceivedRecommendation> ReceivedRecommendationRepository { get; }
    IRepositoryBase<IssuedRecommendation> IssuedRecommendationRepository { get; }
    IValueObjectRepository<Member> MemberRepository { get; }
    IValueObjectRepository<Church> ChurchRepository { get; }

    void Commit();
}
