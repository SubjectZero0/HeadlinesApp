using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HeadlinesApp
{
    [Union(0, typeof(Added))]
    [KnownType(typeof(Added))]
    [Union(1, typeof(Updated))]
    [KnownType(typeof(Updated))]
    [Union(2, typeof(Removed))]
    [KnownType(typeof(Removed))]
    [MessagePackObject]
    public abstract class FeedCriteriaMessage
    {
        public enum SortDirection
        {
            asc = 0,
            desc = 1,
        }

        [Key(0)]
        public int Id { get; private set; }

        [Key(1)]
        public string Language { get; private set; }

        [Key(2)]
        public DateTime PublishDateFrom { get; private set; }

        [Key(3)]
        public DateTime PublishDateTo { get; private set; }

        [Key(4)]
        public string LocationName { get; private set; }

        [Key(5)]
        public string Longtitude { get; private set; }

        [Key(6)]
        public string Latitude { get; private set; }

        [Key(7)]
        public int RadiusKm { get; private set; }

        [Key(8)]
        public int FeedLength { get; private set; }

        [Key(9)]
        public SortDirection Direction { get; private set; }

        protected FeedCriteriaMessage(
            int id,
            string language,
            DateTime publishDateFrom,
            DateTime publishDateTo,
            string locationName,
            string longtitude,
            string latitude,
            int radiusKm,
            int feedLength,
            SortDirection direction)
        {
            Id = id;
            Language = language;
            PublishDateFrom = publishDateFrom;
            PublishDateTo = publishDateTo;
            LocationName = locationName;
            Longtitude = longtitude;
            Latitude = latitude;
            RadiusKm = radiusKm;
            FeedLength = feedLength;
            Direction = direction;
        }

        [MessagePackObject]
        public class Added : FeedCriteriaMessage
        {
            public Added(int id,
                string language,
                DateTime publishDateFrom,
                DateTime publishDateTo,
                string locationName,
                string longtitude,
                string latitude,
                int radiusKm,
                int feedLength,
                SortDirection direction) : base(id,
                                       language,
                                       publishDateFrom,
                                       publishDateTo,
                                       locationName,
                                       longtitude,
                                       latitude,
                                       radiusKm,
                                       feedLength,
                                       direction)
            {
            }
        }

        [MessagePackObject]
        public class Updated : FeedCriteriaMessage
        {
            public Updated(int id,
                string language,
                DateTime publishDateFrom,
                DateTime publishDateTo,
                string locationName,
                string longtitude,
                string latitude,
                int radiusKm,
                int feedLength,
                SortDirection direction) : base(id,
                                       language,
                                       publishDateFrom,
                                       publishDateTo,
                                       locationName,
                                       longtitude,
                                       latitude,
                                       radiusKm,
                                       feedLength,
                                       direction)
            {
            }
        }

        [MessagePackObject]
        public class Removed : FeedCriteriaMessage
        {
            public Removed(int id,
                string language,
                DateTime publishDateFrom,
                DateTime publishDateTo,
                string locationName,
                string longtitude,
                string latitude,
                int radiusKm,
                int feedLength,
                SortDirection direction) : base(id,
                                       language,
                                       publishDateFrom,
                                       publishDateTo,
                                       locationName,
                                       longtitude,
                                       latitude,
                                       radiusKm,
                                       feedLength,
                                       direction)
            {
            }
        }
    }
}