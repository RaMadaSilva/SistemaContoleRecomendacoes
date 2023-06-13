using ControleRecommads.Domain.Entities.Enums;
using ControleRecommads.Domain.Entities.ValueObject;
using Flunt.Validations;

namespace ControleRecommads.Domain.Entities;

public abstract class Recommendation : Entity
{
    protected Recommendation(IList<Member> members, DateTime recommendationDate, Church church)
    {
        Members = members;
        if (members.Count > 0)
            State = ERecommendationState.valido;
        EntryDate = DateTime.Now;
        RecommendationDate = recommendationDate;
        ValidateDate = recommendationDate.AddDays(180);
        Church = church;
        DevolutionDate = null;

        AddNotifications(new Contract<Recommendation>()
        .Requires()
        .IsGreaterThan(ValidateDate, EntryDate, "Data Invalida!"));

        Church.AddNotifications(Notifications);

    }

    public IList<Member> Members { get; private set; }
    public ERecommendationState State { get; private set; }
    public DateTime EntryDate { get; private set; }
    public DateTime RecommendationDate { get; private set; }
    public DateTime ValidateDate { get; private set; }
    public DateTime? DevolutionDate { get; private set; }
    public Church Church { get; private set; }

    public void UpdateStateDevolvido(DateTime date)
    {
        if (date >= RecommendationDate)
        {
            DevolutionDate = date;
            State = ERecommendationState.Devolvido;
        }

    }

    public double CountDaysMiss()
        => ValidateDate.Subtract(DateTime.Now).TotalDays;

    public void UpdateStateInvalido()
    {
        if (CountDaysMiss() <= 0)
            State = ERecommendationState.Invalido;
    }
}
