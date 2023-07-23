using Domain.DomainEvents.NewsFeed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface INewsFeedMessageProcessor
    {
        AddOrUpdateFeedCriteria Process();
    }

    public class FeedCriteriaProcessor : INewsFeedMessageProcessor
    {
        public AddOrUpdateFeedCriteria Process()
        {
            throw new NotImplementedException();
        }
    }
}