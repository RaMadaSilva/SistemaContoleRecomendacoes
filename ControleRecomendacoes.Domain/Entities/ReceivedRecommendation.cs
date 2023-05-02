using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleRecomendacoes.Domain.Entities;

public class ReceivedRecommendation : Recommendation
{
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
        RecommendationDate = recommendationDate;
        ValidateDate = recommendationDate.AddDays(180);
        OriginChurche = originChurche;
        LocalChurcheOrigin = localChurcheOrigin;
        ActualResidence = actualResidence;
        AttachmentRecommendationUrl = attachmentRecommendationUrl;

        // TODO verificar se o validateDate é menor que a entryDate.
    }

    public DateTime RecommendationDate { get; private set; }
    public DateTime ValidateDate { get; private set; }
    public string OriginChurche { get; private set; }
    public string LocalChurcheOrigin { get; private set; }
    public string ActualResidence { get; private set; }
    public string AttachmentRecommendationUrl { get; private set; }

}