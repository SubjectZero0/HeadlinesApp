using FeedCriteriaVO = Domain.Aggregates.NewsFeed.FeedCriteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Aggregates.NewsFeed;

namespace Domain.DomainEvents.NewsFeed
{
    public class AddOrUpdateFeedCriteria : DomainEvent
    {
        public FeedCriteriaVO FeedCriteria { get; private set; }

        public AddOrUpdateFeedCriteria(FeedCriteriaVO feedCriteria, Article[] articles)
        {
            FeedCriteria = feedCriteria;
        }
    }
}