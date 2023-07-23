using Domain.Aggregates.NewsFeed;
using Domain.DomainEvents;
using Domain.DomainEvents.NewsFeed;
using HeadlinesApp;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Aggregates.NewsFeed.FeedCriteria;

namespace Domain.Services
{
    public interface IFeedCriteriaProcessor
    {
    }

    public class FeedCriteriaProcessor : IFeedCriteriaProcessor
    {
        private readonly ILogger _logger;

        public FeedCriteriaProcessor(ILogger logger)
        {
            _logger = logger;
        }

        public FeedCriteriaUpdated Process(FeedCriteriaMessage message)
        {
            var publishDate = new PublishDate(
                from: message.PublishDateFrom,
                to: message.PublishDateTo);

            var locationFilter = new LocationFilter(
                locationName: message.LocationName,
                longtitude: message.Longtitude,
                latitude: message.Latitude,
                radiusKm: message.RadiusKm);

            return new FeedCriteriaUpdated(newsFeedId: null, feedCriteria: new FeedCriteria(language: message.Language,
                                                                                            publishDate: publishDate,
                                                                                            locationFilter: locationFilter,
                                                                                            feedLength: message.FeedLength,
                                                                                            direction: (SortDirection)message.Direction));
        }
    }
}