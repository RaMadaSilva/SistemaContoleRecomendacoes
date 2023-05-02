using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleRecomendacoes.Domain.Entities.Enums;

namespace ControleRecomendacoes.Domain.Entities;

public abstract class Recommendation : Entity
{
    protected Recommendation(string firstName, string lastName, string telefoneNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        TelefoneNumber = telefoneNumber;

        State = ERecommendationState.valido;
        EntryDate = DateTime.Now;
        RecommendationDate = UpdateRecommendationDate();
        ValidateDate = RecommendationDate.AddDays(180);
        DevolutionDate = null;

        // TODO verificar se o validateDate é menor que a entryDate.

    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string TelefoneNumber { get; private set; }
    public ERecommendationState State { get; private set; }
    public DateTime EntryDate { get; private set; }
    public DateTime RecommendationDate { get; private set; }
    public DateTime ValidateDate { get; private set; }
    public DateTime? DevolutionDate { get; private set; }

    public abstract DateTime UpdateRecommendationDate();

}
