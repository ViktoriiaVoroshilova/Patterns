using ValidationFactory.Models;

namespace ValidationFactory.Repository
{
    internal interface IDatabaseRepository<T> where T : TradeFeed
    {
        public IEnumerable<T>LoadFeeds();

        public void SaveFeed(T feed);

        public void SaveError(int feedStagingId, string error);
    }
}
