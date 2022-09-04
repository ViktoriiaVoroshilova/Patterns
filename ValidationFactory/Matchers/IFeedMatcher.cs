using ValidationFactory.Models;

namespace ValidationFactory.Matchers
{
    public interface IFeedMatcher<T> where T : TradeFeed
    {
        bool Match(T current, T other);
    }
}
