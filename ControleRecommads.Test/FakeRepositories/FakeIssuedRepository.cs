using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.Enums;
using ControleRecommads.Domain.Entities.ValueObject;
using ControleRecommads.Domain.Repositories;

namespace ControleRecommads.Test.FakeRepositories
{
    public class FakeIssuedRepository : IRecommendationRepository<IssuedRecommendation>
    {
        private List<IssuedRecommendation> issuedRecommendations = new List<IssuedRecommendation>(){
            new IssuedRecommendation(new("Raul", "Mateia", 9999999), new("Monte das Oliveira", "Maianga")),
            new IssuedRecommendation(new("Joana", "Jandira", 888888), new("Morro dos Veados", "Benfica")),
            new IssuedRecommendation(new("Antonio", "Pedro", 7777777), new("bereia ", "Maianga")),
            new IssuedRecommendation(new("Raul", "Mateia", 6666666), new("Monte das Oliveira", "Maianga")),
        };

        public IList<IssuedRecommendation> GetAllReceivedRecommendation()
            => issuedRecommendations;

        public IList<IssuedRecommendation> GetAllReceivedRecommendationWithState(ERecommendationState state)
            => issuedRecommendations.Where(x => x.State == state).ToList();

        public IssuedRecommendation GetRecommendation(Guid id)
        {
            var reuslt = issuedRecommendations.Where(x => x.Id == id).FirstOrDefault();
            return reuslt;
        }

        public IssuedRecommendation GetRecommendationValid(Member member)
        {

            var recommendationsValid = issuedRecommendations
                                        .Where(x => x.State == ERecommendationState.valido)
                                        .ToList();
            IssuedRecommendation memberRecommendation = null;

            foreach (var item in recommendationsValid)
            {
                if (item.Member == member)
                {
                    memberRecommendation = item;
                    break;
                }
                memberRecommendation = null;
            }
            var recommendationValid = recommendationsValid.Find(x => x.Member == member);

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