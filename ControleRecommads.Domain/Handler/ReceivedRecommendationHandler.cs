using ControleRecommads.Domain.Commands;
using ControleRecommads.Domain.Commands.Interfaces;
using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.Enums;
using ControleRecommads.Domain.Entities.ValueObject;
using ControleRecommads.Domain.Handler.Interface;
using ControleRecommads.Domain.Repositories;
using Flunt.Notifications;

namespace ControleRecommads.Domain.Handler
{
    public class ReceivedRecommendationHandler : Notifiable<Notification>, IHandler<ReceiveCommand>, IHandler<RetornRecommendationCommand>
    {
        private readonly IRecommendationRepository<ReceivedRecommendation> _repostory;

        public ReceivedRecommendationHandler(IRecommendationRepository<ReceivedRecommendation> repostory)
        {
            _repostory = repostory;
        }

        public ICommandResult Handler(ReceiveCommand command)
        {

            //1# Verificar se  a ja existe uma carta de recomendação e é valida?
            var member = new Member(command.FirstName, command.LastName, command.PhoneNumber, command.CurrentAdress);
            var church = new Church(command.NameChurch, command.Localization);
            member.AddNotifications(Notifications);
            church.AddNotifications(Notifications);

            var recommendation = _repostory.GetRecommendationValid(member);

            if (recommendation != null)
                return new CommandResult(false, "Este Membro já tem uma recomandação valida", recommendation);

            //2# Caso não exista  Criar a ReceivedRecommendation
            var received = new ReceivedRecommendation(member, command.DataReceive, church);

            received.AddNotifications(Notifications);

            //3# Salva no bsnco de dados
            if (!IsValid)
                return new CommandResult(false, "Não foi possivel salvar a recomendação recebida", Notifications);
            _repostory.Save(received);

            //4# retornar o resultado 

            return new CommandResult(true, "Recomendação salva com sucesso", received);
        }

        public ICommandResult Handler(RetornRecommendationCommand command)
        {
            //pegar a carta do banco de dedos
            var recommendation = _repostory.GetRecommendation(command.Id);

            if (recommendation == null || recommendation.State != ERecommendationState.valido)
            {
                AddNotification("IssuedRecommendation", "Recomendação Invalida ou inexistente");
                return new CommandResult(false, "Não foi possivel actualizar a recomendação", Notifications);
            }

            //Caso Exista a recomendação e o seu estado seja valida
            recommendation.UpdateStateDevolvido(command.RetornDate);
            _repostory.UpdateRecommendation(recommendation);

            return new CommandResult(true, "Recomendação actualizada com sucesso", recommendation);
        }
    }
}