using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsFeedRoot = Domain.Aggregates.NewsFeed.NewsFeed;

namespace Domain.DomainEvents.NewsFeed
{
    public class AddOrdUpdateNewsFeed : DomainEvent
    {
        public NewsFeedRoot NewsFeed { get; private set; }

        public AddOrdUpdateNewsFeed(NewsFeedRoot newsFeed)
        {
            NewsFeed = newsFeed;
        }
    }
}