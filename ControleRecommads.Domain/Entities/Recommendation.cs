using ControleRecommads.Domain.Entities.Enums;
using ControleRecommads.Domain.Entities.ValueObject;
using Flunt.Validations;

namespace ControleRecommads.Domain.Entities;

public abstract class Recommendation : Entity
{
    protected Recommendation(Member member, DateTime recommendationDate)
    {
        Member = member;
        if (member.IsValid)
            State = ERecommendationState.valido;
        EntryDate = DateTime.Now;
        RecommendationDate = recommendationDate;
        ValidateDate = recommendationDate.AddDays(180);
        DevolutionDate = null;

        AddNotifications(new Contract<Recommendation>()
        .Requires()
        .IsGreaterThan(ValidateDate, EntryDate, "Data Invalida!"));

        Member.AddNotifications(Notifications);
    }

    public Member Member { get; private set; }
    public ERecommendationState State { get; private set; }
    public DateTime EntryDate { get; private set; }
    public DateTime RecommendationDate { get; private set; }
    public DateTime ValidateDate { get; private set; }
    public DateTime? DevolutionDate { get; private set; }

    public void UpdateStateDevolvido(DateTime date)
    {
        if (date >= RecommendationDate)
        {
            DevolutionDate = date;
            State = ERecommendationState.Devolvido;
        }

    }
    public void UpdateStateInvalido()
    {
        var days = ValidateDate.Subtract(DateTime.Now).TotalDays;
        if (days <= 0)
            State = ERecommendationState.Invalido;
    }
}
