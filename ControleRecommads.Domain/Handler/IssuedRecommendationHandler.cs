using ControleRecommads.Domain.Commands;
using ControleRecommads.Domain.Commands.Interfaces;
using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.Enums;
using ControleRecommads.Domain.Entities.ValueObject;
using ControleRecommads.Domain.Handler.Interface;
using ControleRecommads.Domain.IRepositories.IUniteOfWork;
using Flunt.Notifications;

namespace ControleRecommads.Domain.Handler
{
    public class IssuedRecommendationHandler : Notifiable<Notification>,
        IHandler<IssueCommand>,
        IHandler<RetornRecommendationCommand>
    {
        private readonly IUniteOfWork _uow;

        public IssuedRecommendationHandler(IUniteOfWork uow)
        {
            _uow = uow;
        }

        public ICommandResult Handler(IssueCommand command)
        {
            var member = new Member(command.FirstName, command.LastName, command.PhoneNumber);
            var church = new Church(command.NameChurch, command.Localization);

            member.AddNotifications(Notifications);
            church.AddNotifications(Notifications);

            //1# verificar se o membro tem uma carta de recomendação solicitada valida
            var recommendation = _uow.IssuedRecommendationRepository.GetRecommendationValid(member);
            if (recommendation != null)
                return new CommandResult(false, "O referido membro ainda tem uma carta de recomendação valida", recommendation);

            //2# Criar uma solicitação da carta de recomendação  solicitada
            var issueRecommendation = new IssuedRecommendation(member, church);

            //3# Salvar a Carta de recomendação solicitada
            if (!IsValid)
                return new CommandResult(false, "Membro, ou igreja Invalida", Notifications);
            _uow.ChurchRepository.Add(church);
            _uow.MemberRepository.Add(member);
            _uow.IssuedRecommendationRepository.Create(issueRecommendation);
            _uow.Commit();

            //4# Retornar a carta solicitada
            return new CommandResult(true, "Solicitação de Recomendação bem sucedido", issueRecommendation);
        }

        public ICommandResult Handler(RetornRecommendationCommand command)
        {
            //pegar a carta do banco de dedos
            var recommendation = _uow.IssuedRecommendationRepository.GetRecommendation(command.Id);

            if (recommendation == null || recommendation.State != ERecommendationState.valido)
            {
                AddNotification("IssuedRecommendation", "Recomendação Invalida ou inexistente");
                return new CommandResult(false, "Não foi possivel actualizar a recomendação", Notifications);
            }

            //Caso Exista a recomendação e o seu estado seja valida
            recommendation.UpdateStateDevolvido(command.RetornDate);
            _uow.IssuedRecommendationRepository.UpdateRecommendation(recommendation);
            _uow.Commit();

            return new CommandResult(true, "Recomendação actualizada com sucesso", recommendation);
        }
    }
}