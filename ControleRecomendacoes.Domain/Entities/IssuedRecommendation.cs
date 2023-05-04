using ControleRecomendacoes.Domain.Entities.Enums;
using ControleRecomendacoes.Domain.Entities.ValueObject;

namespace ControleRecomendacoes.Domain.Entities;

public class IssuedRecommendation : Recommendation
{
    public IssuedRecommendation(Member member,
            string destinyChurch,
            string destinyLacality) : base(member)
    {
        DestinyChurch = destinyChurch;
        DestinyLacality = destinyLacality;
        RecommendationGeneratedUrl = null;

    }

    public string DestinyChurch { get; private set; }
    public string DestinyLacality { get; private set; }
    public string? RecommendationGeneratedUrl { get; private set; }
    public override DateTime UpdateRecommendationDate()
    {
        return DateTime.Now;
    }

}
