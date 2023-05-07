using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleRecommads.Domain.Entities.ValueObject;

namespace ControleRecommads.Domain.Entities;

public class ReceivedRecommendation : Recommendation
{
    public ReceivedRecommendation(Member member, DateTime recommandationDate, Church origin)
        : base(member, recommandationDate)
    {
        Origin = origin;
        AttachmentRecommendationUrl = null;
    }

    public Church Origin { get; private set; }
    public string? AttachmentRecommendationUrl { get; private set; }

}