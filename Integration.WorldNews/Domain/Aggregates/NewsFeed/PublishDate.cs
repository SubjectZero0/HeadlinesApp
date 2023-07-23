namespace Domain.Aggregates.NewsFeed
{
    [Serializable]
    public class PublishDate : ValueObject
    {
        public DateTime From { get; private set; }
        public DateTime To { get; private set; }

        public PublishDate(DateTime from, DateTime to)
        {
            From = from;
            To = to;
        }

        internal void Update(DateTime? from, DateTime? to)
        {
            From = from ?? From;
            To = to ?? To;
        }
    }
}