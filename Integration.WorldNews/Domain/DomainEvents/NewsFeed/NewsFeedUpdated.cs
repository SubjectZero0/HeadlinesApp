using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsFeedRoot = Domain.Aggregates.NewsFeed.NewsFeed;

namespace Domain.DomainEvents.NewsFeed
{
    public class NewsFeedUpdated : DomainEvent
    {
        public NewsFeedRoot NewsFeed { get; private set; }

        public NewsFeedUpdated(NewsFeedRoot newsFeed)
        {
            NewsFeed = newsFeed;
        }
    }
}