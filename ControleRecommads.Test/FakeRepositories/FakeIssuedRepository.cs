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
    public class FakeIssuedRepository : IRecommendationRepository<IssuedRecommendation>
    {
        public IList<IssuedRecommendation> GetAllReceivedRecommendation()
        {
            throw new NotImplementedException();
        }

        public IList<IssuedRecommendation> GetAllReceivedRecommendationWithState(ERecommendationState state)
        {
            throw new NotImplementedException();
        }

        public IssuedRecommendation GetRecommendation(Guid id)
        {
            throw new NotImplementedException();
        }

        public IssuedRecommendation GetRecommendation(Member member, Church church)
        {
            throw new NotImplementedException();
        }

        public void Save(IssuedRecommendation recommendation)
        {
            throw new NotImplementedException();
        }
    }
}