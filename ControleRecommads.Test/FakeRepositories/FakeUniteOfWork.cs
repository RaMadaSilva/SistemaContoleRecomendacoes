using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.IRepositories;
using ControleRecommads.Domain.IRepositories.IUniteOfWork;

namespace ControleRecommads.Test.FakeRepositories
{
    public class FakeUniteOfWork : IUniteOfWork
    {
        public IRepositoryBase<ReceivedRecommendation> ReceivedRecommendationRepository => throw new NotImplementedException();

        public IRepositoryBase<IssuedRecommendation> IssuedRecommendationRepository => throw new NotImplementedException();

        public void Commit()
        {
            throw new NotImplementedException();
        }
    }
}