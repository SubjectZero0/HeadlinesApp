namespace Domain.Aggregates.NewsFeed
{
    [Serializable]
    public class FeedCriteria : ValueObject
    {
        public enum SortDirection
        {
            asc = 0,
            desc = 1,
        }

        private string _sort { get; } = "publish-time";

        public string Language { get; private set; }
        public PublishDate PublishDate { get; private set; }
        public LocationFilter LocationFilter { get; private set; }
        public int FeedLength { get; private set; }
        public SortDirection Direction { get; private set; }

        public string Sort
        { get { return _sort; } }

        public FeedCriteria(
            string language,
            PublishDate publishDate,
            LocationFilter locationFilter,
            int feedLength,
            SortDirection direction)
        {
            Language = language;
            PublishDate = publishDate;
            LocationFilter = locationFilter;
            FeedLength = feedLength;
            Direction = direction;
        }

        internal void Update(
            string? language,
            PublishDate? publishDate,
            LocationFilter? locationFilter,
            int? feedLength,
            SortDirection? direction)
        {
            Language = language ?? Language;
            PublishDate = publishDate ?? PublishDate;
            LocationFilter = locationFilter ?? LocationFilter;
            FeedLength = feedLength ?? FeedLength;
            Direction = direction ?? Direction;
        }

        internal void Default()
        {
            Language = "en";
            PublishDate = new PublishDate(DateTime.UtcNow, DateTime.UtcNow.AddHours(-23));
            LocationFilter = new LocationFilter("New York", "-73.935242", "40.730610", 100);
            FeedLength = 20;
            Direction = SortDirection.desc;
        }
    }
}