namespace Domain.Aggregates.NewsFeed
{
    public class Article : AggregateEntity
    {
        public Guid Id { get; private set; }
        public string Author { get; private set; }
        public string Title { get; private set; }
        public string Summary { get; private set; }
        public string Text { get; private set; }
        public Uri Url { get; private set; }
        public Uri ImageUrl { get; private set; }

        public Article(Guid id, string author, string title, string summary, string text, Uri url, Uri imageUrl)
        {
            Id = id;
            Author = author;
            Title = title;
            Summary = summary;
            Text = text;
            Url = url;
            ImageUrl = imageUrl;
        }

        internal void Update(string? author, string? title, string? summary, string? text, Uri? url, Uri? imageUrl)
        {
            Author = author ?? Author;
            Title = title ?? Title;
            Summary = summary ?? Summary;
            Text = text ?? Text;
            Url = url ?? Url;
            ImageUrl = imageUrl ?? ImageUrl;
        }
    }
}