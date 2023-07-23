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
using static HeadlinesApp.FeedCriteriaMessage;
using SortDirection = Domain.Aggregates.NewsFeed.FeedCriteria.SortDirection;

namespace Domain.Services
{
    public interface IFeedCriteriaProcessor
    {
        public FeedCriteriaUpdated? GenerateDomainEventForCreateOrUpdate(FeedCriteriaMessage message);
    }

    public class FeedCriteriaProcessor : IFeedCriteriaProcessor
    {
        private readonly ILogger _logger;

        public FeedCriteriaProcessor(ILogger logger)
        {
            _logger = logger;
        }

        public FeedCriteriaUpdated? GenerateDomainEventForCreateOrUpdate(FeedCriteriaMessage message)
        {
            try
            {
                var publishDate = new PublishDate(
                    from: message.PublishDateFrom,
                    to: message.PublishDateTo);

                var locationFilter = new LocationFilter(
                    locationName: message.LocationName,
                    longtitude: message.Longtitude,
                    latitude: message.Latitude,
                    radiusKm: message.RadiusKm);

                var feedCriteria = new FeedCriteria(
                    language: message.Language,
                    publishDate: publishDate,
                    locationFilter: locationFilter,
                    feedLength: message.FeedLength,
                    direction: (SortDirection)message.Direction);

                switch (message)
                {
                    case FeedCriteriaMessage.Added added:
                        return new FeedCriteriaUpdated(newsFeedId: null, feedCriteria: feedCriteria);

                    case FeedCriteriaMessage.Removed removed:
                        return new FeedCriteriaUpdated(newsFeedId: removed.NewsfeedId, feedCriteria: feedCriteria);

                    case FeedCriteriaMessage.Updated updated:
                        return new FeedCriteriaUpdated(newsFeedId: updated.NewsfeedId, feedCriteria: feedCriteria);

                    default:
                        throw new Exception($"FeedCriteriaUpdated message type {message.GetType()} not expected");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return null;
            }
        }
    }
}