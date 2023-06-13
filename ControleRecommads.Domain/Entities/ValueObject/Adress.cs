using Flunt.Validations;

namespace ControleRecommads.Domain.Entities.ValueObject
{
    public class Adress : ValueObject
    {
        public Adress(string city, string reference)
        {
            AddNotifications(new Contract<Adress>()
                .Requires()
                .IsNotNull(city, "O nome é obrigatorio")
                .IsNotMinValue(3, city, "O Nome deve possuir no minimo 3 letras")
                .IsNotNull(reference, "O nome é obrigatorio")
                .IsNotMinValue(3, reference, "O Nome deve possuir no minimo 3 letras"));

            City = city;
            Reference = reference;
        }

        public string City { get; set; }
        public string Reference { get; set; }
    }
}