using ValidationFactory.Matchers;
using ValidationFactory.Models;
using ValidationFactory.Repository;
using ValidationFactory.Validators;

namespace ValidationFactory.Factories
{
    internal class DeltaOneFeedFactory : IContainerFactory<DeltaOneFeed>
    {
        public IFeedMatcher<DeltaOneFeed> CreateMatcher()
        {
            return new DeltaOneFeedMatcher();
        }

        public IDatabaseRepository<DeltaOneFeed> CreateRepository()
        {
            return new DatabaseRepository<DeltaOneFeed>();
        }

        public FeedValidator<DeltaOneFeed> CreateValidator()
        {
            return new DeltaOneFeedValidator();
        }
    }
}
