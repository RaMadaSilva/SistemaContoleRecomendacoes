using System.Linq.Expressions;
using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.Enums;
using ControleRecommads.Domain.Entities.ValueObject;
using ControleRecommads.Domain.IRepositories;


namespace ControleRecommads.Test.FakeRepositories
{
    public class FakeIssuedRepository : IRepositoryBase<IssuedRecommendation>
    {
        private List<IssuedRecommendation> issuedRecommendations = new(){
        };

        public void Create(IssuedRecommendation recommendation)
        {
            throw new NotImplementedException();
        }

        public IList<IssuedRecommendation> GetAllReceivedRecommendationWithState(ERecommendationState state)
            => issuedRecommendations.Where(x => x.State == state).ToList();

        public IEnumerable<IssuedRecommendation> GetAllRecommendation()
            => issuedRecommendations;

        public IEnumerable<IssuedRecommendation> GetAllRecommendationWithState(Expression<Func<IssuedRecommendation, bool>> predicate)
        {
            return issuedRecommendations.Where(x => x.State.Equals(predicate)).ToList();
        }

        public IssuedRecommendation GetRecommendation(Guid id)
        {
            var reuslt = issuedRecommendations.Where(x => x.Id == id).FirstOrDefault();
            return reuslt;
        }

        public IssuedRecommendation GetRecommendationValid(Member member)
        {

            var recommendationValid = issuedRecommendations
                                        .Where(x => x.State == ERecommendationState.valido)
                                        .ToList()
                                        .Find(x => x.Member.Equals(member));

            if (recommendationValid != null)
                return recommendationValid;
            return null;
        }

        public void Save(IssuedRecommendation recommendation)
            => issuedRecommendations.Add(recommendation);

        public void UpdateRecommendation(IssuedRecommendation recommendation)
        {
            var received = issuedRecommendations.Where(x => x.Member == recommendation.Member).FirstOrDefault();

            if (received != null && received.State == ERecommendationState.valido)
            {
                issuedRecommendations.Remove(received);
                issuedRecommendations.Add(recommendation);
            }
        }
    }
}