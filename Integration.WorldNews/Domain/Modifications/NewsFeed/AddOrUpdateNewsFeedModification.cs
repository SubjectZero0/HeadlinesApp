using Domain.Aggregates.NewsFeed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsFeedRoot = Domain.Aggregates.NewsFeed.NewsFeed;

namespace Domain.Modifications.NewsFeed
{
    public class AddOrUpdateNewsFeedModification : DomainModification
    {
        public NewsFeedRoot NewsFeedModification { get; private set; }

        public AddOrUpdateNewsFeedModification(NewsFeedRoot modification)
        {
            NewsFeedModification = modification;
        }
    }
}