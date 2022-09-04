using System.Collections.Concurrent;
using ValidationFactory.Models;

namespace ValidationFactory.Repository
{
    internal class DatabaseRepository<T> : IDatabaseRepository<T> where T : TradeFeed
    {
        public IEnumerable<T> LoadFeeds()
        {
            return _feeds;
        }

        public void SaveError(int feedStagingId, string error)
        {
            _errors.AddOrUpdate(feedStagingId, new List<string> { error }, (_, previous) =>
            {
                previous.Add(error);
                return previous;
            });
        }

        public void SaveFeed(T feed)
        {
            if (feed != null) _feeds.Add(feed);
        }

        private readonly ConcurrentDictionary<int, List<string>> _errors = new ();
        private readonly ConcurrentBag<T> _feeds = new();
    }
}
