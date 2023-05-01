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
        RecommendationDate = DateTime.Now;
        ValidateDate = RecommendationDate.AddDays(180);
        DestinyChurch = destinyChurch;
        DestinyLacality = destinyLacality;
        RecommendationGeneratedUrl = recommendationGeneratedUrl;
    }

    public DateTime RecommendationDate { get; private set; }
    public DateTime ValidateDate { get; private set; }
    public string DestinyChurch { get; private set; }
    public string DestinyLacality { get; private set; }
    public string RecommendationGeneratedUrl { get; private set; }

}
