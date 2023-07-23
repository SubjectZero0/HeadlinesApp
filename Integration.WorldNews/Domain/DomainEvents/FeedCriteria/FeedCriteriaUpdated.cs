using FeedCriteriaVO = Domain.Aggregates.NewsFeed.FeedCriteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Aggregates.NewsFeed;

namespace Domain.DomainEvents.NewsFeed
{
    public class FeedCriteriaUpdated : DomainEvent
    {
        public Guid? NewsFeedId { get; private set; }
        public FeedCriteriaVO FeedCriteria { get; private set; }

        public FeedCriteriaUpdated(Guid? newsFeedId, FeedCriteriaVO feedCriteria)
        {
            NewsFeedId = newsFeedId;
            FeedCriteria = feedCriteria;
        }
    }
}