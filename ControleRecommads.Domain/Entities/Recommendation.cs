using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleRecommads.Domain.Entities.Enums;
using ControleRecommads.Domain.Entities.ValueObject;
using Flunt.Validations;

namespace ControleRecommads.Domain.Entities;

public abstract class Recommendation : Entity
{
    protected Recommendation(Member member)
    {
        Member = member;
        if (member.IsValid)
            State = ERecommendationState.valido;
        EntryDate = DateTime.Now;
        DevolutionDate = null;

        AddNotifications(new Contract<Recommendation>()
                        .Requires()
                        .IsGreaterOrEqualsThan(ValidateDate, EntryDate, "A data de validade está invalida"));
        Member.AddNotifications(Notifications);
    }

    public Member Member { get; private set; }
    public ERecommendationState State { get; private set; }
    public DateTime EntryDate { get; private set; }
    public DateTime ValidateDate { get; private set; }
    public DateTime? DevolutionDate { get; private set; }

    public void SetValidateDate(DateTime date)
    {
        ValidateDate = date;
    }
    public void UpdateStateDevolvido(DateTime date)
    {
        DevolutionDate = date;
        if (IsValid)
            State = ERecommendationState.Devolvido;
    }
    public void UpdateStateInvalido()
    {
        if (ValidateDate >= DateTime.Now)
            State = ERecommendationState.Invalido;
    }

}
