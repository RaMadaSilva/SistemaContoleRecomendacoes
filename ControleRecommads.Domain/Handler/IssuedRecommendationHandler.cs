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

            //1# verificar se o membro tem uma carta de recomendação solicitada valida

            //2# Criar uma solicitação da carta de recomendação  solicitada

            //3# Salvar a Carta de recomendação solicitada

            //4# Retornar a carta solicitada
        }
    }
}