using System.ComponentModel;
using ControleRecommads.Domain.Entities.ValueObject;

namespace ControleRecommads.Domain.Entities;

public sealed class IssuedRecommendation : Recommendation
{

    private IssuedRecommendation()
        : base(null, DateTime.Now, null)
    {
    }

    public IssuedRecommendation(Member member, Church destiny) : base(member, DateTime.Now, destiny)
    {
        RecommendationGeneratedUrl = null;
    }
    public string? RecommendationGeneratedUrl { get; private set; }

}
