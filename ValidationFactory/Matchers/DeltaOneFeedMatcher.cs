using ValidationFactory.Models;

namespace ValidationFactory.Matchers
{
    internal class DeltaOneFeedMatcher : IFeedMatcher<DeltaOneFeed>
    {
        public bool Match(DeltaOneFeed current, DeltaOneFeed other)
        {
            return current.CounterpartyId == other.CounterpartyId
                && current.PrincipalId == other.PrincipalId;
        }
    }
}
