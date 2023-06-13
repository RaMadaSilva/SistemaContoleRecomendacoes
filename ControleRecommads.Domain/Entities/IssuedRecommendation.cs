using ControleRecommads.Domain.Entities.ValueObject;

namespace ControleRecommads.Domain.Entities;

public class IssuedRecommendation : Recommendation
{
    public IssuedRecommendation(IList<Member> members, Church destiny) : base(members, DateTime.Now, destiny)
    {

        RecommendationGeneratedUrl = null;
    }
    public string? RecommendationGeneratedUrl { get; private set; }

}
