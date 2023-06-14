using ControleRecommads.Domain.Entities.ValueObject;

namespace ControleRecommads.Domain.Entities;

public sealed class ReceivedRecommendation : Recommendation
{
    public ReceivedRecommendation(Member member, DateTime recommandationDate, Church origin)
        : base(member, recommandationDate, origin)
    {
        AttachmentRecommendationUrl = null;
    }
    public string? AttachmentRecommendationUrl { get; private set; }
}