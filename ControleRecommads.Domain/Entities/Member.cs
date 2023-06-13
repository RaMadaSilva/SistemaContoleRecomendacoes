using Flunt.Validations;

namespace ControleRecommads.Domain.Entities.ValueObject
{
    public class Member : Entity
    {
        public Member(Name name, uint phone, Adress adress)
        {
            AddNotifications(new Contract<Name>()
                    .Requires()
                    .IsNotNull(phone, "O numero de telefone é obrigatorio"));
            name.AddNotifications(Notifications);
        
            Name = name;
            Phone = phone;
            Adress = adress;
        }

        public Name Name { get; private set; }
        public uint Phone { get; private set; }
        public Adress Adress { get; private set; }
        public IList<Recommendation> Recommendations { get; private set; }

        public void AddRecommendations(Recommendation recommendation)
            => Recommendations.Add(recommendation);

        public override bool Equals(Object? obj)
        {
            if (obj == null)
                return false;
            Member? member = obj as Member;
            if (member == null)
                return false;
            if (base.Equals(obj))
                return true;
            return Name == member.Name &&
                Phone == member.Phone &&
                Adress == member.Adress;
        }
    }
}
