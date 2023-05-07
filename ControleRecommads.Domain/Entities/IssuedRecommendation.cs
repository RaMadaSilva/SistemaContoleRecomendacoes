using ControleRecommads.Domain.Entities.Enums;
using ControleRecommads.Domain.Entities.ValueObject;

namespace ControleRecommads.Domain.Entities;

public class IssuedRecommendation : Recommendation
{
    public IssuedRecommendation(Member member, Church destiny) : base(member)
    {
        Destiny = destiny;
        IssuedDate = DateTime.Now;
        RecommendationGeneratedUrl = null;
        SetValidateDate(IssuedDate.AddDays(180));
    }

    public Church Destiny { get; private set; }
    public DateTime IssuedDate { get; private set; }
    public string? RecommendationGeneratedUrl { get; private set; }

}
