using ValidationFactory.Models;

namespace ValidationFactory.Matchers
{
    internal class EmFeedMatcher : IFeedMatcher<EmFeed>
    {
        public bool Match(EmFeed current, EmFeed other)
        {
            if (current.SourceAccountId.HasValue && other.SourceAccountId.HasValue)
            {
                return current.SourceAccountId.Value == other.SourceAccountId.Value;
            }

            return current.StagingId == other.StagingId;
        }
    }
}
