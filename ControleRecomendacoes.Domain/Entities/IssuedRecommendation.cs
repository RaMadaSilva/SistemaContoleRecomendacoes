using ControleRecomendacoes.Domain.Entities.Enums;

namespace ControleRecomendacoes.Domain.Entities;

public class IssuedRecommendation : Recommendation
{
    public IssuedRecommendation(string firstName,
            string lastName,
            string telefoneNumber,
            string destinyChurch,
            string destinyLacality,
            string recommendationGeneratedUrl)
                : base(firstName, lastName, telefoneNumber)
    {
        DestinyChurch = destinyChurch;
        DestinyLacality = destinyLacality;
        RecommendationGeneratedUrl = recommendationGeneratedUrl;
    }

    public string DestinyChurch { get; private set; }
    public string DestinyLacality { get; private set; }
    public string RecommendationGeneratedUrl { get; private set; }

    public override DateTime UpdateRecommendationDate()
    {
        return DateTime.Now;
    }

}