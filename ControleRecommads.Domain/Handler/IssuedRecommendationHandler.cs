using ControleRecommads.Domain.Commands;
using ControleRecommads.Domain.Commands.Interfaces;
using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Handler.Interface;
using ControleRecommads.Domain.Repositories;
using Flunt.Notifications;

namespace ControleRecommads.Domain.Handler
{

    public class IssuedRecommendationHandler : Notifiable<Notification>, IHandler<IssueCommand>
    {
        private readonly IRecommendationRepository<IssuedRecommendation> _issuedRepo;

        public IssuedRecommendationHandler(IRecommendationRepository<IssuedRecommendation> issuedRepo)
            => _issuedRepo = issuedRepo;


        public ICommandResult Handler(IssueCommand command)
        {
            throw new NotImplementedException();
        }
    }
}