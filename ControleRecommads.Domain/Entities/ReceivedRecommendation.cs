using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleRecommads.Domain.Entities.ValueObject;

namespace ControleRecommads.Domain.Entities;

public class ReceivedRecommendation : Recommendation
{
    public ReceivedRecommendation(Member member, DateTime receivedDate, Church origin) : base(member)
    {
        Origin = origin;
        ReceivedDate = receivedDate;
        AttachmentRecommendationUrl = null;
        SetValidateDate(ReceivedDate.AddDays(180));
    }

    public Church Origin { get; private set; }
    public string? AttachmentRecommendationUrl { get; private set; }
    public DateTime ReceivedDate { get; private set; }

}