using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.ValueObject;
using ControleRecommads.Domain.IRepositories;
using ControleRecommads.Domain.IRepositories.IUniteOfWork;

namespace ControleRecommads.Test.FakeRepositories
{

    public class FakeUniteOfWork : IUniteOfWork
    {
        public IRepositoryBase<ReceivedRecommendation> ReceivedRecommendationRepository => throw new NotImplementedException();

        public IRepositoryBase<IssuedRecommendation> IssuedRecommendationRepository => throw new NotImplementedException();

        public IEntityRepository<Member> MemberRepository => throw new NotImplementedException();

        public IEntityRepository<Church> ChurchRepository => throw new NotImplementedException();

        IReceivedRecommendationRepository IUniteOfWork.ReceivedRecommendationRepository => throw new NotImplementedException();

        public void Commit()
        {
            throw new NotImplementedException();
        }
    }
}