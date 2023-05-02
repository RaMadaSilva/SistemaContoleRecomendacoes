using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleRecomendacoes.Domain.Entities;

public class ReceivedRecommendation : Recommendation
{
    private readonly DateTime _recomandationDate;
    public ReceivedRecommendation(string firstName,
                string lastName,
                string telefoneNumber,
                DateTime recommendationDate,
                string originChurche,
                string localChurcheOrigin,
                string actualResidence,
                string attachmentRecommendationUrl)
                : base(firstName, lastName, telefoneNumber)
    {
        OriginChurche = originChurche;
        LocalChurcheOrigin = localChurcheOrigin;
        ActualResidence = actualResidence;
        AttachmentRecommendationUrl = attachmentRecommendationUrl;
        _recomandationDate = recommendationDate;
    }

    public string OriginChurche { get; private set; }
    public string LocalChurcheOrigin { get; private set; }
    public string ActualResidence { get; private set; }
    public string AttachmentRecommendationUrl { get; private set; }

    public override DateTime UpdateRecommendationDate()
    {
        return _recomandationDate;
    }

}