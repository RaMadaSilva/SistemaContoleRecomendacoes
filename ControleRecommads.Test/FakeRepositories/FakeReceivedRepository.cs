using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.Enums;
using ControleRecommads.Domain.Entities.ValueObject;
using ControleRecommads.Domain.Repositories;

namespace ControleRecommads.Test.FakeRepositories
{
    public class FakeReceivedRepository : IRecommendationRepository<ReceivedRecommendation>
    {
        private List<ReceivedRecommendation> receivedRecommendations = new()
        {
            new ReceivedRecommendation(new("Nelma",  "Kiffen", 111111111, "Maianga"), new DateTime(2023, 05, 19), new("Maianga", "Maianga")),
            new ReceivedRecommendation(new("Walter",  "Msamo", 222222222, "Maculusso"), new DateTime(2022, 05, 19), new("Central", "Maculusso")),
            new ReceivedRecommendation(new("Paulo",  "Pimenta", 333333333, "Rainha Jinga"), new DateTime(2021, 05, 19), new("Ilha", "Ilha")),
            new ReceivedRecommendation(new("Daniela",  "Flor", 444444444, "Bairro Popular"), new DateTime(2023, 05, 19), new("Popula", "Popula")),
            new ReceivedRecommendation(new("Henrique",  "Sebastião", 555555555, "Zango"), new DateTime(2023, 05, 19), new("Zango", "Zango")),
            new ReceivedRecommendation(new("Feliciana",  "João", 666666666, "Prenda"), new DateTime(2023, 05, 19), new("Prenda", "Prenda")),
            new ReceivedRecommendation(new("Helena",  "João", 777777777, "Cazenga"), new DateTime(1995, 05, 19), new("Central do Cazenga", "Cazenga")),

        };
        public IList<ReceivedRecommendation> GetAllReceivedRecommendation()
            => receivedRecommendations;

        public IList<ReceivedRecommendation> GetAllReceivedRecommendationWithState(ERecommendationState state)
            => receivedRecommendations.Where(x => x.State == state).ToList();

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
            //TODO
        }
    }
}