using ControleRecommads.Domain.Entities.Enums;
using ControleRecommads.Domain.Entities.ValueObject;

namespace ControleRecommads.Domain.Entities;

public class IssuedRecommendation : Recommendation
{
    public IssuedRecommendation(Member member, Church destiny) : base(member)
    {
        Destiny = destiny;
        RecommendationGeneratedUrl = null;
    }

    public Church Destiny { get; private set; }
    public string? RecommendationGeneratedUrl { get; private set; }
    public override DateTime UpdateRecommendationDate()
    {
        return DateTime.Now;
    }

}
