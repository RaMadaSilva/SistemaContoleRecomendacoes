using ControleRecommads.Domain.Entities.ValueObject;

namespace ControleRecommads.Domain.Entities;

public class ReceivedRecommendation : Recommendation
{
    public ReceivedRecommendation(IList<Member> members, DateTime recommandationDate, Church origin)
        : base(members, recommandationDate, origin)
    {
        AttachmentRecommendationUrl = null;
    }
    public string? AttachmentRecommendationUrl { get; private set; }

}