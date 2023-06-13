namespace ControleRecommads.Domain.Entities.ValueObject
{
    public class Church : Entity
    {

        public Church(Name name, Adress adress)
        {
            name.AddNotifications(Notifications);
            adress.AddNotifications(Notifications);

            Name = name;
            Adress = adress;
            Recommendations = new List<Recommendation>();
        }

        public Name Name { get; private set; }
        public Adress Adress { get; private set; }
        public IList<Recommendation> Recommendations { get; private set; }
        public void AddRecommendations(Recommendation recommendation)
            => Recommendations.Add(recommendation);
    }
}