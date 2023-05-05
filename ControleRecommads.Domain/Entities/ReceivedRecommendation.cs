using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleRecommads.Domain.Entities.ValueObject;

namespace ControleRecommads.Domain.Entities;

public class ReceivedRecommendation : Recommendation
{
    private readonly DateTime _recomandationDate;
    public ReceivedRecommendation(Member member, DateTime recommendationDate, Church origin) : base(member)
    {
        Origin = origin;
        AttachmentRecommendationUrl = null;
        _recomandationDate = recommendationDate;

    }

    public Church Origin { get; private set; }
    public string? AttachmentRecommendationUrl { get; private set; }

    public override DateTime UpdateRecommendationDate()
    {
        return _recomandationDate;
    }

}