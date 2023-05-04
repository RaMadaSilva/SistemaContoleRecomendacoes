using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleRecomendacoes.Domain.Entities.ValueObject
{
    public class Church : ValueObject
    {
        public Church(string name, string localization)
        {
            Name = name;
            Localization = localization;
        }

        public string Name { get; private set; }
        public string Localization { get; private set; }

    }
}