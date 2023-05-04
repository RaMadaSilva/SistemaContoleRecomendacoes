using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleRecomendacoes.Domain.Entities.ValueObject;

namespace ControleRecomendacoes.Domain.Entities;

public class ReceivedRecommendation : Recommendation
{
    private readonly DateTime _recomandationDate;
    public ReceivedRecommendation(Member member,
                DateTime recommendationDate,
                string originChurche,
                string localChurcheOrigin,
                string actualResidence) : base(member)
    {
        OriginChurche = originChurche;
        LocalChurcheOrigin = localChurcheOrigin;
        ActualResidence = actualResidence;
        AttachmentRecommendationUrl = null;
        _recomandationDate = recommendationDate;

    }

    public string OriginChurche { get; private set; }
    public string LocalChurcheOrigin { get; private set; }
    public string ActualResidence { get; private set; }
    public string? AttachmentRecommendationUrl { get; private set; }

    public override DateTime UpdateRecommendationDate()
    {
        return _recomandationDate;
    }

}