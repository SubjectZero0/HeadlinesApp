using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Aggregates.NewsFeed
{
    [Serializable]
    public class NewsFeed : RootEntity
    {
        private List<Article> _articles;

        public Guid Id { get; private set; }
        public FeedCriteria FeedCriteria { get; private set; }
        public bool IsAvailable { get; private set; }

        public IReadOnlyCollection<Article> Articles
        { get { return _articles.ToArray(); } }

        public NewsFeed(Guid id, FeedCriteria feedCriteria, List<Article> articles, bool isAvailable)
        {
            Id = id;
            FeedCriteria = feedCriteria;
            _articles = articles;
            IsAvailable = isAvailable;
        }

        internal void Update(FeedCriteria? feedCriteria, List<Article>? articles, bool? isAvailable)
        {
            _articles = articles ?? _articles;
            FeedCriteria = feedCriteria ?? FeedCriteria;
            IsAvailable = isAvailable ?? IsAvailable;
        }

        internal void AddArticle(Article article)
        {
            _articles.Add(article);
        }

        internal void RemoveArticle(Article article)
        {
            _articles.Remove(article);
        }
    }
}