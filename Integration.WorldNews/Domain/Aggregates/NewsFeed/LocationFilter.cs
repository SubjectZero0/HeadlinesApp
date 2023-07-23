namespace Domain.Aggregates.NewsFeed
{
    [Serializable]
    public class LocationFilter : ValueObject
    {
        public string LocationName { get; private set; }
        public string Longtitude { get; private set; }
        public string Latitude { get; private set; }

        public LocationFilter(string locationName, string longtitude, string latitude)
        {
            LocationName = locationName;
            Longtitude = longtitude;
            Latitude = latitude;
        }

        internal void Update(string? locationName, string? longtitude, string? latitude)
        {
            LocationName = locationName ?? LocationName;
            Longtitude = longtitude ?? Longtitude;
            Latitude = latitude ?? Latitude;
        }
    }
}