using ControleRecommads.Domain.Entities.Enums;
using ControleRecommads.Domain.Entities.ValueObject;
using Flunt.Validations;

namespace ControleRecommads.Domain.Entities;

public class IssuedRecommendation : Recommendation
{
    public IssuedRecommendation(Member member, Church destiny) : base(member, DateTime.Now)
    {
        Destiny = destiny;
        RecommendationGeneratedUrl = null;

    }

    public Church Destiny { get; private set; }
    public string? RecommendationGeneratedUrl { get; private set; }

}
