using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleRecomendacoes.Domain.Entities.Enums;
using ControleRecomendacoes.Domain.Entities.ValueObject;
using Flunt.Validations;

namespace ControleRecomendacoes.Domain.Entities;

public abstract class Recommendation : Entity
{
    protected Recommendation(Member member)
    {
        Member = member;
        State = ERecommendationState.valido;
        EntryDate = DateTime.Now;
        RecommendationDate = UpdateRecommendationDate();
        ValidateDate = RecommendationDate.AddDays(180);
        DevolutionDate = null;

        AddNotifications(new Contract<Recommendation>()
                        .Requires()
                        .IsGreaterThan(RecommendationDate, EntryDate, "A Data da recomendação não deve ser posterior a data actual")
                        .IsGreaterOrEqualsThan(EntryDate, ValidateDate, "A data de validade está invalida"));
        Member.AddNotifications(Notifications);
    }

    public Member Member { get; private set; }
    public ERecommendationState State { get; private set; }
    public DateTime EntryDate { get; private set; }
    public DateTime RecommendationDate { get; private set; }
    public DateTime ValidateDate { get; private set; }
    public DateTime? DevolutionDate { get; private set; }

    public abstract DateTime UpdateRecommendationDate();

    public void GetDevolutionDate(DateTime date)
    {
        DevolutionDate = date;
    }

    public void UpdateStateDevolvido()
    {
        if (DevolutionDate != null)
            State = ERecommendationState.Devolvido;
    }
    public void UpdateStateInvalido()
    {
        if (ValidateDate >= DateTime.Now)
            State = ERecommendationState.Invalido;
    }

}
