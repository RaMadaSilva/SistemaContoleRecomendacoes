using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flunt.Validations;

namespace ControleRecommads.Domain.Entities.ValueObject
{
    public class Church : ValueObject
    {
        public Church(string name, string localization)
        {
            AddNotifications(new Contract<Church>()
                    .Requires()
                    .IsMinValue(3, name, "O valor minino de letras deve ser 3")
                    .IsMinValue(3, localization, "O valor minimo de letras deve ser 3"));

            Name = name;
            Localization = localization;
        }

        public string Name { get; private set; }
        public string Localization { get; private set; }

    }
}