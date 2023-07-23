using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeedCriteriaVO = Domain.Aggregates.NewsFeed.FeedCriteria;

namespace Domain.Modifications.FeedCriteria
{
    public class AddOrUpdateFeedCriteriaModification : DomainModification
    {
        public FeedCriteriaVO FeedCriteriaModification { get; private set; }

        public AddOrUpdateFeedCriteriaModification(FeedCriteriaVO modification)
        {
            FeedCriteriaModification = modification;
        }
    }
}