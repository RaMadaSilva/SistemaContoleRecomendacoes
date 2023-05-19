using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.Enums;
using ControleRecommads.Domain.Entities.ValueObject;
using ControleRecommads.Domain.Repositories;

namespace ControleRecommads.Test.FakeRepositories
{
    public class FakeReceivedRepository : IRecommendationRepository<ReceivedRecommendation>
    {
        List<ReceivedRecommendation> receivedRecommendations = new()
        {
            new ReceivedRecommendation(new("Nelma",  "Kiffen", 111111111, "Maianga"), new DateTime(2023, 05, 19), new("Maianga", "Maianga")),
            new ReceivedRecommendation(new("Walter",  "Msamo", 222222222, "Maculusso"), new DateTime(2023, 05, 19), new("Central", "Maculusso")),
            new ReceivedRecommendation(new("Paulo",  "Pimenta", 333333333, "Rainha Jinga"), new DateTime(2023, 05, 19), new("Ilha", "Ilha")),
            new ReceivedRecommendation(new("Daniela",  "Flor", 444444444, "Bairro Popular"), new DateTime(2023, 05, 19), new("Popula", "Popula")),
            new ReceivedRecommendation(new("Henrique",  "Sebastião", 555555555, "Zango"), new DateTime(2023, 05, 19), new("Zango", "Zango")),
            new ReceivedRecommendation(new("Feliciana",  "João", 666666666, "Prenda"), new DateTime(2023, 05, 19), new("Prenda", "Prenda")),
            new ReceivedRecommendation(new("Helena",  "João", 777777777, "Cazenga"), new DateTime(2023, 05, 19), new("Central do Cazenga", "Cazenga")),

        };
        public IList<ReceivedRecommendation> GetAllReceivedRecommendation()
        {
            throw new NotImplementedException();
        }

        public IList<ReceivedRecommendation> GetAllReceivedRecommendationWithState(ERecommendationState state)
        {
            throw new NotImplementedException();
        }

        public ReceivedRecommendation GetRecommendation(Guid id)
        {
            throw new NotImplementedException();
        }

        public ReceivedRecommendation GetRecommendationValid(Member member)
        {
            throw new NotImplementedException();
        }

        public void Save(ReceivedRecommendation recommendation)
        {
            throw new NotImplementedException();
        }
    }
}