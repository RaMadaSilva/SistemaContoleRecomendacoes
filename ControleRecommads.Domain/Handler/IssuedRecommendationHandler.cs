using ControleRecommads.Domain.Commands;
using ControleRecommads.Domain.Commands.Interfaces;
using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.ValueObject;
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
            var member = new Member(command.FirstName, command.LastName, command.PhoneNumber);
            var church = new Church(command.NameChurch, command.Localization);

            member.AddNotifications(Notifications);
            church.AddNotifications(Notifications);


            //1# verificar se o membro tem uma carta de recomendação solicitada valida
            var recommendation = _issuedRepo.GetRecommendationValid(member);
            if (recommendation != null)
                return new CommandResult(false, "O referido membro ainda tem uma carta de recomendação valida", recommendation);

            //2# Criar uma solicitação da carta de recomendação  solicitada
            var issueRecommendation = new IssuedRecommendation(member, church);

            //3# Salvar a Carta de recomendação solicitada
            if (!IsValid)
                return new CommandResult(false, "Membro, ou igreja Invalida", Notifications);
            _issuedRepo.Save(issueRecommendation);

            //4# Retornar a carta solicitada
            return new CommandResult(true, "Solicitação de Recomendação bem sucedido", issueRecommendation);
        }
    }
}