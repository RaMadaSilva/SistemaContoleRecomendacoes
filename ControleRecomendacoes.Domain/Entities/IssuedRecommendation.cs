using ControleRecomendacoes.Domain.Entities.Enums;
using ControleRecomendacoes.Domain.Entities.ValueObject;

namespace ControleRecomendacoes.Domain.Entities;

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
