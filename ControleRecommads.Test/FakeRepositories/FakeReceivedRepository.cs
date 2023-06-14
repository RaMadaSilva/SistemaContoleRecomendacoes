using System.Linq.Expressions;
using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.Enums;
using ControleRecommads.Domain.Entities.ValueObject;
using ControleRecommads.Domain.IRepositories;

namespace ControleRecommads.Test.FakeRepositories
{
    public class FakeReceivedRepository : IRepositoryBase<ReceivedRecommendation>
    {
        private List<ReceivedRecommendation> receivedRecommendations = new();
        public void Create(ReceivedRecommendation recommendation)
        {
            throw new NotImplementedException();
        }

        public IList<ReceivedRecommendation> GetAllReceivedRecommendation()
            => receivedRecommendations;

        public IList<ReceivedRecommendation> GetAllReceivedRecommendationWithState(ERecommendationState state)
            => receivedRecommendations.Where(x => x.State == state).ToList();

        public IEnumerable<ReceivedRecommendation> GetAllRecommendation()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReceivedRecommendation> GetAllRecommendationWithState(Expression<Func<ReceivedRecommendation, bool>> predicate)
        {
            return receivedRecommendations
                .Where(x => x.State.Equals(predicate)).ToList();
        }

        public ReceivedRecommendation GetRecommendation(Guid id)
            => receivedRecommendations.Where(x => x.Id == id).FirstOrDefault();
        public ReceivedRecommendation GetRecommendationValid(Member member)
        {
            var receivedRecommendation = receivedRecommendations
                    .Where(x => x.State == ERecommendationState.valido)
                    .ToList()
                    .Find(x => x.Member == member);
            if (receivedRecommendation != null)
                return receivedRecommendation;
            return null;
        }
        public void Save(ReceivedRecommendation recommendation)
            => receivedRecommendations.Add(recommendation);

        public void UpdateRecommendation(ReceivedRecommendation recommendation)
        {
            var received = receivedRecommendations.Where(x => x.Member == recommendation.Member).FirstOrDefault();

            if (received != null && received.State == ERecommendationState.valido)
            {
                receivedRecommendations.Remove(received);
                receivedRecommendations.Add(recommendation);
            }
        }
    }
}