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
        public Member(string firstName, string lastName, uint telefoneNumber, string? residence = null)
        {
            AddNotifications(new Contract<Member>()
                        .Requires()
                        .IsNotNull(firstName, "O nome é obrigatorio")
                        .IsNotMinValue(3, firstName, "O Nome deve possuir no minimo 3 letras")
                        .IsNotNull(lastName, "O Sobre Nome é Obrigatorio")
                        .IsNotMinValue(3, lastName, "O Sobre Nome deve possuir no minimo 3 letras")
                        .IsNotNull(telefoneNumber, "O Numero do Telefone é Obrigatio"));

            FirstName = firstName;
            LastName = lastName;
            TelefoneNumber = telefoneNumber;
            Residence = residence;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public uint TelefoneNumber { get; private set; }
        public string? Residence { get; private set; }

        public override bool Equals(Object? obj)
        {

            return obj is Member member &&
                FirstName == member.FirstName &&
                LastName == member.LastName &&
                TelefoneNumber == member.TelefoneNumber &&
                Residence == member.Residence;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName);
        }
    }
}
