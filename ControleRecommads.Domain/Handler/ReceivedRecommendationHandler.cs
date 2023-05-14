using ControleRecommads.Domain.Commands;
using ControleRecommads.Domain.Commands.Interfaces;
using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Handler.Interface;
using ControleRecommads.Domain.Repositories;
using Flunt.Notifications;

namespace ControleRecommads.Domain.Handler
{
    public class ReceivedRecommendationHandler : Notifiable<Notification>, IHandler<ReceiveCommand>
    {
        private readonly IRecommendationRepository<ReceivedRecommendation> _repostory;

        public ReceivedRecommendationHandler(IRecommendationRepository<ReceivedRecommendation> repostory)
        {
            _repostory = repostory;
        }

        public ICommandResult Handler(ReceiveCommand command)
        {
            throw new NotImplementedException();

            //1# Verificar se  a ja existe uma carta de recomendação e é valida?

            //2# Caso não exista  Criar a ReceivedRecommendation

            //3# Salva no bsnco de dados

            //4# retornar o resultado 
        }
    }
}