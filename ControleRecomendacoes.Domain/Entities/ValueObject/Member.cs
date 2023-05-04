using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flunt.Validations;

namespace ControleRecommads.Domain.Entities.ValueObject
{
    public class Member : ValueObject
    {
        public Member(string firstName, string lastName, string telefoneNumber)
        {
            AddNotifications(new Contract<Recommendation>()
                        .Requires()
                        .IsNotNull(firstName, "O nome é obrigatorio")
                        .IsNotNull(lastName, "O Sobre Nome é Obrigatorio")
                        .IsNotNull(telefoneNumber, "O Numero do Telefone é Obrigatio"));

            FirstName = firstName;
            LastName = lastName;
            TelefoneNumber = telefoneNumber;

        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string TelefoneNumber { get; private set; }
    }
}
