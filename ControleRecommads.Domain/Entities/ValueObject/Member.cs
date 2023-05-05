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
        public Member(string firstName, string lastName, string telefoneNumber, string? residence = null)
        {
            AddNotifications(new Contract<Recommendation>()
                        .Requires()
                        .IsNotNull(firstName, "O nome é obrigatorio")
                        .IsMinValue(3, firstName, "O Nome deve possuir no minio 3 letras")
                        .IsNotNull(lastName, "O Sobre Nome é Obrigatorio")
                        .IsMinValue(3, lastName, "O Sobre Nome deve possuir no minio 3 letras")
                        .IsNotNull(telefoneNumber, "O Numero do Telefone é Obrigatio"));

            FirstName = firstName;
            LastName = lastName;
            TelefoneNumber = telefoneNumber;
            Residence = residence;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string TelefoneNumber { get; private set; }
        public string? Residence { get; private set; }
    }
}
