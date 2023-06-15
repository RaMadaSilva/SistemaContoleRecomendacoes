using Flunt.Validations;

namespace ControleRecommads.Domain.Entities.ValueObject
{
    public class Member : Entity
    {
        private Member()
        {

        }
        public Member(Name name, uint phone, Adress adress)
        {
            AddNotifications(new Contract<Name>()
                    .Requires()
                    .IsNotNull(phone, "O numero de telefone é obrigatorio"));
            name.AddNotifications(Notifications);

            Name = name;
            Phone = phone;
            Adress = adress;

            IssuedRecommendations = new List<IssuedRecommendation>();
            ReceivedRecommendations = new List<ReceivedRecommendation>();
        }

        public Name Name { get; private set; }
        public uint Phone { get; private set; }
        public Adress Adress { get; private set; }
        public IList<IssuedRecommendation> IssuedRecommendations { get; private set; }
        public IList<ReceivedRecommendation> ReceivedRecommendations { get; private set; }

        public void AddIssuedRecommendations(IssuedRecommendation recommendation)
            => IssuedRecommendations.Add(recommendation);

        public void AddReceivedRecommendations(ReceivedRecommendation recommendation)
            => ReceivedRecommendations.Add(recommendation);

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

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
