using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleRecomendacoes.Domain.Entities.Enums;
using Flunt.Validations;

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

        AddNotifications(new Contract<Recommendation>()
                        .Requires()
                        .IsGreaterThan(RecommendationDate, EntryDate, "A Data da recomendação não deve ser posterior a data actual")
                        .IsGreaterOrEqualsThan(EntryDate, ValidateDate, "A data de validade está invalida")
                        .IsNotNull(FirstName, "O nome é obrigatorio")
                        .IsNotNull(LastName, "O Sobre Nome é Obrigatorio")
                        .IsNotNull(TelefoneNumber, "O Numero do Telefone é Obrigatio"));
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

    public void GetDevolutionDate(DateTime date)
    {
        DevolutionDate = date;
    }

}
