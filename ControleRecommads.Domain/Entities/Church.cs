namespace ControleRecommads.Domain.Entities.ValueObject
{
    public class Church : Entity
    {
        protected Church()
        {
        }
        public Church(Name name, Adress adress)
        {
            name.AddNotifications(Notifications);
            adress.AddNotifications(Notifications);

            Name = name;
            Adress = adress;

            IssuedRecommendations = new List<IssuedRecommendation>();
            ReceivedRecommendations = new List<ReceivedRecommendation>();
        }

        public Name Name { get; private set; }
        public Adress Adress { get; private set; }
        public IList<IssuedRecommendation> IssuedRecommendations { get; private set; }
        public IList<ReceivedRecommendation> ReceivedRecommendations { get; private set; }

        public void AddIssuedRecommendations(IssuedRecommendation recommendation)
            => IssuedRecommendations.Add(recommendation);

        public void AddReceivedRecommendations(ReceivedRecommendation recommendation)
            => ReceivedRecommendations.Add(recommendation);

    }
}