using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flunt.Validations;

namespace ControleRecommads.Domain.Entities.ValueObject
{
    public class Name : ValueObject
    {
        public Name(string nameComplete)
        {
            AddNotifications(new Contract<Name>()
            .Requires()
            .IsNotNull(nameComplete, "O nome é obrigatorio")
            .IsNotMinValue(3, nameComplete, "O Nome deve possuir no minimo 3 letras"));

            NameComplete = nameComplete;
        }

        public string NameComplete { get; set; }
    }
}