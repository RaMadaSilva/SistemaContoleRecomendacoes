using System;
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
    public class ReceivedRecommendationHandler : Notifiable<Notification>, IHandler<ReceiveCommand>, IHandler<RetornRecommendationCommand>
    {
        private readonly IUniteOfWork _uow;

        public ReceivedRecommendationHandler(IUniteOfWork uow)
        {
            _uow = uow;
        }

        public ICommandResult Handler(ReceiveCommand command)
        {

            //1# Verificar se  a ja existe uma carta de recomendação e é valida?
            var nameMember = new Name(command.NameMember);
            var adressMember = new Adress(command.CyteMember, command.ReferenceMember);
            var nameChurch = new Name(command.NameChurch);
            var adressChurch = new Adress(command.CyteChurch, command.ReferenceChurch);
            var member = new Member(nameMember, command.PhoneMember, adressMember);
            var church = new Church(nameChurch, adressChurch);


            nameMember.AddNotifications(Notifications);
            adressMember.AddNotifications(Notifications);
            nameChurch.AddNotifications(Notifications);
            adressChurch.AddNotifications(Notifications);
            member.AddNotifications(Notifications);
            church.AddNotifications(Notifications);

            var recommendation = _uow.ReceivedRecommendationRepository.GetReceivedRecommendationValid(member);

            if (recommendation != null)
                return new CommandResult
                {
                    Sucesses = false,
                    Mensage = "Este Membro já tem uma recomandação valida",
                    Data = recommendation
                };

            //2# Caso não exista  Criar a ReceivedRecommendation
            var received = new ReceivedRecommendation(member, command.DataReceive, church);

            received.AddNotifications(Notifications);

            //3# Salva no bsnco de dados
            if (!IsValid)
                return new CommandResult
                {
                    Sucesses = false,
                    Mensage = "Este Membro já tem uma recomandação valida",
                    Data = recommendation
                };

            _uow.ChurchRepository.Create(church);
            _uow.MemberRepository.Create(member);
            _uow.ReceivedRecommendationRepository.Create(received);
            _uow.Commit();

            //4# retornar o resultado 

            return new CommandResult
            {
                Sucesses = true,
                Mensage = "Recomendação salva com sucesso",
                Data = received
            };
        }

        public ICommandResult Handler(RetornRecommendationCommand command)
        {
            //pegar a carta do banco de dedos
            var recommendation = _uow.ReceivedRecommendationRepository.GetRecommendation(command.Id);

            if (recommendation == null || recommendation.State != ERecommendationState.valido)
            {
                AddNotification("IssuedRecommendation", "Recomendação Invalida ou inexistente");
                return new CommandResult
                {
                    Sucesses = false,
                    Mensage = "Não foi possivel actualizar a recomendação",
                    Data = Notifications
                };
            }

            //Caso Exista a recomendação e o seu estado seja valida
            recommendation.UpdateStateDevolvido(command.RetornDate);
            _uow.ReceivedRecommendationRepository.UpdateRecommendation(recommendation);
            _uow.Commit();

            return new CommandResult
            {
                Sucesses = true,
                Mensage = "Recomendação actualizada com sucesso",
                Data = recommendation
            };
        }
    }
}